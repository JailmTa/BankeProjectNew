namespace BankProjectClientSidev2
{
    partial class frmClientCard
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
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ctrlClientCard1 = new ctrlClientCard();
            SuspendLayout();
            // 
            // guna2Button2
            // 
            guna2Button2.Animated = true;
            guna2Button2.AutoRoundedCorners = true;
            guna2Button2.BackColor = Color.White;
            guna2Button2.BorderRadius = 27;
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Crimson;
            guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Image = Properties.Resources.Tag;
            guna2Button2.ImageAlign = HorizontalAlignment.Left;
            guna2Button2.Location = new Point(656, 466);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(173, 56);
            guna2Button2.TabIndex = 24;
            guna2Button2.Text = "Edit PinCode";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // ctrlClientCard1
            // 
            ctrlClientCard1.BackColor = Color.White;
            ctrlClientCard1.Location = new Point(1, 1);
            ctrlClientCard1.Name = "ctrlClientCard1";
            ctrlClientCard1.Size = new Size(828, 459);
            ctrlClientCard1.TabIndex = 25;
            ctrlClientCard1.Load += ctrlClientCard1_Load;
            // 
            // frmClientCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(841, 527);
            Controls.Add(ctrlClientCard1);
            Controls.Add(guna2Button2);
            Name = "frmClientCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmClientCard";
            Load += frmClientCard_Load;
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private ctrlClientCard ctrlClientCard1;
    }
}