Imports System
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace UIAutomationTestingExample

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            WindowsFormsSettings.UseUIAutomation = DefaultBoolean.True
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Dim loginForm As LogInForm = New LogInForm()
            If loginForm.ShowDialog() = DialogResult.OK Then
                Dim customersForm As CustomersForm = New CustomersForm()
                Application.Run(customersForm)
            End If
        End Sub
    End Module
End Namespace
