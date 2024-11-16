namespace BankProjectClientSidev2
{
    partial class frmPopUpMessage
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
            components = new System.ComponentModel.Container();
            AnimationTimer_Inner = new System.Windows.Forms.Timer(components);
            AnimationTimer_Closer = new System.Windows.Forms.Timer(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            txtMessage = new Label();
            SuspendLayout();
            // 
            // AnimationTimer_Inner
            // 
            AnimationTimer_Inner.Interval = 10;
            AnimationTimer_Inner.Tick += AnimationTimer_Inner_Tick;
            // 
            // AnimationTimer_Closer
            // 
            AnimationTimer_Closer.Tick += AnimationTimer_Closer_Tick;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 12;
            guna2Elipse1.TargetControl = this;
            // 
            // txtMessage
            // 
            txtMessage.AutoSize = true;
            txtMessage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtMessage.ForeColor = Color.FromArgb(72, 138, 93);
            txtMessage.Location = new Point(16, 14);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(59, 23);
            txtMessage.TabIndex = 0;
            txtMessage.Text = "label1";
            // 
            // frmPopUpMessage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 255, 234);
            ClientSize = new Size(568, 52);
            Controls.Add(txtMessage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPopUpMessage";
            Text = "frmPopUpMessage";
            Load += frmPopUpMessage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer AnimationTimer_Inner;
        private System.Windows.Forms.Timer AnimationTimer_Closer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label txtMessage;
    }
}