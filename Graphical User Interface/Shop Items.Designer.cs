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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ComboBox_SelectProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            ListBox_SelectVariant = new ListBox();
            PictureBox_Product = new PictureBox();
            Label_Price = new Label();
            Label_ProgramMessage = new Label();
            TextBox_Quantity = new TextBox();
            Button_LogIn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Product).BeginInit();
            SuspendLayout();
            // 
            // ComboBox_SelectProduct
            // 
            ComboBox_SelectProduct.BackColor = Color.Transparent;
            ComboBox_SelectProduct.BorderRadius = 3;
            ComboBox_SelectProduct.CustomizableEdges = customizableEdges17;
            ComboBox_SelectProduct.DrawMode = DrawMode.OwnerDrawFixed;
            ComboBox_SelectProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_SelectProduct.FocusedColor = Color.FromArgb(94, 148, 255);
            ComboBox_SelectProduct.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ComboBox_SelectProduct.Font = new Font("Microsoft Sans Serif", 10F);
            ComboBox_SelectProduct.ForeColor = Color.FromArgb(68, 88, 112);
            ComboBox_SelectProduct.ItemHeight = 30;
            ComboBox_SelectProduct.Items.AddRange(new object[] { "UNIFORM", "PE", "NSTP", "LANYARD" });
            ComboBox_SelectProduct.Location = new Point(688, 223);
            ComboBox_SelectProduct.Margin = new Padding(3, 4, 3, 4);
            ComboBox_SelectProduct.Name = "ComboBox_SelectProduct";
            ComboBox_SelectProduct.ShadowDecoration.CustomizableEdges = customizableEdges18;
            ComboBox_SelectProduct.Size = new Size(293, 36);
            ComboBox_SelectProduct.TabIndex = 0;
            ComboBox_SelectProduct.SelectedIndexChanged += ComboBox_Select_Product_SelectedIndexChanged;
            // 
            // ListBox_SelectVariant
            // 
            ListBox_SelectVariant.BackColor = Color.White;
            ListBox_SelectVariant.Font = new Font("Microsoft Sans Serif", 10F);
            ListBox_SelectVariant.FormattingEnabled = true;
            ListBox_SelectVariant.Location = new Point(994, 223);
            ListBox_SelectVariant.Margin = new Padding(3, 4, 3, 4);
            ListBox_SelectVariant.Name = "ListBox_SelectVariant";
            ListBox_SelectVariant.Size = new Size(292, 384);
            ListBox_SelectVariant.TabIndex = 1;
            ListBox_SelectVariant.SelectedIndexChanged += ListBox_Select_Variant_SelectedIndexChanged;
            // 
            // PictureBox_Product
            // 
            PictureBox_Product.BackgroundImage = Properties.Resources.LANYARD;
            PictureBox_Product.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox_Product.Location = new Point(688, 285);
            PictureBox_Product.Margin = new Padding(3, 4, 3, 4);
            PictureBox_Product.Name = "PictureBox_Product";
            PictureBox_Product.Size = new Size(294, 395);
            PictureBox_Product.TabIndex = 3;
            PictureBox_Product.TabStop = false;
            // 
            // Label_Price
            // 
            Label_Price.AutoSize = true;
            Label_Price.BackColor = Color.Transparent;
            Label_Price.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Price.Location = new Point(789, 729);
            Label_Price.Name = "Label_Price";
            Label_Price.Size = new Size(103, 25);
            Label_Price.TabIndex = 4;
            Label_Price.Text = "PHP 0.00";
            // 
            // Label_ProgramMessage
            // 
            Label_ProgramMessage.AutoSize = true;
            Label_ProgramMessage.BackColor = Color.Transparent;
            Label_ProgramMessage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_ProgramMessage.Location = new Point(949, 827);
            Label_ProgramMessage.Name = "Label_ProgramMessage";
            Label_ProgramMessage.Size = new Size(0, 25);
            Label_ProgramMessage.TabIndex = 5;
            // 
            // TextBox_Quantity
            // 
            TextBox_Quantity.Font = new Font("Microsoft Sans Serif", 14F);
            TextBox_Quantity.Location = new Point(1186, 635);
            TextBox_Quantity.Margin = new Padding(3, 4, 3, 4);
            TextBox_Quantity.Name = "TextBox_Quantity";
            TextBox_Quantity.Size = new Size(100, 34);
            TextBox_Quantity.TabIndex = 6;
            TextBox_Quantity.Text = "1";
            TextBox_Quantity.TextAlign = HorizontalAlignment.Center;
            // 
            // Button_LogIn
            // 
            Button_LogIn.BorderRadius = 25;
            Button_LogIn.CustomizableEdges = customizableEdges19;
            Button_LogIn.DisabledState.BorderColor = Color.DarkGray;
            Button_LogIn.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_LogIn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_LogIn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_LogIn.FillColor = Color.FromArgb(29, 73, 167);
            Button_LogIn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            Button_LogIn.ForeColor = Color.White;
            Button_LogIn.Location = new Point(1013, 713);
            Button_LogIn.Name = "Button_LogIn";
            Button_LogIn.ShadowDecoration.CustomizableEdges = customizableEdges20;
            Button_LogIn.Size = new Size(261, 56);
            Button_LogIn.TabIndex = 7;
            Button_LogIn.Text = "ADD TO CART";
            Button_LogIn.Click += AddToCart;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Shop1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1330, 881);
            Controls.Add(Button_LogIn);
            Controls.Add(TextBox_Quantity);
            Controls.Add(Label_ProgramMessage);
            Controls.Add(Label_Price);
            Controls.Add(PictureBox_Product);
            Controls.Add(ListBox_SelectVariant);
            Controls.Add(ComboBox_SelectProduct);
            DoubleBuffered = true;
            Margin = new Padding(5);
            Name = "Products";
            Text = "Shop Items";
            FormClosing += Closing;
            Shown += Trigger_Shown;
            ((System.ComponentModel.ISupportInitialize)PictureBox_Product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_SelectProduct;
        private ListBox ListBox_SelectVariant;
        private PictureBox PictureBox_Product;
        private Label Label_Price;
        private Label Label_ProgramMessage;
        private TextBox TextBox_Quantity;
        private Guna.UI2.WinForms.Guna2Button Button_LogIn;
    }
}

