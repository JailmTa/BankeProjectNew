using BussnessLayer_BankProjectv2.PersonTypesLogic;
using DataAccsessLayer_BankClientSidev2;
using DataAccsessLayer_BankClientSidev2.PersonTypesData;
using Guna.UI2.WinForms;
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
    public partial class ctrlAccess : UserControl
    {
        public ctrlAccess()
        {
            InitializeComponent();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        public void SetDefult()
        {
            tgAshowClients.Checked = false;
            tgEditClient.Checked = false;
            tgShowUsers.Checked = false;
            tgEditUsers.Checked = false;
            tgTotalBalanced.Checked = false;
            tgTransaction.Checked = false;
            tgTransactionLogin.Checked = false;
            tgFullAccess.Checked = false;
            tgUsersLogin.Checked = false;
            tgCrutuel.Checked = false;

        }

        int _Access = 0;
        public int GetAccess()
        {
            _Access = 0;
            if (tgFullAccess.Checked)
            {
                _Access = -1;
            }
            else
            {
                if (tgAshowClients.Checked)
                {
                    _Access+=1;
                }
                if (tgEditClient.Checked)
                {
                    _Access += 16;
                }
                if (tgShowUsers.Checked)
                {
                    _Access += 4;
                }
                if (tgEditUsers.Checked)
                {
                    _Access += 32;
                }
                if (tgTransaction.Checked)
                {
                    _Access += 2;
                }
                if (tgTransactionLogin.Checked)
                {
                    _Access += 256;
                }
                if (tgTotalBalanced.Checked)
                {
                    _Access += 64;
                }
                if (tgUsersLogin.Checked)
                {
                    _Access += 8;
                }
              
            }
            return _Access;
        }

        public async void FoundAccess(int UserID)
        {
            UsersDTO AccessGet = await clsUserLogic.FindUser(UserID);
            if (AccessGet != null)
            {
                if ((Convert.ToInt32(tgAshowClients.Tag) & AccessGet.Accsess) == Convert.ToInt32(tgAshowClients.Tag) || AccessGet.Accsess == -1)
                {
                    tgAshowClients.Checked = true;
                }
                else
                {
                    tgAshowClients.Checked = false;
                }
                if ((Convert.ToInt32(tgEditClient.Tag) & AccessGet.Accsess) == Convert.ToInt32(tgEditClient.Tag) || AccessGet.Accsess == -1)
                {
                    tgEditClient.Checked = true;
                }
                else
                {
                    tgEditClient.Checked = false;
                }
                if ((Convert.ToInt32(tgShowUsers.Tag) & AccessGet.Accsess) == Convert.ToInt32(tgShowUsers.Tag) || AccessGet.Accsess == -1)
                {
                    tgShowUsers.Checked = true;
                }

                else
                {
                    tgShowUsers.Checked = false;
                }
                if ((Convert.ToInt32(tgEditUsers.Tag) & AccessGet.Accsess) == Convert.ToInt32(tgEditUsers.Tag) || AccessGet.Accsess == -1)
                {
                    tgEditUsers.Checked = true;
                }
                else
                {
                    tgEditUsers.Checked = false;
                }
                if ((Convert.ToInt32(tgTotalBalanced.Tag) & AccessGet.Accsess) == Convert.ToInt32(tgTotalBalanced.Tag) || AccessGet.Accsess == -1)
                {
                    tgTotalBalanced.Checked = true;
                }
                else
                {
                    tgTotalBalanced.Checked = false;
                }
                if ((Convert.ToInt32(tgTransaction.Tag) & AccessGet.Accsess) == Convert.ToInt32(tgTransaction.Tag) || AccessGet.Accsess == -1)
                {
                    tgTransaction.Checked = true;
                }
                else
                {
                    tgTransaction.Checked = false;
                }
                if ((Convert.ToInt32(tgTransactionLogin.Tag) & AccessGet.Accsess) == Convert.ToInt32(tgTransactionLogin.Tag) || AccessGet.Accsess == -1)
                {
                    tgTransactionLogin.Checked = true;
                }
                else
                {
                    tgTransactionLogin.Checked = false;
                }
                if ((Convert.ToInt32(tgFullAccess.Tag) & AccessGet.Accsess) == Convert.ToInt32(tgFullAccess.Tag) || AccessGet.Accsess == -1)
                {
                    tgFullAccess.Checked = true;
                }
                else
                {
                    tgFullAccess.Checked = false;
                }
                if ((Convert.ToInt32(tgUsersLogin.Tag) & AccessGet.Accsess) == Convert.ToInt32(tgUsersLogin.Tag) || AccessGet.Accsess == -1)
                {
                    tgUsersLogin.Checked = true;
                }
                else
                {
                    tgUsersLogin.Checked = false;
                }
                if ((Convert.ToInt32(tgCrutuel.Tag) & AccessGet.Accsess) == Convert.ToInt32(tgCrutuel.Tag) || AccessGet.Accsess == -1)
                {
                    tgCrutuel.Checked = true;
                }
                else
                {
                    tgCrutuel.Checked = false;
                }
            }
            else
            {
                tgAshowClients.Checked = false;
                tgEditClient.Checked = false;
                tgShowUsers.Checked = false;
                tgEditUsers.Checked = false;
                tgTotalBalanced.Checked = false;
                tgTransaction.Checked = false;
                tgTransactionLogin.Checked = false;
                tgFullAccess.Checked = false;
                tgUsersLogin.Checked = false;
                tgCrutuel.Checked = false;

            }
        }

        private void tgEditUsers_Click(object sender, EventArgs e)
        {

        }

        private void tgFullAccess_CheckedChanged(object sender, EventArgs e)
        {
           
        }
       
        private void tgCrutuel_CheckedChanged(object sender, EventArgs e)
        {
          
          
        }
    }
}
