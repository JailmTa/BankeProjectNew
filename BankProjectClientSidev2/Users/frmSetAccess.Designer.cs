namespace BankProjectClientSidev2
{
    partial class frmSetAccess
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
            ctrlAccess1 = new ctrlAccess();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ctrlClientCard1 = new ctrlClientCard();
            label2 = new Label();
            tbFirstID = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrlAccess1
            // 
            ctrlAccess1.BackColor = Color.White;
            ctrlAccess1.Location = new Point(823, 266);
            ctrlAccess1.Name = "ctrlAccess1";
            ctrlAccess1.Size = new Size(825, 314);
            ctrlAccess1.TabIndex = 0;
            // 
            // guna2Button2
            // 
            guna2Button2.Animated = true;
            guna2Button2.AutoRoundedCorners = true;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderRadius = 27;
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Crimson;
            guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Image = Properties.Resources.Tag2;
            guna2Button2.ImageAlign = HorizontalAlignment.Left;
            guna2Button2.Location = new Point(1149, 582);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(173, 56);
            guna2Button2.TabIndex = 27;
            guna2Button2.Text = "Edit";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(235, 40, 79);
            label1.Location = new Point(804, 52);
            label1.Name = "label1";
            label1.Size = new Size(124, 46);
            label1.TabIndex = 36;
            label1.Text = "Access";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_password_reset_100;
            pictureBox1.Location = new Point(664, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // ctrlClientCard1
            // 
            ctrlClientCard1.BackColor = Color.White;
            ctrlClientCard1.Location = new Point(2, 190);
            ctrlClientCard1.Name = "ctrlClientCard1";
            ctrlClientCard1.Size = new Size(825, 466);
            ctrlClientCard1.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(235, 40, 79);
            label2.Location = new Point(850, 181);
            label2.Name = "label2";
            label2.Size = new Size(33, 28);
            label2.TabIndex = 38;
            label2.Text = "ID";
            // 
            // tbFirstID
            // 
            tbFirstID.BorderColor = Color.FromArgb(235, 40, 79);
            tbFirstID.BorderRadius = 12;
            tbFirstID.CustomizableEdges = customizableEdges3;
            tbFirstID.DefaultText = "";
            tbFirstID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbFirstID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbFirstID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbFirstID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbFirstID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbFirstID.Font = new Font("Segoe UI", 9F);
            tbFirstID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbFirstID.Location = new Point(832, 194);
            tbFirstID.Margin = new Padding(3, 4, 3, 4);
            tbFirstID.Name = "tbFirstID";
            tbFirstID.PasswordChar = '\0';
            tbFirstID.PlaceholderText = "";
            tbFirstID.SelectedText = "";
            tbFirstID.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbFirstID.Size = new Size(216, 60);
            tbFirstID.TabIndex = 37;
            tbFirstID.TextChanged += tbFirstID_TextChanged;
            // 
            // frmSetAccess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1655, 646);
            Controls.Add(label2);
            Controls.Add(tbFirstID);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(ctrlClientCard1);
            Controls.Add(guna2Button2);
            Controls.Add(ctrlAccess1);
            Name = "frmSetAccess";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSetAccess";
            Load += frmSetAccess_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlAccess ctrlAccess1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Label label1;
        private PictureBox pictureBox1;
        private ctrlClientCard ctrlClientCard1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbFirstID;
    }
}