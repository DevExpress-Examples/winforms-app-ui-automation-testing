Imports NUnit.Framework
Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Threading
Imports System.Windows.Automation
Imports System.Runtime.CompilerServices

Namespace TestRunner

    <TestFixture>
    Public Class Tests

        Private ReadOnly appRelativePath As String = "..\..\..\..\UIAutomationTestingExample\bin\Debug\UIAutomationTestingExample.exe"

        Private ReadOnly usernameAccessbleName As String = "Username"

        Private ReadOnly passwordAccessbleName As String = "Password"

        Private ReadOnly logInButtonAccessbleName As String = "Log In"

        Private ReadOnly logInFormAccessbleName As String = "CRM Log In Form"

        Private ReadOnly customersFormAccessbleName As String = "CRM Customers Form"

        Private ReadOnly customersGridAutomationID As String = "customersGrid"

        Private ReadOnly testExistingUserLogin As String = "TestExistingUser"

        Private ReadOnly testExistingUserPassword As String = "nJt34%77fytpl"

        Private appFullPath As String

        Private loginForm As AutomationElement

        Private customersForm As AutomationElement

        Private appProcess As Process

        Private afterLogInAction As Action

        <SetUp>
        Public Sub Setup()
            appFullPath = Path.Combine(TestContext.CurrentContext.TestDirectory, appRelativePath)
            appProcess = Process.Start(appFullPath)
        End Sub

        <TearDown>
        Public Sub TearDown()
            appProcess.Kill()
        End Sub

        <Test>
        Public Sub ExistingUsernameLoginTest()
            afterLogInAction = AddressOf CheckSuccessMessageBox
            LogIn(testExistingUserLogin, testExistingUserPassword)
        End Sub

        <Test>
        Public Sub NonExistingUsernameLoginTest()
            afterLogInAction = AddressOf CheckErrorLabel
            LogIn("TestNonExistingUser", "123456")
        End Sub

        <Test>
        Public Sub ModifiedCustomerTest()
            LogIn(testExistingUserLogin, testExistingUserPassword)
            ' Finds the GridControl and gets its TablePattern.
            customersForm = AutomationElement.RootElement.FindFirstByNameWithTimeout(TreeScope.Children, customersFormAccessbleName, 10000)
            Dim customersGrid As AutomationElement = customersForm.FindFirstByIdWithTimeout(TreeScope.Children, customersGridAutomationID, 10000)
            Dim customersTablePattern As TablePattern = CType(customersGrid.GetCurrentPattern(TablePattern.Pattern), TablePattern)
            ' Activates a cell within the GridControl.
            Dim cellToUpdate As AutomationElement = customersTablePattern.GetItem(1, 1)
            Dim testCellInvokePattern As InvokePattern = CType(cellToUpdate.GetCurrentPattern(InvokePattern.Pattern), InvokePattern)
            testCellInvokePattern.Invoke()
            ' Modifies the cell's value.
            Dim editingControl As AutomationElement = customersGrid.FindFirstByNameWithTimeout(TreeScope.Descendants, "Editing control", 1000)
            Dim editedCellValuePattern As ValuePattern = CType(editingControl.GetCurrentPattern(ValuePattern.Pattern), ValuePattern)
            editedCellValuePattern.SetValue("Value updated!")
            Thread.Sleep(1000) ' Sets a delay for demonstration purposes.
            ' Selects the next data row.
            Dim nextRowCell As AutomationElement = customersTablePattern.GetItem(2, 1)
            Dim selectionItemPattern As SelectionItemPattern = CType(TreeWalker.ControlViewWalker.GetParent(nextRowCell).GetCurrentPattern(SelectionItemPattern.Pattern), SelectionItemPattern)
            selectionItemPattern.Select()
            Thread.Sleep(1000)
            ' Checks if the value in the "Is Modified" column has changed.
            Dim isModiedColumnIndex As Integer = Enumerable.ToList(customersTablePattern.Current.GetColumnHeaders()).FindIndex(Function(h) Equals(h.Current.Name, "Is Modified"))
            Dim isModifiedCell As AutomationElement = customersTablePattern.GetItem(1, isModiedColumnIndex)
            Dim isModifiedCellValuePattern As ValuePattern = CType(isModifiedCell.GetCurrentPattern(ValuePattern.Pattern), ValuePattern)
            Assert.AreEqual(isModifiedCellValuePattern.Current.Value, "Checked")
        End Sub

        Private Sub CheckSuccessMessageBox()
            customersForm = AutomationElement.RootElement.FindFirstByNameWithTimeout(TreeScope.Children, customersFormAccessbleName, 10000)
            Assert.IsNotNull(customersForm)
        End Sub

        Private Sub CheckErrorLabel()
            Dim errorLabelElement As AutomationElement = loginForm.FindFirstByNameWithTimeout(TreeScope.Children, "Invalid User or Password", 10000)
            Assert.IsNotNull(errorLabelElement)
        End Sub

        Private Sub LogIn(ByVal username As String, ByVal password As String)
            ' Find the LogIn form and its main elements.
            loginForm = AutomationElement.RootElement.FindFirstByNameWithTimeout(TreeScope.Children, logInFormAccessbleName, 10000)
            Dim usernameElement As AutomationElement = loginForm.FindFirstByNameWithTimeout(TreeScope.Children, usernameAccessbleName, 10000)
            Dim passwordElement As AutomationElement = loginForm.FindFirstByNameWithTimeout(TreeScope.Children, passwordAccessbleName, 10000)
            Dim logInButtonElement As AutomationElement = loginForm.FindFirstByNameWithTimeout(TreeScope.Children, logInButtonAccessbleName, 10000)
            ' Gets automation patterns to set editor values.
            Dim usernameValuePattern As ValuePattern = CType(usernameElement.GetCurrentPattern(ValuePattern.Pattern), ValuePattern)
            Dim passwordValuePattern As ValuePattern = CType(passwordElement.GetCurrentPattern(ValuePattern.Pattern), ValuePattern)
            Dim invokePattern As InvokePattern = CType(logInButtonElement.GetCurrentPattern(InvokePattern.Pattern), InvokePattern)
            ' Sets editor values. Fills in username and password input fields.
            usernameValuePattern.SetValue(username)
            passwordValuePattern.SetValue(password)
            invokePattern.Invoke()
            ' Performs an action after a log in attempt.
            afterLogInAction?.Invoke()
        End Sub
    End Class

    Public Module AutomationElementExtensions

        <Extension()>
        Public Function FindFirstWithTimeout(ByVal this As AutomationElement, ByVal scope As TreeScope, ByVal condition As Condition, ByVal Optional timeoutMilliseconds As Integer = 1000) As AutomationElement
            Dim stopwatch As Stopwatch = New Stopwatch()
            stopwatch.Start()
            Do
                Dim result = this.FindFirst(scope, condition)
                If result IsNot Nothing Then Return result
                Thread.Sleep(100)
            Loop While stopwatch.ElapsedMilliseconds < timeoutMilliseconds

            Return Nothing
        End Function

        <Extension()>
        Public Function FindFirstByNameWithTimeout(ByVal this As AutomationElement, ByVal scope As TreeScope, ByVal name As String, ByVal Optional timeoutMilliseconds As Integer = 1000) As AutomationElement
            Return FindFirstWithTimeout(this, scope, New PropertyCondition(AutomationElement.NameProperty, name), timeoutMilliseconds)
        End Function

        <Extension()>
        Public Function FindFirstByIdWithTimeout(ByVal this As AutomationElement, ByVal scope As TreeScope, ByVal name As String, ByVal Optional timeoutMilliseconds As Integer = 1000) As AutomationElement
            Return FindFirstWithTimeout(this, scope, New PropertyCondition(AutomationElement.AutomationIdProperty, name), timeoutMilliseconds)
        End Function
    End Module
End Namespace
