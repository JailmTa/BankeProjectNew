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
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if ((clsCurrentUserInfo.Users.Accsess & Convert.ToInt32(guna2Button1.Tag)) == Convert.ToInt32(guna2Button1.Tag) || clsCurrentUserInfo.Users.Accsess == -1)
            {
                frmDeposit d = new frmDeposit();
                d.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Can\'t Enter To This Future \nCall Your Admin To Add It...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if ((clsCurrentUserInfo.Users.Accsess & Convert.ToInt32(guna2Button2.Tag)) == Convert.ToInt32(guna2Button2.Tag) || clsCurrentUserInfo.Users.Accsess == -1)
            {
                frmWithdraw d = new frmWithdraw();
                d.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Can\'t Enter To This Future \nCall Your Admin To Add It...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if ((clsCurrentUserInfo.Users.Accsess & Convert.ToInt32(guna2Button3.Tag)) == Convert.ToInt32(guna2Button3.Tag) || clsCurrentUserInfo.Users.Accsess == -1)
            {
                frmTransferm t = new frmTransferm();
                t.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Can\'t Enter To This Future \nCall Your Admin To Add It...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if ((clsCurrentUserInfo.Users.Accsess & Convert.ToInt32(guna2Button5.Tag)) == Convert.ToInt32(guna2Button5.Tag) || clsCurrentUserInfo.Users.Accsess == -1)
            {
                frmTansfermLog l = new frmTansfermLog();
                l.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Can\'t Enter To This Future \nCall Your Admin To Add It...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if ((clsCurrentUserInfo.Users.Accsess & Convert.ToInt32(guna2Button4.Tag)) == Convert.ToInt32(guna2Button4.Tag) || clsCurrentUserInfo.Users.Accsess == -1)
            {
                frmTotalMoney t = new frmTotalMoney();
                t.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Can\'t Enter To This Future \nCall Your Admin To Add It...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}
