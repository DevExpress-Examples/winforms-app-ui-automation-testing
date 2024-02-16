Namespace UIAutomationTestingExample

    Partial Class LogInForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.userNameEditor = New DevExpress.XtraEditors.TextEdit()
            Me.passwordEditor = New DevExpress.XtraEditors.TextEdit()
            Me.logInButton = New DevExpress.XtraEditors.SimpleButton()
            Me.welcomeLabel = New DevExpress.XtraEditors.LabelControl()
            Me.errorLabel = New DevExpress.XtraEditors.LabelControl()
            CType((Me.userNameEditor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.passwordEditor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' userNameEditor
            ' 
            Me.userNameEditor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.userNameEditor.Location = New System.Drawing.Point(42, 76)
            Me.userNameEditor.Name = "userNameEditor"
            Me.userNameEditor.Properties.AccessibleName = "Username"
            Me.userNameEditor.Properties.AdvancedModeOptions.Label = "Username"
            Me.userNameEditor.Size = New System.Drawing.Size(421, 42)
            Me.userNameEditor.TabIndex = 0
            ' 
            ' passwordEditor
            ' 
            Me.passwordEditor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.passwordEditor.Location = New System.Drawing.Point(42, 143)
            Me.passwordEditor.Name = "passwordEditor"
            Me.passwordEditor.Properties.AccessibleName = "Password"
            Me.passwordEditor.Properties.AdvancedModeOptions.Label = "Password"
            Me.passwordEditor.Properties.PasswordChar = "*"c
            Me.passwordEditor.Size = New System.Drawing.Size(421, 42)
            Me.passwordEditor.TabIndex = 1
            ' 
            ' logInButton
            ' 
            Me.logInButton.AccessibleName = "Log In"
            Me.logInButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.logInButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
            Me.logInButton.Appearance.Options.UseBackColor = True
            Me.logInButton.Location = New System.Drawing.Point(42, 255)
            Me.logInButton.Name = "logInButton"
            Me.logInButton.Size = New System.Drawing.Size(421, 41)
            Me.logInButton.TabIndex = 2
            Me.logInButton.Text = "Log In"
            AddHandler Me.logInButton.Click, New System.EventHandler(AddressOf Me.logInButton_Click)
            ' 
            ' welcomeLabel
            ' 
            Me.welcomeLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.welcomeLabel.Appearance.Font = New System.Drawing.Font("Tahoma", 20F)
            Me.welcomeLabel.Appearance.Options.UseFont = True
            Me.welcomeLabel.Location = New System.Drawing.Point(126, 18)
            Me.welcomeLabel.Name = "welcomeLabel"
            Me.welcomeLabel.Size = New System.Drawing.Size(266, 33)
            Me.welcomeLabel.TabIndex = 3
            Me.welcomeLabel.Text = "Welcome to Your CRM"
            ' 
            ' errorLabel
            ' 
            Me.errorLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.errorLabel.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical
            Me.errorLabel.Appearance.Options.UseForeColor = True
            Me.errorLabel.Location = New System.Drawing.Point(42, 200)
            Me.errorLabel.Name = "errorLabel"
            Me.errorLabel.Size = New System.Drawing.Size(47, 13)
            Me.errorLabel.TabIndex = 4
            Me.errorLabel.Text = "error text"
            Me.errorLabel.Visible = False
            ' 
            ' LogInForm
            ' 
            Me.AccessibleName = "CRM Log In Form"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(503, 332)
            Me.Controls.Add(Me.errorLabel)
            Me.Controls.Add(Me.welcomeLabel)
            Me.Controls.Add(Me.logInButton)
            Me.Controls.Add(Me.passwordEditor)
            Me.Controls.Add(Me.userNameEditor)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "LogInForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Log In"
            CType((Me.userNameEditor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.passwordEditor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private userNameEditor As DevExpress.XtraEditors.TextEdit

        Private passwordEditor As DevExpress.XtraEditors.TextEdit

        Private logInButton As DevExpress.XtraEditors.SimpleButton

        Private welcomeLabel As DevExpress.XtraEditors.LabelControl

        Private errorLabel As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace
