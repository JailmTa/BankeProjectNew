using BankProjectClientSidev2.Classes;
using BussnessLayer_BankProjectv2.PersonTypesLogic;
using DataAccsessLayer_BankClientSidev2.PersonTypesData;
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
    public partial class frmForgittenPassWord : Form
    {
        public frmForgittenPassWord()
        {
            InitializeComponent();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {

            if (_dto != null)
            {

                if (_Code == Convert.ToInt32(tbVeractionCode.GetText))
                {
                    if (tbPassWord.GetText.Equals(tbConfirmPassWord.GetText))
                    {
                        MessageBox.Show("The PassWord Changed Succefuly..", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _dto.PassWord = tbConfirmPassWord.GetText;
                        await clsUserLogic.UpDateUser(_dto.ID, _dto);
                    }
                    else
                    {
                        MessageBox.Show("The PassWord Not Matched..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The Veraction Code Not Matched..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The Email Not Found..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int _Code = 0;
        UsersDTO _dto;
        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            UsersDTO dto = await clsUserLogic.FindUserByEmail((tbEmail.GetText));
            if (dto == null)
            {
                MessageBox.Show("The Email Not Found..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SendEmailRequest sent = new SendEmailRequest { ToEmail = tbEmail.GetText, Subject = "ReNew Account PassWord", Body = "", Res = 0 };
                sent.ToEmail = sent.ToEmail.Replace("%40", "@");
                EmailService.SendEmail(sent);
                _dto = dto;
                _Code = sent.Res;
                MessageBox.Show("The Email Sent Successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbConfirmPassWord_Load(object sender, EventArgs e)
        {

        }
    }
}
