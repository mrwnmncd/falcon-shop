namespace App.GUI
{
    partial class Checkout
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ListBox_Enumerate_CartItems = new ListBox();
            Button_SubmitOrder = new Guna.UI2.WinForms.Guna2Button();
            Button_ClearCart = new Guna.UI2.WinForms.Guna2Button();
            Button_ClearItem = new Guna.UI2.WinForms.Guna2Button();
            Label_Cart_Count = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Label_Subtotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Label_ProgramMessage = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // ListBox_Enumerate_CartItems
            // 
            ListBox_Enumerate_CartItems.ColumnWidth = 4;
            ListBox_Enumerate_CartItems.FormattingEnabled = true;
            ListBox_Enumerate_CartItems.Location = new Point(599, 165);
            ListBox_Enumerate_CartItems.Name = "ListBox_Enumerate_CartItems";
            ListBox_Enumerate_CartItems.SelectionMode = SelectionMode.MultiSimple;
            ListBox_Enumerate_CartItems.Size = new Size(371, 344);
            ListBox_Enumerate_CartItems.TabIndex = 0;
            // 
            // Button_SubmitOrder
            // 
            Button_SubmitOrder.BorderRadius = 25;
            Button_SubmitOrder.CustomizableEdges = customizableEdges1;
            Button_SubmitOrder.DisabledState.BorderColor = Color.DarkGray;
            Button_SubmitOrder.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_SubmitOrder.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_SubmitOrder.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_SubmitOrder.FillColor = Color.FromArgb(29, 73, 167);
            Button_SubmitOrder.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            Button_SubmitOrder.ForeColor = Color.White;
            Button_SubmitOrder.Location = new Point(976, 461);
            Button_SubmitOrder.Name = "Button_SubmitOrder";
            Button_SubmitOrder.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Button_SubmitOrder.Size = new Size(180, 48);
            Button_SubmitOrder.TabIndex = 3;
            Button_SubmitOrder.Text = "SUBMIT ORDER";
            Button_SubmitOrder.Click += Button_SubmitOrder_Click;
            // 
            // Button_ClearCart
            // 
            Button_ClearCart.BorderRadius = 15;
            Button_ClearCart.CustomizableEdges = customizableEdges3;
            Button_ClearCart.DisabledState.BorderColor = Color.DarkGray;
            Button_ClearCart.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_ClearCart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_ClearCart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_ClearCart.FillColor = Color.FromArgb(221, 94, 86);
            Button_ClearCart.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            Button_ClearCart.ForeColor = Color.White;
            Button_ClearCart.Location = new Point(976, 231);
            Button_ClearCart.Name = "Button_ClearCart";
            Button_ClearCart.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_ClearCart.Size = new Size(180, 33);
            Button_ClearCart.TabIndex = 4;
            Button_ClearCart.Text = "CLEAR CART";
            Button_ClearCart.Click += Button_CancelOrder_Click;
            // 
            // Button_ClearItem
            // 
            Button_ClearItem.BorderRadius = 15;
            Button_ClearItem.CustomizableEdges = customizableEdges5;
            Button_ClearItem.DisabledState.BorderColor = Color.DarkGray;
            Button_ClearItem.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_ClearItem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_ClearItem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_ClearItem.FillColor = Color.FromArgb(221, 94, 86);
            Button_ClearItem.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            Button_ClearItem.ForeColor = Color.White;
            Button_ClearItem.Location = new Point(976, 192);
            Button_ClearItem.Name = "Button_ClearItem";
            Button_ClearItem.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Button_ClearItem.Size = new Size(180, 33);
            Button_ClearItem.TabIndex = 5;
            Button_ClearItem.Text = "CLEAR ITEM";
            Button_ClearItem.Click += Button_ClearItems_Click;
            // 
            // Label_Cart_Count
            // 
            Label_Cart_Count.BackColor = Color.Transparent;
            Label_Cart_Count.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            Label_Cart_Count.ForeColor = Color.FromArgb(29, 73, 167);
            Label_Cart_Count.Location = new Point(1090, 340);
            Label_Cart_Count.Name = "Label_Cart_Count";
            Label_Cart_Count.Size = new Size(13, 22);
            Label_Cart_Count.TabIndex = 6;
            Label_Cart_Count.Text = "0";
            // 
            // Label_Subtotal
            // 
            Label_Subtotal.AutoSize = false;
            Label_Subtotal.BackColor = Color.Transparent;
            Label_Subtotal.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Subtotal.ForeColor = Color.FromArgb(29, 73, 167);
            Label_Subtotal.Location = new Point(1051, 381);
            Label_Subtotal.Margin = new Padding(0);
            Label_Subtotal.Name = "Label_Subtotal";
            Label_Subtotal.Size = new Size(102, 20);
            Label_Subtotal.TabIndex = 7;
            Label_Subtotal.Text = "PHP. 0.00";
            Label_Subtotal.TextAlignment = ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(29, 73, 167);
            guna2HtmlLabel1.Location = new Point(766, 586);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 8;
            guna2HtmlLabel1.Text = null;
            // 
            // Label_ProgramMessage
            // 
            Label_ProgramMessage.AutoSize = true;
            Label_ProgramMessage.BackColor = Color.Transparent;
            Label_ProgramMessage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_ProgramMessage.Location = new Point(835, 577);
            Label_ProgramMessage.Name = "Label_ProgramMessage";
            Label_ProgramMessage.Size = new Size(0, 25);
            Label_ProgramMessage.TabIndex = 9;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 25;
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(29, 73, 167);
            guna2Button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(100, 512);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new Size(339, 57);
            guna2Button1.TabIndex = 10;
            guna2Button1.Text = "HOME";
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Checkout_cs;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1162, 653);
            Controls.Add(guna2Button1);
            Controls.Add(Label_ProgramMessage);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(Label_Subtotal);
            Controls.Add(Label_Cart_Count);
            Controls.Add(Button_ClearItem);
            Controls.Add(Button_ClearCart);
            Controls.Add(Button_SubmitOrder);
            Controls.Add(ListBox_Enumerate_CartItems);
            DoubleBuffered = true;
            Name = "Checkout";
            Text = "Check Out";
            FormClosing += Closing;
            Shown += Trigger_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBox_Enumerate_CartItems;
        private Guna.UI2.WinForms.Guna2Button Button_SubmitOrder;
        private Guna.UI2.WinForms.Guna2Button Button_ClearCart;
        private Guna.UI2.WinForms.Guna2Button Button_ClearItem;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_Cart_Count;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_Subtotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label Label_ProgramMessage;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}