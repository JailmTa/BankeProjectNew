namespace BankProjectClientSidev2
{
    partial class frmCusteamUserSetting
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
            tbConfirmPass = new ctrlTextBox();
            tbNewPass = new ctrlTextBox();
            tbLastPass = new ctrlTextBox();
            tbNewUserName = new ctrlTextBox();
            tbCurrentUserName = new ctrlTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(235, 40, 79);
            label1.Location = new Point(498, 48);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 23;
            label1.Text = "Edit User Settings";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_edit_100;
            pictureBox1.Location = new Point(358, 12);
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
            guna2Button2.Image = Properties.Resources.Trash;
            guna2Button2.ImageAlign = HorizontalAlignment.Left;
            guna2Button2.Location = new Point(697, 327);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(173, 56);
            guna2Button2.TabIndex = 21;
            guna2Button2.Text = "Cansel";
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
            guna2Button1.Location = new Point(518, 327);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(173, 56);
            guna2Button1.TabIndex = 20;
            guna2Button1.Text = "Save";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // tbConfirmPass
            // 
            tbConfirmPass.BackColor = Color.White;
            tbConfirmPass.BordarText = "Comferm PassWord";
            tbConfirmPass.ErrorType = ctrlTextBox.enErrorTypes.None;
            tbConfirmPass.GetText = null;
            tbConfirmPass.Location = new Point(21, 314);
            tbConfirmPass.Name = "tbConfirmPass";
            tbConfirmPass.Size = new Size(484, 84);
            tbConfirmPass.TabIndex = 19;
            // 
            // tbNewPass
            // 
            tbNewPass.BackColor = Color.White;
            tbNewPass.BordarText = "New PassWord";
            tbNewPass.ErrorType = ctrlTextBox.enErrorTypes.None;
            tbNewPass.GetText = null;
            tbNewPass.Location = new Point(21, 224);
            tbNewPass.Name = "tbNewPass";
            tbNewPass.Size = new Size(484, 84);
            tbNewPass.TabIndex = 18;
            tbNewPass.Validating += tbNewPass_Validating;
            // 
            // tbLastPass
            // 
            tbLastPass.BackColor = Color.White;
            tbLastPass.BordarText = "Last PassWord";
            tbLastPass.ErrorType = ctrlTextBox.enErrorTypes.None;
            tbLastPass.GetText = null;
            tbLastPass.Location = new Point(21, 134);
            tbLastPass.Name = "tbLastPass";
            tbLastPass.Size = new Size(484, 84);
            tbLastPass.TabIndex = 17;
            // 
            // tbNewUserName
            // 
            tbNewUserName.BackColor = Color.White;
            tbNewUserName.BordarText = "New UserName";
            tbNewUserName.ErrorType = ctrlTextBox.enErrorTypes.None;
            tbNewUserName.GetText = null;
            tbNewUserName.Location = new Point(498, 224);
            tbNewUserName.Name = "tbNewUserName";
            tbNewUserName.Size = new Size(484, 84);
            tbNewUserName.TabIndex = 25;
            // 
            // tbCurrentUserName
            // 
            tbCurrentUserName.BackColor = Color.White;
            tbCurrentUserName.BordarText = "Current UserName";
            tbCurrentUserName.ErrorType = ctrlTextBox.enErrorTypes.None;
            tbCurrentUserName.GetText = null;
            tbCurrentUserName.Location = new Point(498, 134);
            tbCurrentUserName.Name = "tbCurrentUserName";
            tbCurrentUserName.Size = new Size(484, 84);
            tbCurrentUserName.TabIndex = 24;
            // 
            // frmCusteamUserSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(931, 405);
            Controls.Add(tbNewUserName);
            Controls.Add(tbCurrentUserName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(tbConfirmPass);
            Controls.Add(tbNewPass);
            Controls.Add(tbLastPass);
            Name = "frmCusteamUserSetting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCusteamUserSetting";
            Load += frmCusteamUserSetting_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private ctrlTextBox tbConfirmPass;
        private ctrlTextBox tbNewPass;
        private ctrlTextBox tbLastPass;
        private ctrlTextBox tbNewUserName;
        private ctrlTextBox tbCurrentUserName;
    }
}