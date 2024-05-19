namespace App.GUI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            TextBox_Enter_UsernameID = new Guna.UI2.WinForms.Guna2TextBox();
            TextBox_Enter_Password = new Guna.UI2.WinForms.Guna2TextBox();
            Button_Log_In = new Guna.UI2.WinForms.Guna2Button();
            Label_CreateAccount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // TextBox_Enter_UsernameID
            // 
            TextBox_Enter_UsernameID.CustomizableEdges = customizableEdges7;
            TextBox_Enter_UsernameID.DefaultText = "";
            TextBox_Enter_UsernameID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_Enter_UsernameID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_Enter_UsernameID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_Enter_UsernameID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_Enter_UsernameID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            resources.ApplyResources(TextBox_Enter_UsernameID, "TextBox_Enter_UsernameID");
            TextBox_Enter_UsernameID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_Enter_UsernameID.Name = "TextBox_Enter_UsernameID";
            TextBox_Enter_UsernameID.PasswordChar = '\0';
            TextBox_Enter_UsernameID.PlaceholderText = "";
            TextBox_Enter_UsernameID.SelectedText = "";
            TextBox_Enter_UsernameID.ShadowDecoration.CustomizableEdges = customizableEdges8;
            // 
            // TextBox_Enter_Password
            // 
            TextBox_Enter_Password.CustomizableEdges = customizableEdges9;
            TextBox_Enter_Password.DefaultText = "";
            TextBox_Enter_Password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_Enter_Password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_Enter_Password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_Enter_Password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_Enter_Password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            resources.ApplyResources(TextBox_Enter_Password, "TextBox_Enter_Password");
            TextBox_Enter_Password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_Enter_Password.Name = "TextBox_Enter_Password";
            TextBox_Enter_Password.PasswordChar = '\0';
            TextBox_Enter_Password.PlaceholderText = "";
            TextBox_Enter_Password.SelectedText = "";
            TextBox_Enter_Password.ShadowDecoration.CustomizableEdges = customizableEdges10;
            // 
            // Button_Log_In
            // 
            Button_Log_In.BorderRadius = 25;
            Button_Log_In.CustomizableEdges = customizableEdges11;
            Button_Log_In.DisabledState.BorderColor = Color.DarkGray;
            Button_Log_In.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Log_In.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Log_In.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Log_In.FillColor = Color.FromArgb(29, 73, 167);
            resources.ApplyResources(Button_Log_In, "Button_Log_In");
            Button_Log_In.ForeColor = Color.White;
            Button_Log_In.Name = "Button_Log_In";
            Button_Log_In.ShadowDecoration.CustomizableEdges = customizableEdges12;
            // 
            // Label_CreateAccount
            // 
            Label_CreateAccount.BackColor = Color.Transparent;
            resources.ApplyResources(Label_CreateAccount, "Label_CreateAccount");
            Label_CreateAccount.ForeColor = Color.FromArgb(29, 73, 167);
            Label_CreateAccount.Name = "Label_CreateAccount";
            Label_CreateAccount.Click += Label_Sign_Up_Click;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Label_CreateAccount);
            Controls.Add(Button_Log_In);
            Controls.Add(TextBox_Enter_Password);
            Controls.Add(TextBox_Enter_UsernameID);
            DoubleBuffered = true;
            Name = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TextBox_Enter_UsernameID;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Enter_Password;
        private Guna.UI2.WinForms.Guna2Button Button_Log_In;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_CreateAccount;
    }
}