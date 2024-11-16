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
    public partial class frmCusteamUserSetting : Form
    {
        public frmCusteamUserSetting()
        {
            InitializeComponent();
        }
        int _UserID = 0;
        public frmCusteamUserSetting(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmCusteamUserSetting_Load(object sender, EventArgs e)
        {

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            UsersDTO dto = await clsUserLogic.FindUser(_UserID);
            if (tbNewUserName.GetText.Equals("") || tbCurrentUserName.GetText.Equals("") || tbLastPass.GetText.Equals("") || tbNewPass.GetText.Equals("") || tbNewUserName.GetText.Equals(""))
            {
                MessageBox.Show("You Must Fail All The Fields !..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dto.PassWord != tbLastPass.GetText)
            {
                MessageBox.Show("You Must Enter The Last PassWord Right !..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbNewPass.GetText != tbConfirmPass.GetText)
            {
                MessageBox.Show("You Must Matched The New PassWord With Confirm !..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbCurrentUserName.GetText != dto.UserName)
            {
                MessageBox.Show("You Must Enter The Last UserName Right !..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Wanna To Edit PassWord And UserName ?!", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    dto.PassWord = tbConfirmPass.GetText;
                    dto.UserName = tbNewUserName.GetText;
                    await clsUserLogic.UpDateUser(dto.ID, dto);
                }
            }
        }

        private void tbNewPass_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidations.VerifyPasswordConditions(tbNewPass.GetText))
            {
                frmPopUpPassWord p = new frmPopUpPassWord(tbNewPass.GetText, false);
                p.Show();
                e.Cancel = true;
                tbNewPass.Focus();
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
