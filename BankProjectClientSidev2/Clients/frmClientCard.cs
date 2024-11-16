using DataAccsessLayer_BankClientSidev2;
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
    public partial class frmClientCard : Form
    {
        public frmClientCard()
        {
            InitializeComponent();
        }
        int _ID = 0;
        public frmClientCard(int ID)
        {
            InitializeComponent();
            _ID = ID;
            ctrlClientCard1.FindID(_ID);
        }

        private async void frmClientCard_Load(object sender, EventArgs e)
        {


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmCusteamClientSetting c = new frmCusteamClientSetting();
            c.ShowDialog();
        }

        private void ctrlClientCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
