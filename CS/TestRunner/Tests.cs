using NUnit.Framework;
using System.Diagnostics;
using System.IO;
using System.Windows.Automation;

namespace TestRunner {

    [TestFixture]
    public class Tests {

        readonly string appRelativePath = @"..\..\..\..\UIAutomationTestingExample\bin\Debug\UIAutomationTestingExample.exe";
        readonly string usernameAccessibleName = "Username";
        readonly string passwordAccessibleName = "Password";
        readonly string logInButtonAccessibleName = "Log In";
        readonly string logInFormAccessibleName = "CRM Log In Form";
        readonly string customersFormAccessibleName = "CRM Customers Form";
        readonly string customersGridAutomationID = "customersGrid";
        readonly string testExistingUserLogin = "TestExistingUser";
        readonly string testExistingUserPassword = "nJt34%77fytpl";

        string appFullPath;
        AutomationElement loginForm;
        AutomationElement customersForm;
        Process appProcess;
        Action afterLogInAction;

        [SetUp]
        public void Setup() {
            appFullPath = Path.Combine(TestContext.CurrentContext.TestDirectory, appRelativePath);
            appProcess = Process.Start(appFullPath);
        }
        [TearDown]
        public void TearDown() {
            appProcess.Kill();
        }

        [Test]
        public void ExistingUsernameLoginTest() {
            afterLogInAction = CheckSuccessMessageBox;
            LogIn(testExistingUserLogin, testExistingUserPassword);
        }

        
        [Test]
        public void NonExistingUsernameLoginTest() {
            afterLogInAction = CheckErrorLabel;
            LogIn("TestNonExistingUser", "123456");
        }

        [Test]
        public void ModifiedCustomerTest() {
            LogIn(testExistingUserLogin, testExistingUserPassword);

            // Finds the GridControl and gets its TablePattern.
            customersForm = AutomationElement.RootElement.FindFirstByNameWithTimeout(TreeScope.Children, customersFormAccessibleName, 10000);
            AutomationElement customersGrid = customersForm.FindFirstByIdWithTimeout(TreeScope.Children, customersGridAutomationID, 10000);
            TablePattern customersTablePattern = (TablePattern)customersGrid.GetCurrentPattern(TablePattern.Pattern);

            // Activates a cell within the GridControl.
            AutomationElement cellToUpdate = customersTablePattern.GetItem(1, 1);
            InvokePattern testCellInvokePattern = (InvokePattern)cellToUpdate.GetCurrentPattern(InvokePattern.Pattern);
            testCellInvokePattern.Invoke();

            // Modifies the cell's value.
            AutomationElement editingControl = customersGrid.FindFirstByNameWithTimeout(TreeScope.Descendants, "Editing control", 1000);
            ValuePattern editedCellValuePattern = (ValuePattern)editingControl.GetCurrentPattern(ValuePattern.Pattern);
            editedCellValuePattern.SetValue("Value updated!");
            Thread.Sleep(1000); // Sets a delay for demonstration purposes.

            // Selects the next data row.
            AutomationElement nextRowCell = customersTablePattern.GetItem(2, 1);
            SelectionItemPattern selectionItemPattern = (SelectionItemPattern)TreeWalker.ControlViewWalker.GetParent(nextRowCell).GetCurrentPattern(SelectionItemPattern.Pattern);
            selectionItemPattern.Select();
            Thread.Sleep(1000); 

            // Checks if the value in the "Is Modified" column has changed.
            int isModifiedColumnIndex = customersTablePattern.Current.GetColumnHeaders().ToList().FindIndex(h => h.Current.Name == "Is Modified");
            AutomationElement isModifiedCell = customersTablePattern.GetItem(1, isModifiedColumnIndex);
            ValuePattern isModifiedCellValuePattern = (ValuePattern)isModifiedCell.GetCurrentPattern(ValuePattern.Pattern);
            Assert.That(isModifiedCellValuePattern.Current.Value, Is.EqualTo("Checked"));
        }
        void CheckSuccessMessageBox() {
            customersForm = AutomationElement.RootElement.FindFirstByNameWithTimeout(TreeScope.Children, customersFormAccessibleName, 10000);
            Assert.That(customersForm, Is.Not.Null);
        }
        void CheckErrorLabel() {
            AutomationElement errorLabelElement = loginForm.FindFirstByNameWithTimeout(TreeScope.Children, "Invalid User or Password", 10000);
            Assert.That(errorLabelElement, Is.Not.Null);
        }
        
        void LogIn(string username, string password) {
            // Find the LogIn form and its main elements.
            loginForm = AutomationElement.RootElement.FindFirstByNameWithTimeout(TreeScope.Children, logInFormAccessibleName, 10000);
            AutomationElement usernameElement = loginForm.FindFirstByNameWithTimeout(TreeScope.Children, usernameAccessibleName, 10000);
            AutomationElement passwordElement = loginForm.FindFirstByNameWithTimeout(TreeScope.Children, passwordAccessibleName, 10000);
            AutomationElement logInButtonElement = loginForm.FindFirstByNameWithTimeout(TreeScope.Children, logInButtonAccessibleName, 10000);

            // Gets automation patterns to set editor values.
            ValuePattern usernameValuePattern = (ValuePattern)usernameElement.GetCurrentPattern(ValuePattern.Pattern);
            ValuePattern passwordValuePattern = (ValuePattern)passwordElement.GetCurrentPattern(ValuePattern.Pattern);
            InvokePattern invokePattern = (InvokePattern)logInButtonElement.GetCurrentPattern(InvokePattern.Pattern);

            // Sets editor values. Fills in username and password input fields.
            usernameValuePattern.SetValue(username);
            passwordValuePattern.SetValue(password);
            invokePattern.Invoke();

            // Performs an action after a log in attempt.
            afterLogInAction?.Invoke();
        }
    }
    public static class AutomationElementExtensions {
        public static AutomationElement FindFirstWithTimeout(this AutomationElement @this,
        TreeScope scope, Condition condition, int timeoutMilliseconds = 1000) {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            do {
                var result = @this.FindFirst(scope, condition);
                if (result != null)
                    return result;
                Thread.Sleep(100);
            }
            while (stopwatch.ElapsedMilliseconds < timeoutMilliseconds);
            return null;
        }
        public static AutomationElement FindFirstByNameWithTimeout(this AutomationElement @this,
        TreeScope scope, string name, int timeoutMilliseconds = 1000) {
            return FindFirstWithTimeout(@this, scope, new PropertyCondition(AutomationElement.NameProperty, name), timeoutMilliseconds);
        }
        public static AutomationElement FindFirstByIdWithTimeout(this AutomationElement @this,
        TreeScope scope, string name, int timeoutMilliseconds = 1000) {
            return FindFirstWithTimeout(@this, scope, new PropertyCondition(AutomationElement.AutomationIdProperty, name), timeoutMilliseconds);
        }
    }
}