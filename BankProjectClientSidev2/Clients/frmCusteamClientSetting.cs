using BussnessLayer_BankProjectv2.PersonTypesLogic;
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
    public partial class frmCusteamClientSetting : Form
    {
        public frmCusteamClientSetting()
        {
            InitializeComponent();
        }
        int _PersonID = 0;
        public frmCusteamClientSetting(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private async void guna2Button1_ClickAsync(object sender, EventArgs e)
        {
            ClientsDTO dto = await clsClientLogic.FindClientByPersonID(_PersonID);
            if (tbLastPinCode.GetText != dto.PinCode)
            {
                MessageBox.Show("You Must Enter The Last PinCode Right !..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbNewPinCode.GetText != tbConfirmPinCode.GetText)
            {
                MessageBox.Show("You Must Matched The New PinCode With Confirm !..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Wanna To Edit PinCode ?!", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    dto.PinCode = tbConfirmPinCode.GetText;
                    await clsClientLogic.UpDateClient(dto.ID, dto);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void frmCusteamClientSetting_Load(object sender, EventArgs e)
        {

        }

        private void tbConfirmPinCode_Load(object sender, EventArgs e)
        {

        }
    }
}
