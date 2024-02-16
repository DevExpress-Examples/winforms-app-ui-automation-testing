using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIAutomationTestingExample {
    public partial class LogInForm : DevExpress.XtraEditors.XtraForm {
        UserService userService = new UserService();
        public LogInForm() {
            InitializeComponent();
        }

        async void logInButton_Click(object sender, EventArgs e) {
            logInButton.Enabled = false;
            string errorText = await userService.LogIn(userNameEditor.Text, passwordEditor.Text);
            if (!string.IsNullOrEmpty(errorText)) {
                errorLabel.Text = errorText;
                errorLabel.Visible = true;
                logInButton.Enabled = true;
            }
            else {
                errorLabel.Text = string.Empty;
                errorLabel.Visible = false;
                DialogResult = DialogResult.OK;
                logInButton.Enabled = true;
                Close();
            }
        }
    }

    public class UserService {
        string TestValidUsername = "TestExistingUser";
        string TestValidPassword = "nJt34%77fytpl";
        public async Task<string> LogIn(string username, string password) {
            await Task.Delay(2000); // Sets the delay for demonstration purposes.
            if (username == TestValidUsername && password == TestValidPassword)
                return string.Empty;
            else
                return "Invalid User or Password";

        }
    }
}
