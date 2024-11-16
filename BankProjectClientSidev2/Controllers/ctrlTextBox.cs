using BussnessLayer_BankProjectv2;
using Guna.UI2.WinForms;
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
    public partial class ctrlTextBox : UserControl
    {
        public ctrlTextBox()
        {
            InitializeComponent();

        }

        public string BordarText { get; set; }

        public string GetText { get; set; }

        public enum enErrorTypes { None = 0, Numbers = 1, String = 2, Email = 3 }

        public enErrorTypes ErrorType { get; set; }

        private void ctrlTextBox_Load(object sender, EventArgs e)
        {
            label1.Text = BordarText;
        }


        public void SetText(string text)
        {
            guna2TextBox1.Text = text;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            GetText = guna2TextBox1.Text;
        }

        private void guna2TextBox1_Validating(object sender, CancelEventArgs e)
        {
            int ID = 0;
            switch (ErrorType)
            {
                case enErrorTypes.Numbers:
                    if (int.TryParse(guna2TextBox1.Text, out ID)) 
                    {
                        e.Cancel = false;
                        errorProvider1.SetError(guna2TextBox1, "");

                    }
                    else
                    {
                        e.Cancel = true;
                        guna2TextBox1.Focus();
                        errorProvider1.SetError(guna2TextBox1, "You Must Enter Numbers Only");
                    }
                    break;
                case enErrorTypes.String:
                    if (guna2TextBox1.Text != "")
                    {
                        e.Cancel = false;
                        errorProvider1.SetError(guna2TextBox1, "");

                    }
                    else
                    {
                        e.Cancel = true;
                        guna2TextBox1.Focus();
                        errorProvider1.SetError(guna2TextBox1, "You Can\'t Make The Filed Empty");
                    }
                    break;
                case enErrorTypes.Email:
                    if (guna2TextBox1.Text.Contains("@gmail.com"))
                    {
                        e.Cancel = false;
                        errorProvider1.SetError(guna2TextBox1, "");

                    }
                    else
                    {
                        e.Cancel = true;
                        guna2TextBox1.Focus();
                        errorProvider1.SetError(guna2TextBox1, "This Email Is At Incorrect Format");
                    }
                    break;
                default:
                    e.Cancel = false;
                    errorProvider1.SetError(guna2TextBox1, "");
                    break;
            }
        }
    }
}
