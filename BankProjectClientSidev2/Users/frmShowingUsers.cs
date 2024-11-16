using BankProjectClientSidev2.Classes;
using BussnessLayer_BankProjectv2.PersonTypesLogic;
using DataAccsessLayer_BankClientSidev2.PersonTypesData;
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
    public partial class frmShowingUsers : Form
    {
        public frmShowingUsers()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if ((clsCurrentUserInfo.Users.Accsess & Convert.ToInt32(guna2CircleButton1.Tag)) == Convert.ToInt32(guna2CircleButton1.Tag) || clsCurrentUserInfo.Users.Accsess == -1)
            {
                frmAddUser a = new frmAddUser();
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Can\'t Enter To This Future \nCall Your Admin To Add It...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void frmShowingUsers_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = await clsUserLogic.GetAllUsers();
            guna2ComboBox1.Items.Add("None");
            for (int i = 0; i < 5; i++)
            {
                guna2ComboBox1.Items.Add(guna2DataGridView1.Columns[i].Name);
            }

        }

        private void editPinCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCusteamUserSetting u = new frmCusteamUserSetting(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value));
            u.ShowDialog();
        }

        private void showInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserCard c = new frmUserCard(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[1].Value), Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value));
            c.ShowDialog();
        }

        private async void upDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((clsCurrentUserInfo.Users.Accsess & Convert.ToInt32(guna2CircleButton1.Tag)) == Convert.ToInt32(guna2CircleButton1.Tag) || clsCurrentUserInfo.Users.Accsess == -1)
            {
                PersonsDTO dto = await clsPersonLogic.FindPerson(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[1].Value));
                frmAddPerson a = new frmAddPerson(dto);
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Can\'t Enter To This Future \nCall Your Admin To Add It...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Wanna To Delete Acount ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int Suc = await clsUserLogic.DeleteUser(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value));
                if (Suc != 0)
                {
                    MessageBox.Show("The Account Deleted Successfully ??", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex == 0)
            {
                guna2DataGridView1.DataSource = await clsUserLogic.GetAllUsers();
                guna2TextBox1.Visible = false;
            }
            else
            {
                guna2TextBox1.Visible = true;
            }

        }

        private async void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private async void guna2TextBox1_Validating(object sender, CancelEventArgs e)
        {
            int ID = 0;
            if (guna2ComboBox1.SelectedIndex == 1 || guna2ComboBox1.SelectedIndex == 2)
            {
                if (int.TryParse(guna2TextBox1.Text, out ID))
                {
                    e.Cancel = false;
                    errorProvider1.SetError(guna2TextBox1, "");
                    guna2DataGridView1.DataSource = await clsUserLogic.FindByFilter(ID, "1", guna2ComboBox1.Text);
                }
                else
                {
                    e.Cancel = true;
                    guna2TextBox1.Focus();
                    errorProvider1.SetError(guna2TextBox1, "You Must Enter Numbers Only");
                }
            }
            else
            {
                guna2DataGridView1.DataSource = await clsUserLogic.FindByFilter(0, guna2TextBox1.Text, guna2ComboBox1.Text);
            }
        }
    }
}
