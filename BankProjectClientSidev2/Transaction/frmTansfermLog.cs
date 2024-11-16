using BussnessLayer_BankProjectv2.LogginLogic;
using DataAccsessLayer_BankClientSidev2.LogginData;
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
    public partial class frmTansfermLog : Form
    {
        public frmTansfermLog()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            frmTransferm t = new frmTransferm();
            t.ShowDialog();
        }

        private async void frmTansfermLog_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.Items.Add("None");
            guna2DataGridView1.DataSource = await clsTransfermLogLogic.GetTransfermLog();
            for (int i = 0; i < guna2DataGridView1.Columns.Count - 1; i++)
            {
                guna2ComboBox1.Items.Add(guna2DataGridView1.Columns[i].Name);
            }
            guna2TextBox1.Visible = false;
            guna2DateTimePicker1.Visible = false;
            guna2DateTimePicker2.Visible = false;
        }

        private async void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex == 0)
            {
                guna2TextBox1.Visible = false;
                guna2DateTimePicker1.Visible = false;
                guna2DateTimePicker2.Visible = false;
            }
            else if (guna2ComboBox1.SelectedIndex == 6)
            {
                guna2TextBox1.Visible = false;
                guna2DateTimePicker1.Visible = true;
                guna2DateTimePicker2.Visible = true;
            }
            else
            {
                guna2TextBox1.Visible = true;
                guna2DateTimePicker1.Visible = false;
                guna2DateTimePicker2.Visible = false;
            }

        }

        private async void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            if (guna2ComboBox1.SelectedIndex == 1 || guna2ComboBox1.SelectedIndex == 2 || guna2ComboBox1.SelectedIndex == 4)
            {
                int ID = 0;
                if (int.TryParse(guna2TextBox1.Text, out ID))
                    guna2DataGridView1.DataSource = await clsTransfermLogLogic.SearchingLoggin(ID, guna2TextBox1.Text, guna2ComboBox1.Text, DateTime.Now, DateTime.Now);
            }
            else if (guna2ComboBox1.SelectedIndex == 3 || guna2ComboBox1.SelectedIndex == 5)
            {
                guna2DataGridView1.DataSource = await clsTransfermLogLogic.SearchingLoggin(0, guna2TextBox1.Text, guna2ComboBox1.Text, DateTime.Now, DateTime.Now);

            }
            else if (guna2ComboBox1.SelectedIndex == 0)
            {
                guna2DataGridView1.DataSource = await clsTransfermLogLogic.GetTransfermLog();
            }
            else
            {
                guna2DataGridView1.DataSource = await clsTransfermLogLogic.SearchingLoggin(0, "1", guna2ComboBox1.Text, Convert.ToDateTime(guna2DateTimePicker1.Text), Convert.ToDateTime(guna2DateTimePicker2.Text));
            }
        }
    }
}
