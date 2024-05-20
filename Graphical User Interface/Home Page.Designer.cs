namespace App.GUI
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            button_Products = new Button();
            button_Cart = new Button();
            button_Checkout = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label_FirstName = new Label();
            panel_User_Information = new Panel();
            label_Email = new Label();
            label_ID_Number = new Label();
            label_FullName = new Label();
            label_Username = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel_User_Information.SuspendLayout();
            SuspendLayout();
            // 
            // button_Products
            // 
            button_Products.BackColor = Color.FromArgb(0, 74, 173);
            button_Products.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Products.ForeColor = Color.White;
            button_Products.Location = new Point(474, 207);
            button_Products.Margin = new Padding(2);
            button_Products.Name = "button_Products";
            button_Products.Size = new Size(378, 81);
            button_Products.TabIndex = 1;
            button_Products.Text = "Shop Products";
            button_Products.UseVisualStyleBackColor = false;
            button_Products.Click += button_Products_Click;
            // 
            // button_Cart
            // 
            button_Cart.BackColor = Color.FromArgb(0, 74, 173);
            button_Cart.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Cart.ForeColor = Color.White;
            button_Cart.Location = new Point(474, 293);
            button_Cart.Margin = new Padding(2);
            button_Cart.Name = "button_Cart";
            button_Cart.Size = new Size(378, 81);
            button_Cart.TabIndex = 2;
            button_Cart.Text = "Cart";
            button_Cart.UseVisualStyleBackColor = false;
            button_Cart.Click += button_Cart_Click;
            // 
            // button_Checkout
            // 
            button_Checkout.BackColor = Color.FromArgb(0, 74, 173);
            button_Checkout.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Checkout.ForeColor = Color.White;
            button_Checkout.Location = new Point(474, 386);
            button_Checkout.Margin = new Padding(2);
            button_Checkout.Name = "button_Checkout";
            button_Checkout.Size = new Size(378, 81);
            button_Checkout.TabIndex = 3;
            button_Checkout.Text = "Checkout";
            button_Checkout.UseVisualStyleBackColor = false;
            button_Checkout.Click += button_Checkout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(496, 218);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 61);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(496, 299);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 66);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(496, 396);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 61);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label_FirstName
            // 
            label_FirstName.AutoSize = true;
            label_FirstName.BackColor = Color.Transparent;
            label_FirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_FirstName.ForeColor = Color.FromArgb(21, 70, 131);
            label_FirstName.Location = new Point(583, 40);
            label_FirstName.Margin = new Padding(2, 0, 2, 0);
            label_FirstName.Name = "label_FirstName";
            label_FirstName.Size = new Size(60, 25);
            label_FirstName.TabIndex = 8;
            label_FirstName.Text = "Kalix";
            // 
            // panel_User_Information
            // 
            panel_User_Information.BackColor = Color.Transparent;
            panel_User_Information.Controls.Add(label_Email);
            panel_User_Information.Controls.Add(label_ID_Number);
            panel_User_Information.Controls.Add(label_FullName);
            panel_User_Information.Controls.Add(label_Username);
            panel_User_Information.Font = new Font("Microsoft Sans Serif", 8.25F);
            panel_User_Information.Location = new Point(563, 90);
            panel_User_Information.Margin = new Padding(2);
            panel_User_Information.Name = "panel_User_Information";
            panel_User_Information.Size = new Size(248, 79);
            panel_User_Information.TabIndex = 9;
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.BackColor = Color.Transparent;
            label_Email.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Email.ForeColor = Color.FromArgb(21, 70, 131);
            label_Email.Location = new Point(2, 58);
            label_Email.Margin = new Padding(2, 0, 2, 0);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(172, 13);
            label_Email.TabIndex = 12;
            label_Email.Text = "kalixjacemartinez@icloud.com";
            // 
            // label_ID_Number
            // 
            label_ID_Number.AutoSize = true;
            label_ID_Number.BackColor = Color.Transparent;
            label_ID_Number.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ID_Number.ForeColor = Color.FromArgb(21, 70, 131);
            label_ID_Number.Location = new Point(2, 43);
            label_ID_Number.Margin = new Padding(2, 0, 2, 0);
            label_ID_Number.Name = "label_ID_Number";
            label_ID_Number.Size = new Size(89, 17);
            label_ID_Number.TabIndex = 11;
            label_ID_Number.Text = "210854671";
            // 
            // label_FullName
            // 
            label_FullName.AutoSize = true;
            label_FullName.BackColor = Color.Transparent;
            label_FullName.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_FullName.ForeColor = Color.FromArgb(35, 69, 127);
            label_FullName.Location = new Point(2, 22);
            label_FullName.Margin = new Padding(2, 0, 2, 0);
            label_FullName.Name = "label_FullName";
            label_FullName.Size = new Size(190, 24);
            label_FullName.TabIndex = 10;
            label_FullName.Text = "Kalix Jace Martinez";
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.BackColor = Color.Transparent;
            label_Username.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Username.ForeColor = Color.FromArgb(21, 70, 131);
            label_Username.Location = new Point(2, 7);
            label_Username.Margin = new Padding(2, 0, 2, 0);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(32, 17);
            label_Username.TabIndex = 9;
            label_Username.Text = "kjm";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(906, 575);
            Controls.Add(panel_User_Information);
            Controls.Add(label_FirstName);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button_Checkout);
            Controls.Add(button_Cart);
            Controls.Add(button_Products);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "Home";
            Text = "Home";
            FormClosing += Home_FormClosing;
            Shown += Trigger_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel_User_Information.ResumeLayout(false);
            panel_User_Information.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_Products;
        private Button button_Cart;
        private Button button_Checkout;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label_FirstName;
        private Panel panel_User_Information;
        private Label label_FullName;
        private Label label_Username;
        private Label label_Email;
        private Label label_ID_Number;
    }
}
