using System.Net.Mail;
using System.Net;
using DataAccsessLayer_BankClientSidev2.PersonTypesData;
using DataAccsessLayer_BankClientSidev2.LogginData;
using Guna.UI2.WinForms;
using BussnessLayer_BankProjectv2.LogginLogic;
using BussnessLayer_BankProjectv2.PersonTypesLogic;
using BankProjectClientSidev2.Classes;


namespace BankProjectClientSidev2
{

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        SendEmailRequest sent = new SendEmailRequest { ToEmail = "jailmtaleea@gmail.com", Subject = "", Body = "", Res = 0 };
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmForgittenPassWord frmForgittenPassWord = new frmForgittenPassWord();
            frmForgittenPassWord.ShowDialog();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {

            UsersDTO dto = await clsUserLogic.Login(guna2TextBox1.Text, guna2TextBox2.Text);
            if (dto != null)
            {
                LoginIDDTO ldto = new LoginIDDTO(0, dto.ID, guna2TextBox1.Text, DateTime.Now, true);
                await clsUserLogLogic.AddNewUserLog(ldto);
                clsCurrentUserInfo.Users = dto;
                this.Hide();
                frmMain m = new frmMain();
                m.ShowDialog();
            }
            else
            {
                LoginIDDTO ldtoo = new LoginIDDTO(0, 0, guna2TextBox1.Text, DateTime.Now, false);
                await clsUserLogLogic.AddNewUserLog(ldtoo);
                MessageBox.Show("The UserName Or PassWord Is Wrong !.. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmAddUser frmAddUser = new frmAddUser();
            frmAddUser.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            frmPopUpMessage frm = new frmPopUpMessage($"The PassWord You Entered Is : {guna2TextBox2.Text}", false);
            frm.Show();
        }

        private void guna2TextBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if ((((Guna2TextBox)sender).Text) != "")
            {
                e.Cancel = false;
                errorProvider1.SetError(((Guna2TextBox)sender), "");
            }
            else
            {
                e.Cancel = true;
                ((Guna2TextBox)sender).Focus();
                errorProvider1.SetError(((Guna2TextBox)sender), "You Can\'t Don\'t Fail It..");
            }

         

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }





}
