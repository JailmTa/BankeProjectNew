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
    public partial class frmShowingClients : Form
    {
        public frmShowingClients()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if ((clsCurrentUserInfo.Users.Accsess & Convert.ToInt32(guna2CircleButton1.Tag)) == Convert.ToInt32(guna2CircleButton1.Tag) || clsCurrentUserInfo.Users.Accsess == -1)
            {
                frmAddClient a = new frmAddClient();
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Can\'t Enter To This Future \nCall Your Admin To Add It...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void frmShowingClients_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = await clsClientLogic.GetAllClients();
            guna2ComboBox1.Items.Add("None");
            for (int i = 0; i < 4; i++)
            {
                guna2ComboBox1.Items.Add(guna2DataGridView1.Columns[i].Name);
            }
        }

        private void showInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientCard c = new frmClientCard(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[1].Value));
            c.ShowDialog();
        }

        private void editPinCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCusteamClientSetting c = new frmCusteamClientSetting(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[1].Value));
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
            if (MessageBox.Show("Are You Sure You Wanna To Delete Client !?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
               int Suc= await clsClientLogic.DeleteClient(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value));
                if (Suc != 0)
                {
                    MessageBox.Show("The Account Deleted Successfully ??", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private async void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex == 0)
            {
                guna2DataGridView1.DataSource = await clsClientLogic.GetAllClients();
                guna2TextBox1.Visible = false;
            }
            else
            {
                guna2TextBox1.Visible = true;
                guna2TextBox1.Text = "";
            }
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
                    guna2DataGridView1.DataSource = await clsClientLogic.SearcingFilter(ID, "1", guna2ComboBox1.Text);
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
                guna2DataGridView1.DataSource = await clsClientLogic.SearcingFilter(0, guna2TextBox1.Text, guna2ComboBox1.Text);
            }
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
