using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankProjectClientSidev2.Classes;

namespace BankProjectClientSidev2
{
    public partial class ctrlPassWordChecker : UserControl
    {
        public ctrlPassWordChecker()
        {
            InitializeComponent();
        }

        private void _IsCorrect(bool Value, ref Label Text, ref PictureBox Img)
        {
            if (Value)
            {
                Text.ForeColor = Color.Crimson;
                Img.Image = Image.FromFile(@"C:\Images\Icons\Hover Icons\Wrong.png");
            }
            else
            {
                Text.ForeColor = Color.Green;
                Img.Image = Image.FromFile(@"C:\Images\Icons\Genral\Correct.png");
            }

        }

        public void CheckPasswordConditions(string Password)
        {
            if (clsValidations.CheckPasswordContainNumbers(Password))
                _IsCorrect(false, ref lblNumbers, ref pbNumbers);
            else
                _IsCorrect(true, ref lblNumbers, ref pbNumbers);

            if (clsValidations.CheckPasswordContainCapLetter(Password))
                _IsCorrect(false, ref lblCapetilLaters, ref pbCaptial);
            else
                _IsCorrect(true, ref lblCapetilLaters, ref pbCaptial);

            if (clsValidations.CheckPasswordContainLowLetter(Password))
                _IsCorrect(false, ref lblLaowerCase, ref pbLaowerCase);
            else
                _IsCorrect(true, ref lblLaowerCase, ref pbLaowerCase);

            if (clsValidations.CheckPasswordContainSymbols(Password))
                _IsCorrect(false, ref lblSympole, ref pbSymploes);
            else
                _IsCorrect(true, ref lblSympole, ref pbSymploes);
        }

        public bool VerifyPasswordConditions(string PassWord)
        {
            return clsValidations.VerifyPasswordConditions(PassWord);
        }

        private void ctrlPassWordChecker_Load(object sender, EventArgs e)
        {

        }

        private void txtMessage_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
