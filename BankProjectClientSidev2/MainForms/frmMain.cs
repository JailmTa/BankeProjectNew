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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if ((clsCurrentUserInfo.Users.Accsess & Convert.ToInt32(guna2Button1.Tag)) == Convert.ToInt32(guna2Button1.Tag) || clsCurrentUserInfo.Users.Accsess == -1)
            {
                frmShowingClients f = new frmShowingClients();
                f.ShowDialog();
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
                frmShowingUsers f = new frmShowingUsers();
                f.ShowDialog();
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
                frmTransaction t = new frmTransaction();
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
                frmUserLog f = new frmUserLog();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Can\'t Enter To This Future \nCall Your Admin To Add It...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (clsCurrentUserInfo.Users.Accsess == -1)
            {
                frmSetAccess f = new frmSetAccess();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Can\'t Enter To This Future \nCall Your Admin To Add It...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            frmCountryCurrency f = new frmCountryCurrency();
            f.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void OpenUrl(string url)
        {
            try
            {

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to open the URL. Error: " + ex.Message);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.facebook.com/profile.php?id=100039066552130");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            OpenUrl("https://github.com/JailmTa");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.linkedin.com/in/jailm-taleea-42524932a/");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.instagram.com/jailm_taleea/");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            OpenUrl("https://t.me/jailmtaleea");
        }
    }
}
