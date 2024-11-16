using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProjectClientSidev2
{
    public partial class frmPopUpMessage : Form
    {
        private int _CloseTime = 30;
        public frmPopUpMessage(string Message, bool IsErrorMode)
        {
            InitializeComponent();
            txtMessage.Text = Message;

            _AlertUi(IsErrorMode);
        }

        private void _AlertUi(bool IsErrorMode)
        {
            if (IsErrorMode)
            {
                this.BackColor = Color.MistyRose;

                txtMessage.BackColor = Color.MistyRose;
                txtMessage.ForeColor = Color.RosyBrown;
            }
            else
            {
                this.BackColor = Color.FromArgb(225, 255, 234);

                txtMessage.BackColor = Color.FromArgb(225, 255, 234);
                txtMessage.ForeColor = Color.FromArgb(72, 138, 93);
            }
        }


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void AnimationTimer_Inner_Tick(object sender, EventArgs e)
        {
            _CloseTime--;

            if (this.Opacity != 1.0)
                this.Opacity += 0.05;
            else
            {
                AnimationTimer_Inner.Stop();
                AnimationTimer_Closer.Start();
            }
        }

        private void AnimationTimer_Closer_Tick(object sender, EventArgs e)
        {
            if (_CloseTime != 0)
            {
                if (_CloseTime <= 20)
                    this.Opacity -= 0.05;

                _CloseTime--;
            }
            else
            {
                AnimationTimer_Closer.Stop();
                this.Close();
            }
        }

        private void frmPopUpMessage_Load(object sender, EventArgs e)
        {
            Graphics MessageHeight = txtMessage.CreateGraphics();
            SizeF TextHeight = MessageHeight.MeasureString(txtMessage.Text, txtMessage.Font, txtMessage.Width);

            if (TextHeight.Height >= 40)
            {
                txtMessage.Height = (int)Math.Ceiling(TextHeight.Height);
                this.Height = (txtMessage.Height + 20);
            }

            this.Location = new Point(3, ((Screen.PrimaryScreen.WorkingArea.Height - this.Height) - 40));
            this.TopMost = true;
            AnimationTimer_Inner.Start();
        }
    }
}
