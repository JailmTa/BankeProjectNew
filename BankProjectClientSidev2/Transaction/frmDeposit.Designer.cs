namespace BankProjectClientSidev2
{
    partial class frmDeposit
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
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ctrlClientCard1 = new ctrlClientCard();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            tbID = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            tbBalanced = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            tbDepositMoney = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            guna2Button2.Image = Properties.Resources.Add3;
            guna2Button2.ImageAlign = HorizontalAlignment.Left;
            guna2Button2.Location = new Point(656, 664);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(173, 56);
            guna2Button2.TabIndex = 26;
            guna2Button2.Text = "Deposit";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // ctrlClientCard1
            // 
            ctrlClientCard1.BackColor = Color.White;
            ctrlClientCard1.Location = new Point(10, 190);
            ctrlClientCard1.Name = "ctrlClientCard1";
            ctrlClientCard1.Size = new Size(821, 455);
            ctrlClientCard1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_deposit_100__1_;
            pictureBox1.Location = new Point(286, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(235, 40, 79);
            label1.Location = new Point(417, 49);
            label1.Name = "label1";
            label1.Size = new Size(143, 46);
            label1.TabIndex = 28;
            label1.Text = "Deposit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(235, 40, 79);
            label2.Location = new Point(53, 112);
            label2.Name = "label2";
            label2.Size = new Size(33, 28);
            label2.TabIndex = 30;
            label2.Text = "ID";
            // 
            // tbID
            // 
            tbID.BorderColor = Color.FromArgb(235, 40, 79);
            tbID.BorderRadius = 12;
            tbID.CustomizableEdges = customizableEdges3;
            tbID.DefaultText = "";
            tbID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbID.Font = new Font("Segoe UI", 9F);
            tbID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbID.Location = new Point(35, 123);
            tbID.Margin = new Padding(3, 4, 3, 4);
            tbID.Name = "tbID";
            tbID.PasswordChar = '\0';
            tbID.PlaceholderText = "";
            tbID.SelectedText = "";
            tbID.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbID.Size = new Size(216, 60);
            tbID.TabIndex = 29;
            tbID.TextChanged += guna2TextBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(235, 40, 79);
            label3.Location = new Point(608, 112);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 32;
            label3.Text = "Balanced";
            // 
            // tbBalanced
            // 
            tbBalanced.BorderColor = Color.FromArgb(235, 40, 79);
            tbBalanced.BorderRadius = 12;
            tbBalanced.CustomizableEdges = customizableEdges5;
            tbBalanced.DefaultText = "";
            tbBalanced.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbBalanced.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbBalanced.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbBalanced.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbBalanced.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbBalanced.Font = new Font("Segoe UI", 9F);
            tbBalanced.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbBalanced.Location = new Point(590, 123);
            tbBalanced.Margin = new Padding(3, 4, 3, 4);
            tbBalanced.Name = "tbBalanced";
            tbBalanced.PasswordChar = '\0';
            tbBalanced.PlaceholderText = "";
            tbBalanced.SelectedText = "";
            tbBalanced.ShadowDecoration.CustomizableEdges = customizableEdges6;
            tbBalanced.Size = new Size(216, 60);
            tbBalanced.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(235, 40, 79);
            label4.Location = new Point(55, 648);
            label4.Name = "label4";
            label4.Size = new Size(167, 28);
            label4.TabIndex = 34;
            label4.Text = "Deposite Money";
            // 
            // tbDepositMoney
            // 
            tbDepositMoney.BorderColor = Color.FromArgb(235, 40, 79);
            tbDepositMoney.BorderRadius = 12;
            tbDepositMoney.CustomizableEdges = customizableEdges7;
            tbDepositMoney.DefaultText = "";
            tbDepositMoney.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbDepositMoney.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbDepositMoney.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbDepositMoney.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbDepositMoney.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbDepositMoney.Font = new Font("Segoe UI", 9F);
            tbDepositMoney.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbDepositMoney.Location = new Point(37, 659);
            tbDepositMoney.Margin = new Padding(3, 4, 3, 4);
            tbDepositMoney.Name = "tbDepositMoney";
            tbDepositMoney.PasswordChar = '\0';
            tbDepositMoney.PlaceholderText = "";
            tbDepositMoney.SelectedText = "";
            tbDepositMoney.ShadowDecoration.CustomizableEdges = customizableEdges8;
            tbDepositMoney.Size = new Size(216, 60);
            tbDepositMoney.TabIndex = 33;
            // 
            // frmDeposit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(841, 730);
            Controls.Add(label4);
            Controls.Add(tbDepositMoney);
            Controls.Add(label3);
            Controls.Add(tbBalanced);
            Controls.Add(label2);
            Controls.Add(tbID);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(guna2Button2);
            Controls.Add(ctrlClientCard1);
            Name = "frmDeposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDeposit";
            Load += frmDeposit_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private ctrlClientCard ctrlClientCard1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbID;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbBalanced;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbDepositMoney;
    }
}