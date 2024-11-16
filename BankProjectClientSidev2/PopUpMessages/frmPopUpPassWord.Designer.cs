namespace BankProjectClientSidev2
{
    partial class frmPopUpPassWord
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
            ctrlPassWordChecker1 = new ctrlPassWordChecker();
            AnimationTimer_Inner = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            AnimationTimer_Closer = new System.Windows.Forms.Timer(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // ctrlPassWordChecker1
            // 
            ctrlPassWordChecker1.Location = new Point(3, 1);
            ctrlPassWordChecker1.Name = "ctrlPassWordChecker1";
            ctrlPassWordChecker1.Size = new Size(357, 286);
            ctrlPassWordChecker1.TabIndex = 0;
            ctrlPassWordChecker1.Load += ctrlPassWordChecker1_Load;
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
            // frmPopUpPassWord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(364, 292);
            Controls.Add(ctrlPassWordChecker1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPopUpPassWord";
            Text = "frmPopUpPassWord";
            Load += frmPopUpPassWord_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlPassWordChecker ctrlPassWordChecker1;
        private System.Windows.Forms.Timer AnimationTimer_Inner;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer AnimationTimer_Closer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}