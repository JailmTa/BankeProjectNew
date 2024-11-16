using BussnessLayer_BankProjectv2.CountiesLogic;
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
    public partial class frmCountryCurrency : Form
    {
        public frmCountryCurrency()
        {
            InitializeComponent();
        }

        private async void frmCountryCurrencyData_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = await clsCountryCurrencyLogic.GetAll();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            frmCurrencyCulculeter frmCurrencyCulculeter = new frmCurrencyCulculeter();
            frmCurrencyCulculeter.ShowDialog();
        }
    }
}
