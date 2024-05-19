namespace App.GUI
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            button1 = new Button();
            ListBox_Enumerate_Cart = new ListBox();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(760, 563);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(280, 37);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            // 
            // ListBox_Enumerate_Cart
            // 
            ListBox_Enumerate_Cart.BackColor = Color.FromArgb(21, 70, 131);
            ListBox_Enumerate_Cart.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            ListBox_Enumerate_Cart.ForeColor = Color.White;
            ListBox_Enumerate_Cart.FormattingEnabled = true;
            ListBox_Enumerate_Cart.Items.AddRange(new object[] { "item 1", "item 2" });
            ListBox_Enumerate_Cart.Location = new Point(132, 216);
            ListBox_Enumerate_Cart.Margin = new Padding(2);
            ListBox_Enumerate_Cart.Name = "ListBox_Enumerate_Cart";
            ListBox_Enumerate_Cart.Size = new Size(574, 324);
            ListBox_Enumerate_Cart.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.ForeColor = Color.DarkSlateBlue;
            textBox1.Location = new Point(762, 516);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "P";
            textBox1.Size = new Size(270, 32);
            textBox1.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            button2.ForeColor = Color.DarkSlateBlue;
            button2.Location = new Point(124, 559);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(594, 47);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = false;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1161, 659);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(ListBox_Enumerate_Cart);
            Controls.Add(button1);
            DoubleBuffered = true;
            ForeColor = Color.MidnightBlue;
            Margin = new Padding(2);
            Name = "Cart";
            Text = "Cart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ListBox ListBox_Enumerate_Cart;
        private Button button2;
        private TextBox textBox1;
    }
}
