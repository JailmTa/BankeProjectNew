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
    public partial class frmPopUpPassWord : Form
    {
        private int _CloseTime = 30;
        private bool NormalMode;
        public frmPopUpPassWord(string Password, bool IsNormalMode = true)
        {
            InitializeComponent();
            ctrlPassWordChecker1.CheckPasswordConditions(Password);
            NormalMode = IsNormalMode;
        }

      

        private void ctrlPassWordChecker1_Load(object sender, EventArgs e)
        {

        }

        private void frmPopUpPassWord_Load(object sender, EventArgs e)
        {
            if (NormalMode)
                this.Location = new Point(800, 600);
            else
                this.Location = new Point(850, 550);

            this.TopMost = true;
            AnimationTimer_Inner.Start();
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
    }
}
