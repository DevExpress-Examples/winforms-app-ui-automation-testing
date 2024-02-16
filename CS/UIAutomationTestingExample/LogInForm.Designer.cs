namespace UIAutomationTestingExample {
    partial class LogInForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.userNameEditor = new DevExpress.XtraEditors.TextEdit();
            this.passwordEditor = new DevExpress.XtraEditors.TextEdit();
            this.logInButton = new DevExpress.XtraEditors.SimpleButton();
            this.welcomeLabel = new DevExpress.XtraEditors.LabelControl();
            this.errorLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.userNameEditor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEditor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameEditor
            // 
            this.userNameEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameEditor.Location = new System.Drawing.Point(42, 76);
            this.userNameEditor.Name = "userNameEditor";
            this.userNameEditor.Properties.AccessibleName = "Username";
            this.userNameEditor.Properties.AdvancedModeOptions.Label = "Username";
            this.userNameEditor.Size = new System.Drawing.Size(421, 42);
            this.userNameEditor.TabIndex = 0;
            // 
            // passwordEditor
            // 
            this.passwordEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordEditor.Location = new System.Drawing.Point(42, 143);
            this.passwordEditor.Name = "passwordEditor";
            this.passwordEditor.Properties.AccessibleName = "Password";
            this.passwordEditor.Properties.AdvancedModeOptions.Label = "Password";
            this.passwordEditor.Properties.PasswordChar = '*';
            this.passwordEditor.Size = new System.Drawing.Size(421, 42);
            this.passwordEditor.TabIndex = 1;
            // 
            // logInButton
            // 
            this.logInButton.AccessibleName = "Log In";
            this.logInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.logInButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.logInButton.Appearance.Options.UseBackColor = true;
            this.logInButton.Location = new System.Drawing.Point(42, 255);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(421, 41);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Log In";
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.welcomeLabel.Appearance.Options.UseFont = true;
            this.welcomeLabel.Location = new System.Drawing.Point(126, 18);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(266, 33);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Welcome to Your CRM";
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLabel.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            this.errorLabel.Appearance.Options.UseForeColor = true;
            this.errorLabel.Location = new System.Drawing.Point(42, 200);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(47, 13);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.Text = "error text";
            this.errorLabel.Visible = false;
            // 
            // LogInForm
            // 
            this.AccessibleName = "CRM Log In Form";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 332);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordEditor);
            this.Controls.Add(this.userNameEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.userNameEditor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEditor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit userNameEditor;
        private DevExpress.XtraEditors.TextEdit passwordEditor;
        private DevExpress.XtraEditors.SimpleButton logInButton;
        private DevExpress.XtraEditors.LabelControl welcomeLabel;
        private DevExpress.XtraEditors.LabelControl errorLabel;
    }
}

