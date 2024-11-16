using BussnessLayer_BankProjectv2.PersonTypesLogic;
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
    public partial class frmTotalMoney : Form
    {
        public frmTotalMoney()
        {
            InitializeComponent();
        }

        private async void frmTotalMoney_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = await clsClientLogic.GetTotalBalnced();
            guna2TextBox3.Text = (await clsClientLogic.GetTotalBalancedNumber()).ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
