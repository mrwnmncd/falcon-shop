namespace App.GUI
{
    partial class StudentHome
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
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_LogOut;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_GreetUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_UserID;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_FullName;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_Email;
        private Guna.UI2.WinForms.Guna2Button Button_ShopItems;
        private Guna.UI2.WinForms.Guna2Button Button_MyCart;
        private Guna.UI2.WinForms.Guna2Button Button_MyOrders;
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Label_UserID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Label_FullName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Label_Email = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Button_ShopItems = new Guna.UI2.WinForms.Guna2Button();
            Button_MyCart = new Guna.UI2.WinForms.Guna2Button();
            Button_MyOrders = new Guna.UI2.WinForms.Guna2Button();
            Label_LogOut = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Label_GreetUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // Label_UserID
            // 
            Label_UserID.AutoSize = false;
            Label_UserID.BackColor = Color.Transparent;
            Label_UserID.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_UserID.ForeColor = Color.FromArgb(35, 69, 127);
            Label_UserID.Location = new Point(718, 87);
            Label_UserID.Name = "Label_UserID";
            Label_UserID.Size = new Size(371, 20);
            Label_UserID.TabIndex = 1;
            Label_UserID.Text = "@kalixjace (202310614)";
            Label_UserID.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // Label_FullName
            // 
            Label_FullName.AutoSize = false;
            Label_FullName.BackColor = Color.Transparent;
            Label_FullName.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_FullName.ForeColor = Color.FromArgb(35, 69, 127);
            Label_FullName.Location = new Point(718, 106);
            Label_FullName.Name = "Label_FullName";
            Label_FullName.Size = new Size(371, 31);
            Label_FullName.TabIndex = 2;
            Label_FullName.Text = "Kalix Jace A. Martinez";
            // 
            // Label_Email
            // 
            Label_Email.AutoSize = false;
            Label_Email.BackColor = Color.Transparent;
            Label_Email.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Email.ForeColor = Color.FromArgb(35, 69, 127);
            Label_Email.Location = new Point(718, 140);
            Label_Email.Name = "Label_Email";
            Label_Email.Size = new Size(371, 20);
            Label_Email.TabIndex = 4;
            Label_Email.Text = "kalixjacemartinez@adamson.edu.ph";
            // 
            // Button_ShopItems
            // 
            Button_ShopItems.BackColor = Color.Transparent;
            Button_ShopItems.BorderRadius = 25;
            Button_ShopItems.CustomizableEdges = customizableEdges1;
            Button_ShopItems.DisabledState.BorderColor = Color.DarkGray;
            Button_ShopItems.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_ShopItems.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_ShopItems.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_ShopItems.FillColor = Color.FromArgb(35, 69, 127);
            Button_ShopItems.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            Button_ShopItems.ForeColor = Color.White;
            Button_ShopItems.Location = new Point(718, 208);
            Button_ShopItems.Name = "Button_ShopItems";
            Button_ShopItems.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Button_ShopItems.Size = new Size(371, 88);
            Button_ShopItems.TabIndex = 5;
            Button_ShopItems.Text = "SHOP ITEMS";
            Button_ShopItems.Click += Button_Shop_Click;
            // 
            // Button_MyCart
            // 
            Button_MyCart.BackColor = Color.Transparent;
            Button_MyCart.BorderRadius = 25;
            Button_MyCart.CustomizableEdges = customizableEdges3;
            Button_MyCart.DisabledState.BorderColor = Color.DarkGray;
            Button_MyCart.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_MyCart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_MyCart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_MyCart.FillColor = Color.FromArgb(35, 69, 127);
            Button_MyCart.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            Button_MyCart.ForeColor = Color.White;
            Button_MyCart.Location = new Point(718, 311);
            Button_MyCart.Name = "Button_MyCart";
            Button_MyCart.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_MyCart.Size = new Size(371, 88);
            Button_MyCart.TabIndex = 6;
            Button_MyCart.Text = "MY CART";
            Button_MyCart.Click += Button_Checkout_Click;
            // 
            // Button_MyOrders
            // 
            Button_MyOrders.BackColor = Color.Transparent;
            Button_MyOrders.BorderRadius = 25;
            Button_MyOrders.CustomizableEdges = customizableEdges5;
            Button_MyOrders.DisabledState.BorderColor = Color.DarkGray;
            Button_MyOrders.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_MyOrders.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_MyOrders.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_MyOrders.FillColor = Color.FromArgb(35, 69, 127);
            Button_MyOrders.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            Button_MyOrders.ForeColor = Color.White;
            Button_MyOrders.Location = new Point(718, 414);
            Button_MyOrders.Name = "Button_MyOrders";
            Button_MyOrders.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Button_MyOrders.Size = new Size(371, 88);
            Button_MyOrders.TabIndex = 7;
            Button_MyOrders.Text = "MY ORDERS";
            Button_MyOrders.Click += Button_Orders_Click;
            // 
            // Label_LogOut
            // 
            Label_LogOut.AutoSize = false;
            Label_LogOut.BackColor = Color.Transparent;
            Label_LogOut.BackgroundImage = Properties.Resources._31;
            Label_LogOut.BackgroundImageLayout = ImageLayout.Stretch;
            Label_LogOut.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            Label_LogOut.ForeColor = Color.FromArgb(29, 73, 167);
            Label_LogOut.Location = new Point(1070, 563);
            Label_LogOut.Name = "Label_LogOut";
            Label_LogOut.Size = new Size(30, 30);
            Label_LogOut.TabIndex = 8;
            Label_LogOut.Text = null;
            Label_LogOut.Click += Label_Log_Out_Click;
            // 
            // Label_GreetUser
            // 
            Label_GreetUser.AutoSize = false;
            Label_GreetUser.BackColor = Color.Transparent;
            Label_GreetUser.BackgroundImageLayout = ImageLayout.Stretch;
            Label_GreetUser.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            Label_GreetUser.ForeColor = Color.FromArgb(35, 69, 127);
            Label_GreetUser.Location = new Point(625, 35);
            Label_GreetUser.Name = "Label_GreetUser";
            Label_GreetUser.Size = new Size(380, 40);
            Label_GreetUser.TabIndex = 9;
            Label_GreetUser.Text = "Welcome, Kalix Jace!";
            // 
            // StudentHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Student_Home_cs;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1162, 653);
            Controls.Add(Label_GreetUser);
            Controls.Add(Label_LogOut);
            Controls.Add(Button_MyOrders);
            Controls.Add(Button_MyCart);
            Controls.Add(Button_ShopItems);
            Controls.Add(Label_Email);
            Controls.Add(Label_FullName);
            Controls.Add(Label_UserID);
            DoubleBuffered = true;
            Name = "StudentHome";
            Text = "Student_Home";
            FormClosing += EventTrigger_FormClosing;
            FormClosed += EventTrigger_FormClosed;
            Load += EventTrigger_Load;
            Shown += EventTrigger_Shown;
            ResumeLayout(false);
        }

        #endregion

    }
}