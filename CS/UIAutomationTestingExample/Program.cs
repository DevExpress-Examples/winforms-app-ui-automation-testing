using System;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace UIAutomationTestingExample {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            WindowsFormsSettings.UseUIAutomation = DefaultBoolean.True;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LogInForm loginForm = new LogInForm();
            if (loginForm.ShowDialog() == DialogResult.OK) {
                CustomersForm customersForm = new CustomersForm();
                Application.Run(customersForm);
            }
        }
    }
}
