using BussnessLayer_BankProjectv2.LogginLogic;
using BussnessLayer_BankProjectv2.PersonTypesLogic;
using BussnessLayer_BankProjectv2.TransactionLogic;
using DataAccsessLayer_BankClientSidev2.LogginData;
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
    public partial class frmTransferm : Form
    {
        public frmTransferm()
        {
            InitializeComponent();
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if (ctrlClientCard1.GetID() != 0 && ctrlClientCard2.GetID() != 0)
            {
                if (MessageBox.Show($"Are You Sure You Wanna To Transform Money [{tbTransfermMoney.Text}] Between {ctrlClientCard1.GetFullName()} => {ctrlClientCard2.GetFullName()}  ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (!guna2ToggleSwitch1.Checked)
                    {
                        int Sec = await clsTransactionLogic.Transferm(Convert.ToInt32(tbFirstID.Text), Convert.ToInt32(tbSecondID.Text), float.Parse(tbTransfermMoney.Text));
                        if (Sec > 0)
                        {
                            TransfermLogDTO dto = new TransfermLogDTO(0, Convert.ToInt32(tbFirstID.Text), ctrlClientCard1.GetFullName(), Convert.ToInt32(tbSecondID.Text), ctrlClientCard2.GetFullName(), float.Parse(tbTransfermMoney.Text),DateTime.Now);
                            await clsTransfermLogLogic.AddTransferm(dto);
                        }
                        else
                        {
                            MessageBox.Show("The Money You Wanna To WithDraw Bigger Than You Have??", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        int Sec = await clsTransactionLogic.Transferm(Convert.ToInt32(tbSecondID.Text), Convert.ToInt32(tbFirstID.Text), float.Parse(tbTransfermMoney.Text));
                        if (Sec > 0)
                        {
                            TransfermLogDTO dto = new TransfermLogDTO(0, Convert.ToInt32(tbSecondID.Text), ctrlClientCard2.GetFullName(), Convert.ToInt32(tbFirstID.Text), ctrlClientCard1.GetFullName() ,float.Parse(tbTransfermMoney.Text), DateTime.Now);
                            await clsTransfermLogLogic.AddTransferm(dto);
                        }
                        else
                        {
                            MessageBox.Show("The Money You Wanna To WithDraw Bigger Than You Have??", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("The Clients Aren\'t At System...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void tbFirstID_TextChanged(object sender, EventArgs e)
        {
            int ID = 0;
            if (int.TryParse(tbFirstID.Text, out ID))
            {
                ClientsDTO dto = await clsClientLogic.FindClient(ID);
                if (dto != null)
                {
                    ctrlClientCard1.FindID(dto.PersonID);
                    tbFirstBalanced.Text = dto.Balanced.ToString();
                }
                else
                {
                    ctrlClientCard1.SetDefult();
                    tbFirstBalanced.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private async void tbSecondID_TextChanged(object sender, EventArgs e)
        {
            int ID = 0;
            if (int.TryParse(tbSecondID.Text, out ID))
            {
                ClientsDTO dto = await clsClientLogic.FindClient(ID);
                if (dto != null)
                {
                    ctrlClientCard2.FindID(dto.PersonID);
                    tbSecondBalanced.Text = dto.Balanced.ToString();
                }
                else
                {
                    ctrlClientCard2.SetDefult();
                    tbSecondBalanced.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void frmTransferm_Load(object sender, EventArgs e)
        {

        }
    }
}

