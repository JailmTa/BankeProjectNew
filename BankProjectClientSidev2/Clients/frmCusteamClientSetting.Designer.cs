namespace BankProjectClientSidev2
{
    partial class frmCusteamClientSetting
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
            tbLastPinCode = new ctrlTextBox();
            tbNewPinCode = new ctrlTextBox();
            tbConfirmPinCode = new ctrlTextBox();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbLastPinCode
            // 
            tbLastPinCode.BackColor = Color.White;
            tbLastPinCode.BordarText = "Last PinCode";
            tbLastPinCode.ErrorType = ctrlTextBox.enErrorTypes.None;
            tbLastPinCode.GetText = null;
            tbLastPinCode.Location = new Point(75, 132);
            tbLastPinCode.Name = "tbLastPinCode";
            tbLastPinCode.Size = new Size(484, 84);
            tbLastPinCode.TabIndex = 0;
            // 
            // tbNewPinCode
            // 
            tbNewPinCode.BackColor = Color.White;
            tbNewPinCode.BordarText = "New PinCode";
            tbNewPinCode.ErrorType = ctrlTextBox.enErrorTypes.None;
            tbNewPinCode.GetText = null;
            tbNewPinCode.Location = new Point(75, 222);
            tbNewPinCode.Name = "tbNewPinCode";
            tbNewPinCode.Size = new Size(484, 84);
            tbNewPinCode.TabIndex = 1;
            // 
            // tbConfirmPinCode
            // 
            tbConfirmPinCode.BackColor = Color.White;
            tbConfirmPinCode.BordarText = "Comferm PinCode";
            tbConfirmPinCode.ErrorType = ctrlTextBox.enErrorTypes.None;
            tbConfirmPinCode.GetText = null;
            tbConfirmPinCode.Location = new Point(75, 312);
            tbConfirmPinCode.Name = "tbConfirmPinCode";
            tbConfirmPinCode.Size = new Size(484, 84);
            tbConfirmPinCode.TabIndex = 2;
            tbConfirmPinCode.Load += tbConfirmPinCode_Load;
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
            guna2Button2.Location = new Point(272, 424);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(173, 56);
            guna2Button2.TabIndex = 14;
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
            guna2Button1.Location = new Point(93, 424);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(173, 56);
            guna2Button1.TabIndex = 13;
            guna2Button1.Text = "Save";
            guna2Button1.Click += guna2Button1_ClickAsync;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_edit_100;
            pictureBox1.Location = new Point(132, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 96);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(235, 40, 79);
            label1.Location = new Point(272, 48);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 16;
            label1.Text = "Edit PinCode";
            // 
            // frmCusteamClientSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(527, 492);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(tbConfirmPinCode);
            Controls.Add(tbNewPinCode);
            Controls.Add(tbLastPinCode);
            Name = "frmCusteamClientSetting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCusteamClientSetting";
            Load += frmCusteamClientSetting_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlTextBox tbLastPinCode;
        private ctrlTextBox tbNewPinCode;
        private ctrlTextBox tbConfirmPinCode;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}