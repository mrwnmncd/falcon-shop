namespace App.GUI
{
    partial class SignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            label1 = new Label();
            TextBox_GIVEN_NAME = new TextBox();
            TextBox_LAST_NAME = new TextBox();
            label2 = new Label();
            TextBox_STUDENT_NUMBER = new TextBox();
            label3 = new Label();
            TextBox_EMAIL = new TextBox();
            label4 = new Label();
            TextBox_CONFIRM_PASSWORD = new TextBox();
            label5 = new Label();
            TextBox_PASSWORD = new TextBox();
            label6 = new Label();
            Button_SIGN_UP = new Button();
            ComboBox_ROLE = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(21, 70, 131);
            label1.Location = new Point(624, 176);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 0;
            label1.Text = "GIVEN NAME";
            // 
            // TextBox_GIVEN_NAME
            // 
            TextBox_GIVEN_NAME.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_GIVEN_NAME.Location = new Point(624, 201);
            TextBox_GIVEN_NAME.Name = "TextBox_GIVEN_NAME";
            TextBox_GIVEN_NAME.PlaceholderText = "Input Given Name...";
            TextBox_GIVEN_NAME.Size = new Size(215, 32);
            TextBox_GIVEN_NAME.TabIndex = 1;
            // 
            // TextBox_LAST_NAME
            // 
            TextBox_LAST_NAME.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_LAST_NAME.Location = new Point(846, 201);
            TextBox_LAST_NAME.Name = "TextBox_LAST_NAME";
            TextBox_LAST_NAME.PlaceholderText = "Input Last Name...";
            TextBox_LAST_NAME.Size = new Size(250, 32);
            TextBox_LAST_NAME.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(21, 70, 131);
            label2.Location = new Point(846, 176);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 2;
            label2.Text = "LAST NAME";
            // 
            // TextBox_STUDENT_NUMBER
            // 
            TextBox_STUDENT_NUMBER.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_STUDENT_NUMBER.Location = new Point(626, 361);
            TextBox_STUDENT_NUMBER.Name = "TextBox_STUDENT_NUMBER";
            TextBox_STUDENT_NUMBER.PlaceholderText = "Input Student / ID Number...";
            TextBox_STUDENT_NUMBER.Size = new Size(316, 32);
            TextBox_STUDENT_NUMBER.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(21, 70, 131);
            label3.Location = new Point(626, 336);
            label3.Name = "label3";
            label3.Size = new Size(186, 21);
            label3.TabIndex = 6;
            label3.Text = "STUDENT / ID NUMBER";
            // 
            // TextBox_EMAIL
            // 
            TextBox_EMAIL.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_EMAIL.Location = new Point(625, 281);
            TextBox_EMAIL.Name = "TextBox_EMAIL";
            TextBox_EMAIL.PlaceholderText = "Use Only Adamson Email...";
            TextBox_EMAIL.Size = new Size(316, 32);
            TextBox_EMAIL.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(21, 70, 131);
            label4.Location = new Point(625, 256);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 4;
            label4.Text = "EMAIL";
            // 
            // TextBox_CONFIRM_PASSWORD
            // 
            TextBox_CONFIRM_PASSWORD.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_CONFIRM_PASSWORD.Location = new Point(626, 530);
            TextBox_CONFIRM_PASSWORD.Name = "TextBox_CONFIRM_PASSWORD";
            TextBox_CONFIRM_PASSWORD.PasswordChar = '•';
            TextBox_CONFIRM_PASSWORD.PlaceholderText = "Input Last Name...";
            TextBox_CONFIRM_PASSWORD.Size = new Size(319, 32);
            TextBox_CONFIRM_PASSWORD.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(21, 70, 131);
            label5.Location = new Point(626, 505);
            label5.Name = "label5";
            label5.Size = new Size(185, 21);
            label5.TabIndex = 10;
            label5.Text = "CONFIRM PASSWORD";
            // 
            // TextBox_PASSWORD
            // 
            TextBox_PASSWORD.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_PASSWORD.Location = new Point(627, 446);
            TextBox_PASSWORD.Name = "TextBox_PASSWORD";
            TextBox_PASSWORD.PasswordChar = '•';
            TextBox_PASSWORD.PlaceholderText = "Input Given Name...";
            TextBox_PASSWORD.Size = new Size(317, 32);
            TextBox_PASSWORD.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(21, 70, 131);
            label6.Location = new Point(627, 421);
            label6.Name = "label6";
            label6.Size = new Size(102, 21);
            label6.TabIndex = 8;
            label6.Text = "PASSWORD";
            // 
            // Button_SIGN_UP
            // 
            Button_SIGN_UP.BackColor = Color.Transparent;
            Button_SIGN_UP.BackgroundImage = (Image)resources.GetObject("Button_SIGN_UP.BackgroundImage");
            Button_SIGN_UP.BackgroundImageLayout = ImageLayout.Stretch;
            Button_SIGN_UP.FlatAppearance.BorderSize = 0;
            Button_SIGN_UP.FlatStyle = FlatStyle.Flat;
            Button_SIGN_UP.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_SIGN_UP.ForeColor = Color.FromArgb(21, 70, 131);
            Button_SIGN_UP.Location = new Point(816, 593);
            Button_SIGN_UP.Name = "Button_SIGN_UP";
            Button_SIGN_UP.Size = new Size(128, 42);
            Button_SIGN_UP.TabIndex = 12;
            Button_SIGN_UP.Text = "SIGN UP";
            Button_SIGN_UP.UseVisualStyleBackColor = false;
            // 
            // ComboBox_ROLE
            // 
            ComboBox_ROLE.BackColor = Color.White;
            ComboBox_ROLE.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBox_ROLE.ForeColor = Color.Black;
            ComboBox_ROLE.FormattingEnabled = true;
            ComboBox_ROLE.Items.AddRange(new object[] { "ADMIN", "CASHIER", "STUDENT" });
            ComboBox_ROLE.Location = new Point(625, 130);
            ComboBox_ROLE.Name = "ComboBox_ROLE";
            ComboBox_ROLE.Size = new Size(213, 31);
            ComboBox_ROLE.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(21, 70, 131);
            label7.Location = new Point(623, 107);
            label7.Name = "label7";
            label7.Size = new Size(109, 21);
            label7.TabIndex = 14;
            label7.Text = "SELECT ROLE";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1161, 659);
            Controls.Add(label7);
            Controls.Add(ComboBox_ROLE);
            Controls.Add(Button_SIGN_UP);
            Controls.Add(TextBox_CONFIRM_PASSWORD);
            Controls.Add(label5);
            Controls.Add(TextBox_PASSWORD);
            Controls.Add(label6);
            Controls.Add(TextBox_STUDENT_NUMBER);
            Controls.Add(label3);
            Controls.Add(TextBox_EMAIL);
            Controls.Add(label4);
            Controls.Add(TextBox_LAST_NAME);
            Controls.Add(label2);
            Controls.Add(TextBox_GIVEN_NAME);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "SignUp";
            Text = "SIGN-UP WINDOW";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBox_GIVEN_NAME;
        private TextBox TextBox_LAST_NAME;
        private Label label2;
        private TextBox TextBox_STUDENT_NUMBER;
        private Label label3;
        private TextBox TextBox_EMAIL;
        private Label label4;
        private TextBox TextBox_CONFIRM_PASSWORD;
        private Label label5;
        private TextBox TextBox_PASSWORD;
        private Label label6;
        private Button Button_SIGN_UP;
        private ComboBox ComboBox_ROLE;
        private Label label7;
    }
}