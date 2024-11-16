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
    public partial class frmSetAccess : Form
    {
        public frmSetAccess()
        {
            InitializeComponent();
        }
        int _ID = 0;
        public frmSetAccess(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }



        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if (ctrlClientCard1.GetID() != 0)
            {
                if (MessageBox.Show("Are You Sure You Wanna To Save Access ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int Access = ctrlAccess1.GetAccess();
                    UsersDTO dto = await clsUserLogic.FindUser(_ID);
                    if (dto != null)
                    {
                        dto.Accsess = Access;
                        await clsUserLogic.UpDateUser(_ID, dto);
                    }
                }
            }
            else
            {
                MessageBox.Show("The User Isn\'t At System...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSetAccess_Load(object sender, EventArgs e)
        {

        }

        private async void tbFirstID_TextChanged(object sender, EventArgs e)
        {
            int ID = 0;
            if(tbFirstID.Text!="")
            ID=int.Parse(tbFirstID.Text);
            if (ID != 0)
            {
                _ID = ID;
                UsersDTO dto = await clsUserLogic.FindUser(_ID);
                if (dto != null)
                {
                    ctrlClientCard1.FindID(dto.PersonID);
                    ctrlAccess1.FoundAccess(dto.ID);
                }
                else
                {
                    ctrlClientCard1.SetDefult();
                    ctrlAccess1.SetDefult();
                }
            }
        }
    }
}
