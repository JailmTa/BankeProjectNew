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
    public partial class frmUserCard : Form
    {
        public frmUserCard()
        {
            InitializeComponent();
        }
        int _ID = 0,_UserID=0;
        public frmUserCard(int ID,int UserID)
        {
            InitializeComponent();
            _ID = ID;
            _UserID = UserID;
            ctrlClientCard1.FindID(_ID);
        }

        private void frmUserCard_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmCusteamUserSetting u=new frmCusteamUserSetting(_UserID);
            u.ShowDialog();
        }
    }
}
