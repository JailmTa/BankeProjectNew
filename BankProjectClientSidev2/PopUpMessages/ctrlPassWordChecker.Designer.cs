namespace BankProjectClientSidev2
{
    partial class ctrlPassWordChecker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMessage = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            lblNumbers = new Label();
            pbNumbers = new PictureBox();
            pbCaptial = new PictureBox();
            lblCapetilLaters = new Label();
            pbLaowerCase = new PictureBox();
            lblLaowerCase = new Label();
            pbSymploes = new PictureBox();
            lblSympole = new Label();
            ((System.ComponentModel.ISupportInitialize)pbNumbers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCaptial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLaowerCase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSymploes).BeginInit();
            SuspendLayout();
            // 
            // txtMessage
            // 
            txtMessage.AutoSize = true;
            txtMessage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtMessage.ForeColor = Color.Crimson;
            txtMessage.Location = new Point(45, 14);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(254, 23);
            txtMessage.TabIndex = 1;
            txtMessage.Text = "The PassWord Should Contaen";
            txtMessage.Click += txtMessage_Click;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillColor = Color.Crimson;
            guna2Separator1.Location = new Point(-25, 40);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(394, 23);
            guna2Separator1.TabIndex = 2;
            // 
            // lblNumbers
            // 
            lblNumbers.AutoSize = true;
            lblNumbers.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNumbers.ForeColor = Color.Crimson;
            lblNumbers.Location = new Point(55, 80);
            lblNumbers.Name = "lblNumbers";
            lblNumbers.Size = new Size(230, 23);
            lblNumbers.TabIndex = 3;
            lblNumbers.Text = "Contaen At Lest 8 Numbers";
            // 
            // pbNumbers
            // 
            pbNumbers.Image = Properties.Resources.Wrong;
            pbNumbers.Location = new Point(23, 75);
            pbNumbers.Name = "pbNumbers";
            pbNumbers.Size = new Size(26, 34);
            pbNumbers.SizeMode = PictureBoxSizeMode.Zoom;
            pbNumbers.TabIndex = 4;
            pbNumbers.TabStop = false;
            // 
            // pbCaptial
            // 
            pbCaptial.Image = Properties.Resources.Wrong;
            pbCaptial.Location = new Point(23, 125);
            pbCaptial.Name = "pbCaptial";
            pbCaptial.Size = new Size(26, 34);
            pbCaptial.SizeMode = PictureBoxSizeMode.Zoom;
            pbCaptial.TabIndex = 6;
            pbCaptial.TabStop = false;
            // 
            // lblCapetilLaters
            // 
            lblCapetilLaters.AutoSize = true;
            lblCapetilLaters.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCapetilLaters.ForeColor = Color.Crimson;
            lblCapetilLaters.Location = new Point(55, 130);
            lblCapetilLaters.Name = "lblCapetilLaters";
            lblCapetilLaters.Size = new Size(191, 23);
            lblCapetilLaters.TabIndex = 5;
            lblCapetilLaters.Text = "Contean Capital Laters";
            lblCapetilLaters.Click += label2_Click;
            // 
            // pbLaowerCase
            // 
            pbLaowerCase.Image = Properties.Resources.Wrong;
            pbLaowerCase.Location = new Point(23, 177);
            pbLaowerCase.Name = "pbLaowerCase";
            pbLaowerCase.Size = new Size(26, 34);
            pbLaowerCase.SizeMode = PictureBoxSizeMode.Zoom;
            pbLaowerCase.TabIndex = 8;
            pbLaowerCase.TabStop = false;
            // 
            // lblLaowerCase
            // 
            lblLaowerCase.AutoSize = true;
            lblLaowerCase.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLaowerCase.ForeColor = Color.Crimson;
            lblLaowerCase.Location = new Point(55, 182);
            lblLaowerCase.Name = "lblLaowerCase";
            lblLaowerCase.Size = new Size(228, 23);
            lblLaowerCase.TabIndex = 7;
            lblLaowerCase.Text = "Contean LaowerCase Laters";
            // 
            // pbSymploes
            // 
            pbSymploes.Image = Properties.Resources.Wrong;
            pbSymploes.Location = new Point(23, 238);
            pbSymploes.Name = "pbSymploes";
            pbSymploes.Size = new Size(26, 34);
            pbSymploes.SizeMode = PictureBoxSizeMode.Zoom;
            pbSymploes.TabIndex = 10;
            pbSymploes.TabStop = false;
            // 
            // lblSympole
            // 
            lblSympole.AutoSize = true;
            lblSympole.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSympole.ForeColor = Color.Crimson;
            lblSympole.Location = new Point(55, 243);
            lblSympole.Name = "lblSympole";
            lblSympole.Size = new Size(173, 23);
            lblSympole.TabIndex = 9;
            lblSympole.Text = "Contaen 3 Symboles";
            // 
            // ctrlPassWordChecker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbSymploes);
            Controls.Add(lblSympole);
            Controls.Add(pbLaowerCase);
            Controls.Add(lblLaowerCase);
            Controls.Add(pbCaptial);
            Controls.Add(lblCapetilLaters);
            Controls.Add(pbNumbers);
            Controls.Add(lblNumbers);
            Controls.Add(guna2Separator1);
            Controls.Add(txtMessage);
            Name = "ctrlPassWordChecker";
            Size = new Size(346, 305);
            Load += ctrlPassWordChecker_Load;
            ((System.ComponentModel.ISupportInitialize)pbNumbers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCaptial).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLaowerCase).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSymploes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtMessage;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label lblNumbers;
        private PictureBox pbNumbers;
        private PictureBox pbCaptial;
        private Label lblCapetilLaters;
        private PictureBox pbLaowerCase;
        private Label lblLaowerCase;
        private PictureBox pbSymploes;
        private Label lblSympole;
    }
}
