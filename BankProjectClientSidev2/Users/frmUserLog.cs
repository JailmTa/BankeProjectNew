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
    public partial class frmUserLog : Form
    {
        public frmUserLog()
        {
            InitializeComponent();
        }

        private async void frmUserLog_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = await clsUserLogLogic.GetAllUsersLog();
            guna2ComboBox1.Items.Add("None");
            for (int i = 0; i < guna2DataGridView1.Columns.Count; i++)
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
            else if (guna2ComboBox1.SelectedIndex == 4)
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

        private async void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            if (guna2ComboBox1.SelectedIndex == 1 || guna2ComboBox1.SelectedIndex == 2 || guna2ComboBox1.SelectedIndex == 5)
            {
                int ID = 0;
                if (int.TryParse(guna2TextBox1.Text, out ID))
                    guna2DataGridView1.DataSource = await clsUserLogLogic.SearchingLoggin(ID, guna2TextBox1.Text, guna2ComboBox1.Text, DateTime.Now, DateTime.Now);
            }
            else if (guna2ComboBox1.SelectedIndex == 3)
            {
                guna2DataGridView1.DataSource = await clsUserLogLogic.SearchingLoggin(0, guna2TextBox1.Text, guna2ComboBox1.Text, DateTime.Now, DateTime.Now);

            }
            else if (guna2ComboBox1.SelectedIndex == 0)
            {
                guna2DataGridView1.DataSource = await clsUserLogLogic.GetAllUsersLog();
            }
            else
            {
                guna2DataGridView1.DataSource = await clsUserLogLogic.SearchingLoggin(0, "1", guna2ComboBox1.Text, Convert.ToDateTime(guna2DateTimePicker1.Text), Convert.ToDateTime(guna2DateTimePicker2.Text));
            }
        }
    }
}
