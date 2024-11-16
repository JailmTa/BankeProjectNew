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
    public partial class frmWithdraw : Form
    {
        public frmWithdraw()
        {
            InitializeComponent();
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if (ctrlClientCard1.GetID() != 0)
            {
                if (MessageBox.Show("Are You Sure You Wanna To WithDraw Money ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int Suc = await clsTransactionLogic.WithDrawMoney(Convert.ToInt32(tbID.Text), float.Parse(tbWithdrawMoney.Text));
                    if (Suc == 0)
                    {
                        MessageBox.Show("The Money You Wanna To WithDraw Bigger Than You Have??", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("The Money WithDraw Successfully ??", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("The Client Isn\'t At System...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void tbID_TextChanged(object sender, EventArgs e)
        {
            int ID = 0;
            if (int.TryParse(tbID.Text, out ID))
            {
                ClientsDTO dto = await clsClientLogic.FindClient(ID);
                if (dto != null)
                {
                    ctrlClientCard1.FindID(dto.PersonID);
                    tbBalanced.Text = dto.Balanced.ToString();
                    ctrlClientCard1.SetID(dto.PersonID);
                }
                else
                {
                    ctrlClientCard1.SetDefult();
                    tbBalanced.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void frmWithdraw_Load(object sender, EventArgs e)
        {

        }
    }
}
