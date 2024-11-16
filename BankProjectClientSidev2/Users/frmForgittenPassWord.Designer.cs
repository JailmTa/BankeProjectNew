namespace BankProjectClientSidev2
{
    partial class frmForgittenPassWord
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            tbPassWord = new ctrlTextBox();
            tbVeractionCode = new ctrlTextBox();
            tbEmail = new ctrlTextBox();
            tbConfirmPassWord = new ctrlTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(235, 40, 79);
            label1.Location = new Point(210, 50);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 23;
            label1.Text = "ReNewPassWord";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_edit_100;
            pictureBox1.Location = new Point(70, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 96);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
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
            guna2Button2.Image = Properties.Resources.List;
            guna2Button2.ImageAlign = HorizontalAlignment.Left;
            guna2Button2.Location = new Point(226, 502);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(173, 56);
            guna2Button2.TabIndex = 21;
            guna2Button2.Text = "Sent Code";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.AutoRoundedCorners = true;
            guna2Button1.BackColor = Color.White;
            guna2Button1.BorderRadius = 27;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Crimson;
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = Properties.Resources.Add2;
            guna2Button1.ImageAlign = HorizontalAlignment.Left;
            guna2Button1.Location = new Point(47, 502);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(173, 56);
            guna2Button1.TabIndex = 20;
            guna2Button1.Text = "Save";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // tbPassWord
            // 
            tbPassWord.BackColor = Color.White;
            tbPassWord.BordarText = "PassWord";
            tbPassWord.ErrorType = ctrlTextBox.enErrorTypes.String;
            tbPassWord.GetText = null;
            tbPassWord.Location = new Point(21, 314);
            tbPassWord.Name = "tbPassWord";
            tbPassWord.Size = new Size(484, 84);
            tbPassWord.TabIndex = 19;
            // 
            // tbVeractionCode
            // 
            tbVeractionCode.BackColor = Color.White;
            tbVeractionCode.BordarText = "Vefaction Number";
            tbVeractionCode.ErrorType = ctrlTextBox.enErrorTypes.Numbers;
            tbVeractionCode.GetText = null;
            tbVeractionCode.Location = new Point(21, 224);
            tbVeractionCode.Name = "tbVeractionCode";
            tbVeractionCode.Size = new Size(484, 84);
            tbVeractionCode.TabIndex = 18;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.White;
            tbEmail.BordarText = "Email";
            tbEmail.ErrorType = ctrlTextBox.enErrorTypes.Email;
            tbEmail.GetText = null;
            tbEmail.Location = new Point(21, 134);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(484, 84);
            tbEmail.TabIndex = 17;
            // 
            // tbConfirmPassWord
            // 
            tbConfirmPassWord.BackColor = Color.White;
            tbConfirmPassWord.BordarText = "ConfirmPassWord";
            tbConfirmPassWord.ErrorType = ctrlTextBox.enErrorTypes.String;
            tbConfirmPassWord.GetText = null;
            tbConfirmPassWord.Location = new Point(21, 404);
            tbConfirmPassWord.Name = "tbConfirmPassWord";
            tbConfirmPassWord.Size = new Size(484, 84);
            tbConfirmPassWord.TabIndex = 24;
            tbConfirmPassWord.Load += tbConfirmPassWord_Load;
            // 
            // frmForgittenPassWord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(442, 570);
            Controls.Add(tbConfirmPassWord);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(tbPassWord);
            Controls.Add(tbVeractionCode);
            Controls.Add(tbEmail);
            Name = "frmForgittenPassWord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmForgittenPassWord";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private ctrlTextBox tbPassWord;
        private ctrlTextBox tbVeractionCode;
        private ctrlTextBox tbEmail;
        private ctrlTextBox tbConfirmPassWord;
    }
}