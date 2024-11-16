using BussnessLayer_BankProjectv2.PersonTypesLogic;
using BussnessLayer_BankProjectv2.TransactionLogic;
using DataAccsessLayer_BankClientSidev2.PersonTypesData;
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
    public partial class frmDeposit : Form
    {
        public frmDeposit()
        {
            InitializeComponent();
        }

        private async void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            int ID = 0;
            if (int.TryParse(tbID.Text, out ID))
            {
                ClientsDTO dto = await clsClientLogic.FindClient(ID);
                if (dto != null)
                {
                    ctrlClientCard1.FindID(dto.PersonID);
                    tbBalanced.Text = dto.Balanced.ToString();
                    ctrlClientCard1.SetID(ID);
                }
                else
                {
                    ctrlClientCard1.SetDefult();
                    tbBalanced.Text = "0";
                }
            }

        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {

        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if (ctrlClientCard1.GetID() != 0)
            {
                if (MessageBox.Show("Are You Sure You Wanna To Deposit Money ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    await clsTransactionLogic.DepositMoney(Convert.ToInt32(tbID.Text), float.Parse(tbDepositMoney.Text));
                }
            }
            else
            {
                MessageBox.Show("The Client Isn\'t At System...","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
