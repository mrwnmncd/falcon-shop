namespace App.GUI
{
    partial class Products
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            ComboBox_Select_Product = new Guna.UI2.WinForms.Guna2ComboBox();
            ListBox_Select_Variant = new ListBox();
            button1 = new Button();
            PictureBox_Product = new PictureBox();
            Label_Price = new Label();
            label2 = new Label();
            TextBox_Enter_Quantity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Product).BeginInit();
            SuspendLayout();
            // 
            // ComboBox_Select_Product
            // 
            ComboBox_Select_Product.BackColor = Color.Transparent;
            ComboBox_Select_Product.BorderRadius = 3;
            ComboBox_Select_Product.CustomizableEdges = customizableEdges3;
            ComboBox_Select_Product.DrawMode = DrawMode.OwnerDrawFixed;
            ComboBox_Select_Product.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Select_Product.FillColor = Color.FromArgb(93, 120, 162);
            ComboBox_Select_Product.FocusedColor = Color.FromArgb(94, 148, 255);
            ComboBox_Select_Product.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ComboBox_Select_Product.Font = new Font("Microsoft Sans Serif", 10F);
            ComboBox_Select_Product.ForeColor = Color.FromArgb(68, 88, 112);
            ComboBox_Select_Product.ItemHeight = 30;
            ComboBox_Select_Product.Items.AddRange(new object[] { "UNIFORM", "PE", "NSTP", "LANYARD" });
            ComboBox_Select_Product.Location = new Point(602, 167);
            ComboBox_Select_Product.Name = "ComboBox_Select_Product";
            ComboBox_Select_Product.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ComboBox_Select_Product.Size = new Size(257, 36);
            ComboBox_Select_Product.TabIndex = 0;
            // 
            // ListBox_Select_Variant
            // 
            ListBox_Select_Variant.BackColor = Color.FromArgb(93, 120, 162);
            ListBox_Select_Variant.Font = new Font("Microsoft Sans Serif", 10F);
            ListBox_Select_Variant.FormattingEnabled = true;
            ListBox_Select_Variant.Items.AddRange(new object[] { "Male Polo - Extra Small", "Male Polo - Small", "Male Polo - Medium", "Male Polo - Large", "Male Polo - Extra Large", "Male Polo - Double Extra Large", "Female Blouse - Extra Small", "Female Blouse - Small", "Female Blouse - Medium", "Female Blouse - Large", "Female Blouse - Extra Large", "Female Blouse - Double Extra Large", "Male Slacks - Extra Small", "Male Slacks - Small", "Male Slacks - Medium", "Male Slacks - Large", "Male Slacks - Extra Large", "Male Slacks - Double Extra Large", "Female Skirt - Extra Small", "Female Skirt - Small", "Female Skirt - Medium", "Female Skirt - Large", "Female Skirt - Extra Large", "Female Skirt - Double Extra Large", "Unisex PE Shirt - Extra Small", "Unisex PE Shirt - Small", "Unisex PE Shirt - Medium", "Unisex PE Shirt - Large", "Unisex PE Shirt - Extra Large", "Unisex PE Shirt - Double Extra Large", "Unisex Jogging Pants - Extra Small", "Unisex Jogging Pants - Small", "Unisex Jogging Pants - Medium", "Unisex Jogging Pants - Large", "Unisex Jogging Pants - Extra Large", "Unisex Jogging Pants - Double Extra Large", "Unisex NSTP Shirt - Extra Small", "Unisex NSTP Shirt - Small", "Unisex NSTP Shirt - Medium", "Unisex NSTP Shirt - Large", "Unisex NSTP Shirt - Extra Large", "Unisex NSTP Shirt - Double Extra Large", "College of Architecture", "College of Business Administration", "College of Engineering", "College of Law", "College of Education and Liberal Arts", "College of Nursing", "College of Pharmacy", "College of Science", "Graduate School", "St. Vincent School of Theology", "Basic Education Department" });
            ListBox_Select_Variant.Location = new Point(870, 167);
            ListBox_Select_Variant.Name = "ListBox_Select_Variant";
            ListBox_Select_Variant.Size = new Size(256, 292);
            ListBox_Select_Variant.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(886, 528);
            button1.Name = "button1";
            button1.Size = new Size(227, 55);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // PictureBox_Product
            // 
            PictureBox_Product.BackgroundImage = (Image)resources.GetObject("PictureBox_Product.BackgroundImage");
            PictureBox_Product.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox_Product.Location = new Point(602, 214);
            PictureBox_Product.Name = "PictureBox_Product";
            PictureBox_Product.Size = new Size(257, 296);
            PictureBox_Product.TabIndex = 3;
            PictureBox_Product.TabStop = false;
            // 
            // Label_Price
            // 
            Label_Price.AutoSize = true;
            Label_Price.BackColor = Color.Transparent;
            Label_Price.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Price.Location = new Point(690, 547);
            Label_Price.Name = "Label_Price";
            Label_Price.Size = new Size(84, 20);
            Label_Price.TabIndex = 4;
            Label_Price.Text = "PHP 0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(830, 620);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "ERROR";
            // 
            // TextBox_Enter_Quantity
            // 
            TextBox_Enter_Quantity.Font = new Font("Microsoft Sans Serif", 14F);
            TextBox_Enter_Quantity.Location = new Point(1038, 476);
            TextBox_Enter_Quantity.Name = "TextBox_Enter_Quantity";
            TextBox_Enter_Quantity.Size = new Size(88, 29);
            TextBox_Enter_Quantity.TabIndex = 6;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1164, 661);
            Controls.Add(TextBox_Enter_Quantity);
            Controls.Add(label2);
            Controls.Add(Label_Price);
            Controls.Add(PictureBox_Product);
            Controls.Add(button1);
            Controls.Add(ListBox_Select_Variant);
            Controls.Add(ComboBox_Select_Product);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "Products";
            Text = "Shop Items";
            FormClosing += Closing;
            ((System.ComponentModel.ISupportInitialize)PictureBox_Product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Select_Product;
        private ListBox ListBox_Select_Variant;
        private Button button1;
        private PictureBox PictureBox_Product;
        private Label Label_Price;
        private Label label2;
        private TextBox TextBox_Enter_Quantity;
    }
}

