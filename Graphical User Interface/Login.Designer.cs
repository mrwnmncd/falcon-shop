using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Guna.UI2.WinForms.Enums;
using System.ComponentModel;

namespace App.GUI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            CustomizableEdges customizableEdges1 = new CustomizableEdges();
            CustomizableEdges customizableEdges2 = new CustomizableEdges();
            CustomizableEdges customizableEdges3 = new CustomizableEdges();
            CustomizableEdges customizableEdges4 = new CustomizableEdges();
            CustomizableEdges customizableEdges5 = new CustomizableEdges();
            CustomizableEdges customizableEdges6 = new CustomizableEdges();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Login));
            CustomizableEdges customizableEdges7 = new CustomizableEdges();
            CustomizableEdges customizableEdges11 = new CustomizableEdges();
            CustomizableEdges customizableEdges12 = new CustomizableEdges();
            CustomizableEdges customizableEdges8 = new CustomizableEdges();
            CustomizableEdges customizableEdges9 = new CustomizableEdges();
            CustomizableEdges customizableEdges10 = new CustomizableEdges();
            CTRL_TextBox_Enter_Username = new Guna2TextBox();
            CTRL_TextBox_Enter_Password = new Guna2TextBox();
            CTRL_Button_Login = new Guna2GradientButton();
            Button_LOGIN_DEMO = new Guna2CircleButton();
            Container_LOGIN_FORM = new Guna2ContainerControl();
            UI_Elements_2 = new Guna2PictureBox();
            CRL_Label_HEADING_2 = new Guna2HtmlLabel();
            Label__Login = new Guna2HtmlLabel();
            Label__HEADING_1 = new Guna2HtmlLabel();
            UI_Elements_1 = new Guna2Shapes();
            Container_LOGIN_FORM.SuspendLayout();
            ((ISupportInitialize)UI_Elements_2).BeginInit();
            SuspendLayout();
            // 
            // TextBox_Input_USERNAME
            // 
            CTRL_TextBox_Enter_Username.BorderColor = Color.Transparent;
            CTRL_TextBox_Enter_Username.BorderRadius = 15;
            CTRL_TextBox_Enter_Username.BorderThickness = 0;
            CTRL_TextBox_Enter_Username.Cursor = Cursors.IBeam;
            CTRL_TextBox_Enter_Username.CustomizableEdges = customizableEdges1;
            CTRL_TextBox_Enter_Username.DefaultText = "";
            CTRL_TextBox_Enter_Username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            CTRL_TextBox_Enter_Username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            CTRL_TextBox_Enter_Username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            CTRL_TextBox_Enter_Username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            CTRL_TextBox_Enter_Username.FillColor = Color.PowderBlue;
            CTRL_TextBox_Enter_Username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            CTRL_TextBox_Enter_Username.Font = new Font("Segoe UI", 9F);
            CTRL_TextBox_Enter_Username.ForeColor = Color.Gray;
            CTRL_TextBox_Enter_Username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            CTRL_TextBox_Enter_Username.Location = new Point(30, 242);
            CTRL_TextBox_Enter_Username.Margin = new Padding(3, 5, 3, 5);
            CTRL_TextBox_Enter_Username.Name = "TextBox_Input_USERNAME";
            CTRL_TextBox_Enter_Username.PasswordChar = '\0';
            CTRL_TextBox_Enter_Username.PlaceholderForeColor = Color.Gray;
            CTRL_TextBox_Enter_Username.PlaceholderText = "Username";
            CTRL_TextBox_Enter_Username.SelectedText = "";
            CTRL_TextBox_Enter_Username.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CTRL_TextBox_Enter_Username.Size = new Size(353, 60);
            CTRL_TextBox_Enter_Username.TabIndex = 0;
            CTRL_TextBox_Enter_Username.TextAlign = HorizontalAlignment.Right;
            // 
            // TextBox_Input_PASSWORD
            // 
            CTRL_TextBox_Enter_Password.BorderColor = Color.Transparent;
            CTRL_TextBox_Enter_Password.BorderRadius = 15;
            CTRL_TextBox_Enter_Password.BorderThickness = 0;
            CTRL_TextBox_Enter_Password.Cursor = Cursors.IBeam;
            CTRL_TextBox_Enter_Password.CustomizableEdges = customizableEdges3;
            CTRL_TextBox_Enter_Password.DefaultText = "";
            CTRL_TextBox_Enter_Password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            CTRL_TextBox_Enter_Password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            CTRL_TextBox_Enter_Password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            CTRL_TextBox_Enter_Password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            CTRL_TextBox_Enter_Password.FillColor = Color.PowderBlue;
            CTRL_TextBox_Enter_Password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            CTRL_TextBox_Enter_Password.Font = new Font("Segoe UI", 9F);
            CTRL_TextBox_Enter_Password.ForeColor = Color.Gray;
            CTRL_TextBox_Enter_Password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            CTRL_TextBox_Enter_Password.Location = new Point(30, 334);
            CTRL_TextBox_Enter_Password.Margin = new Padding(3, 5, 3, 5);
            CTRL_TextBox_Enter_Password.Name = "TextBox_Input_PASSWORD";
            CTRL_TextBox_Enter_Password.PasswordChar = '*';
            CTRL_TextBox_Enter_Password.PlaceholderForeColor = Color.Gray;
            CTRL_TextBox_Enter_Password.PlaceholderText = "Password";
            CTRL_TextBox_Enter_Password.SelectedText = "";
            CTRL_TextBox_Enter_Password.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CTRL_TextBox_Enter_Password.Size = new Size(353, 60);
            CTRL_TextBox_Enter_Password.TabIndex = 3;
            CTRL_TextBox_Enter_Password.TextAlign = HorizontalAlignment.Right;
            // 
            // Button_LOGIN
            // 
            CTRL_Button_Login.BorderColor = Color.Orange;
            CTRL_Button_Login.BorderRadius = 15;
            CTRL_Button_Login.CustomizableEdges = customizableEdges5;
            CTRL_Button_Login.DisabledState.BorderColor = Color.DarkGray;
            CTRL_Button_Login.DisabledState.CustomBorderColor = Color.DarkGray;
            CTRL_Button_Login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CTRL_Button_Login.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            CTRL_Button_Login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CTRL_Button_Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CTRL_Button_Login.ForeColor = Color.White;
            CTRL_Button_Login.Location = new Point(120, 419);
            CTRL_Button_Login.Margin = new Padding(3, 4, 3, 4);
            CTRL_Button_Login.Name = "Button_LOGIN";
            CTRL_Button_Login.ShadowDecoration.CustomizableEdges = customizableEdges6;
            CTRL_Button_Login.Size = new Size(180, 56);
            CTRL_Button_Login.TabIndex = 4;
            CTRL_Button_Login.Text = "LOGIN";
            CTRL_Button_Login.Click += Button_LOGIN_Click;
            // 
            // Button_LOGIN_DEMO
            // 
            Button_LOGIN_DEMO.BackgroundImage = (Image)resources.GetObject("Button_LOGIN_DEMO.BackgroundImage");
            Button_LOGIN_DEMO.BackgroundImageLayout = ImageLayout.Zoom;
            Button_LOGIN_DEMO.DisabledState.BorderColor = Color.DarkGray;
            Button_LOGIN_DEMO.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_LOGIN_DEMO.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_LOGIN_DEMO.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_LOGIN_DEMO.FillColor = Color.Transparent;
            Button_LOGIN_DEMO.Font = new Font("Segoe UI", 9F);
            Button_LOGIN_DEMO.ForeColor = Color.Black;
            Button_LOGIN_DEMO.Location = new Point(30, 169);
            Button_LOGIN_DEMO.Margin = new Padding(3, 4, 3, 4);
            Button_LOGIN_DEMO.Name = "Button_LOGIN_DEMO";
            Button_LOGIN_DEMO.ShadowDecoration.CustomizableEdges = customizableEdges7;
            Button_LOGIN_DEMO.ShadowDecoration.Mode = ShadowMode.Circle;
            Button_LOGIN_DEMO.Size = new Size(31, 35);
            Button_LOGIN_DEMO.TabIndex = 9;
            // 
            // Container_LOGIN_FORM
            // 
            Container_LOGIN_FORM.BackColor = Color.White;
            Container_LOGIN_FORM.BackgroundImageLayout = ImageLayout.Stretch;
            Container_LOGIN_FORM.BorderColor = Color.BlanchedAlmond;
            Container_LOGIN_FORM.BorderRadius = 25;
            Container_LOGIN_FORM.Controls.Add(UI_Elements_2);
            Container_LOGIN_FORM.Controls.Add(Button_LOGIN_DEMO);
            Container_LOGIN_FORM.Controls.Add(CRL_Label_HEADING_2);
            Container_LOGIN_FORM.Controls.Add(Label__Login);
            Container_LOGIN_FORM.Controls.Add(Label__HEADING_1);
            Container_LOGIN_FORM.Controls.Add(CTRL_Button_Login);
            Container_LOGIN_FORM.Controls.Add(CTRL_TextBox_Enter_Password);
            Container_LOGIN_FORM.Controls.Add(CTRL_TextBox_Enter_Username);
            Container_LOGIN_FORM.Controls.Add(UI_Elements_1);
            Container_LOGIN_FORM.CustomBorderColor = Color.Transparent;
            Container_LOGIN_FORM.CustomizableEdges = customizableEdges11;
            Container_LOGIN_FORM.FillColor = Color.Transparent;
            Container_LOGIN_FORM.Location = new Point(12, 50);
            Container_LOGIN_FORM.Margin = new Padding(3, 4, 3, 4);
            Container_LOGIN_FORM.Name = "Container_LOGIN_FORM";
            Container_LOGIN_FORM.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Container_LOGIN_FORM.ShadowDecoration.Depth = 100;
            Container_LOGIN_FORM.Size = new Size(818, 575);
            Container_LOGIN_FORM.TabIndex = 4;
            Container_LOGIN_FORM.Text = "s";
            // 
            // UI_Elements_2
            // 
            UI_Elements_2.BackColor = Color.Transparent;
            UI_Elements_2.CustomizableEdges = customizableEdges8;
            UI_Elements_2.FillColor = Color.Transparent;
            UI_Elements_2.Image = (Image)resources.GetObject("UI_Elements_2.Image");
            UI_Elements_2.ImageRotate = 0F;
            UI_Elements_2.Location = new Point(458, 89);
            UI_Elements_2.Margin = new Padding(3, 4, 3, 4);
            UI_Elements_2.Name = "UI_Elements_2";
            UI_Elements_2.ShadowDecoration.CustomizableEdges = customizableEdges9;
            UI_Elements_2.Size = new Size(322, 426);
            UI_Elements_2.SizeMode = PictureBoxSizeMode.StretchImage;
            UI_Elements_2.TabIndex = 10;
            UI_Elements_2.TabStop = false;
            // 
            // Label__HEADING_2
            // 
            CRL_Label_HEADING_2.BackColor = Color.Transparent;
            CRL_Label_HEADING_2.Font = new Font("Verdana", 8F);
            CRL_Label_HEADING_2.Location = new Point(30, 89);
            CRL_Label_HEADING_2.Margin = new Padding(3, 4, 3, 4);
            CRL_Label_HEADING_2.Name = "Label__HEADING_2";
            CRL_Label_HEADING_2.Size = new Size(136, 18);
            CRL_Label_HEADING_2.TabIndex = 8;
            CRL_Label_HEADING_2.Text = "Welcome, Klasmeyt!";
            // 
            // Label__Login
            // 
            Label__Login.BackColor = Color.Transparent;
            Label__Login.Font = new Font("Verdana", 13.2F);
            Label__Login.Location = new Point(67, 169);
            Label__Login.Margin = new Padding(3, 4, 3, 4);
            Label__Login.Name = "Label__Login";
            Label__Login.Size = new Size(74, 28);
            Label__Login.TabIndex = 7;
            Label__Login.Text = "Log In";
            // 
            // Label__HEADING_1
            // 
            Label__HEADING_1.BackColor = Color.Transparent;
            Label__HEADING_1.Font = new Font("Verdana", 16F, FontStyle.Bold);
            Label__HEADING_1.ForeColor = Color.HotPink;
            Label__HEADING_1.Location = new Point(30, 39);
            Label__HEADING_1.Margin = new Padding(3, 4, 3, 4);
            Label__HEADING_1.Name = "Label__HEADING_1";
            Label__HEADING_1.Size = new Size(307, 34);
            Label__HEADING_1.TabIndex = 6;
            Label__HEADING_1.Text = "Adamson University";
            // 
            // UI_Elements_1
            // 
            UI_Elements_1.BackColor = Color.Transparent;
            UI_Elements_1.BackgroundImageLayout = ImageLayout.Zoom;
            UI_Elements_1.BorderColor = Color.Transparent;
            UI_Elements_1.BorderThickness = 0;
            UI_Elements_1.FillColor = Color.PowderBlue;
            UI_Elements_1.Location = new Point(422, 0);
            UI_Elements_1.Margin = new Padding(3, 4, 3, 4);
            UI_Elements_1.Name = "UI_Elements_1";
            UI_Elements_1.PolygonSkip = 1;
            UI_Elements_1.Rotate = 0F;
            UI_Elements_1.RoundedEdges = customizableEdges10;
            UI_Elements_1.RoundedRadius = 25;
            UI_Elements_1.Shape = ShapeType.Rectangle;
            UI_Elements_1.Size = new Size(396, 575);
            UI_Elements_1.TabIndex = 5;
            UI_Elements_1.Zoom = 100;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(842, 640);
            Controls.Add(Container_LOGIN_FORM);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            RightToLeft = RightToLeft.Yes;
            Text = "Log In to Falcon Shop";
            Shown += Trigger_Shown;
            Container_LOGIN_FORM.ResumeLayout(false);
            Container_LOGIN_FORM.PerformLayout();
            ((ISupportInitialize)UI_Elements_2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna2TextBox CTRL_TextBox_Enter_Username;
        private Guna2TextBox CTRL_TextBox_Enter_Password;
        private Guna2GradientButton CTRL_Button_Login;
        private Guna2CircleButton Button_LOGIN_DEMO;
        private Guna2ContainerControl Container_LOGIN_FORM;
        private Guna2HtmlLabel CRL_Label_HEADING_2;
        private Guna2HtmlLabel Label__Login;
        private Guna2HtmlLabel Label__HEADING_1;
        private Guna2Shapes UI_Elements_1;
        private Guna2PictureBox UI_Elements_2;
    }
}

