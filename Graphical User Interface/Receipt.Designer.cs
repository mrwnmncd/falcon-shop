namespace App.GUI
{
    partial class Receipt
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
            Label_ReferenceNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Button_Confirm = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // Label_ReferenceNumber
            // 
            Label_ReferenceNumber.AutoSize = false;
            Label_ReferenceNumber.BackColor = Color.Transparent;
            Label_ReferenceNumber.BackgroundImageLayout = ImageLayout.Stretch;
            Label_ReferenceNumber.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold);
            Label_ReferenceNumber.ForeColor = Color.FromArgb(29, 73, 167);
            Label_ReferenceNumber.Location = new Point(339, 366);
            Label_ReferenceNumber.Margin = new Padding(0);
            Label_ReferenceNumber.Name = "Label_ReferenceNumber";
            Label_ReferenceNumber.Size = new Size(494, 48);
            Label_ReferenceNumber.TabIndex = 8;
            Label_ReferenceNumber.Text = "ADAMSON";
            Label_ReferenceNumber.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // Button_Confirm
            // 
            Button_Confirm.BackColor = Color.Transparent;
            Button_Confirm.BorderRadius = 25;
            Button_Confirm.CustomizableEdges = customizableEdges1;
            Button_Confirm.DisabledState.BorderColor = Color.DarkGray;
            Button_Confirm.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Confirm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Confirm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Confirm.FillColor = Color.FromArgb(29, 73, 167);
            Button_Confirm.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            Button_Confirm.ForeColor = Color.White;
            Button_Confirm.Location = new Point(489, 574);
            Button_Confirm.Name = "Button_Confirm";
            Button_Confirm.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Button_Confirm.Size = new Size(183, 49);
            Button_Confirm.TabIndex = 9;
            Button_Confirm.Text = "CONFIRM";
            Button_Confirm.Click += LogOut;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Receipt_cs;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1162, 653);
            Controls.Add(Button_Confirm);
            Controls.Add(Label_ReferenceNumber);
            DoubleBuffered = true;
            Name = "Receipt";
            Text = "Receipt";
            Shown += TriggerOnRender;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel Label_ReferenceNumber;
        private Guna.UI2.WinForms.Guna2Button Button_Confirm;
    }
}