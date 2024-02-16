Imports DevExpress.XtraEditors
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace UIAutomationTestingExample

    Public Partial Class LogInForm
        Inherits XtraForm

        Private userService As UserService = New UserService()

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Async Sub logInButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            logInButton.Enabled = False
            Dim errorText As String = Await userService.LogIn(userNameEditor.Text, passwordEditor.Text)
            If Not String.IsNullOrEmpty(errorText) Then
                errorLabel.Text = errorText
                errorLabel.Visible = True
                logInButton.Enabled = True
            Else
                errorLabel.Text = String.Empty
                errorLabel.Visible = False
                DialogResult = DialogResult.OK
                logInButton.Enabled = True
                Close()
            End If
        End Sub
    End Class

    Public Class UserService

        Private TestValidUsername As String = "TestExistingUser"

        Private TestValidPassword As String = "nJt34%77fytpl"

        Public Async Function LogIn(ByVal username As String, ByVal password As String) As Task(Of String)
            Await Task.Delay(2000) ' Sets the delay for demonstration purposes.
            If Equals(username, TestValidUsername) AndAlso Equals(password, TestValidPassword) Then
                Return String.Empty
            Else
                Return "Invalid User or Password"
            End If
        End Function
    End Class
End Namespace
