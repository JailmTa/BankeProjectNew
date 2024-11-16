using BankProjectClientSidev2.Classes;
using BussnessLayer_BankProjectv2.CountiesLogic;
using BussnessLayer_BankProjectv2.PersonTypesLogic;
using DataAccsessLayer_BankClientSidev2.Countries;
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
    public partial class frmAddPerson : Form
    {
        public frmAddPerson()
        {
            InitializeComponent();
        }
        PersonsDTO _dto;
        ClientsDTO _Clientdto;
        UsersDTO _Userdto;
        public frmAddPerson(PersonsDTO dto)
        {
            InitializeComponent();
            _dto = dto;

        }

        private async void frmAddPerson_Load(object sender, EventArgs e)
        {
            List<Countriy> list = await clsCountriesLogic.GetAllCountries();

            foreach (Countriy countriy in list)
            {
                cbContries.Items.Add(countriy.CountryName);
            }



            if (_dto != null)
            {
                dtpBirthDate.Text = _dto.BirthDate.ToString();
                tbID.SetText(_dto.ID.ToString());
                tbFirstName.SetText(_dto.FirstName);
                tbLastName.SetText(_dto.LastName);
                tbEmail.SetText(_dto.Email);
                tbAddreass.SetText(_dto.Addreass);
                tbPhoneNumber.SetText(_dto.PhoneNumber);
                if (_dto.Gender == 'M')
                {
                    cbGendor.SelectedIndex = 0;
                }
                else
                {
                    cbGendor.SelectedIndex = 1;
                }
                cbContries.SelectedIndex = _dto.CountryID;
                guna2CirclePictureBox1.Image = Image.FromFile(_dto.ImagePath);


                _Clientdto = await clsClientLogic.FindClientByPersonID(_dto.ID);
                guna2Button3.Text = "Edit PinCode";
                if (_Clientdto == null)
                {
                    _Userdto = await clsUserLogic.FindUserByEmail(_dto.Email);
                    guna2Button3.Text = "Edit PassWord";

                }
            }
        }
        string _ImagePath = "C:\\Images\\Icons\\UnChecked Icons\\Profile.png";
        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (_dto == null)
            {
                if (MessageBox.Show("Are You Sure You Wanna To Save The Info!?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    PersonsDTO dto = new PersonsDTO(_dto.ID, tbFirstName.GetText, tbLastName.GetText, tbEmail.GetText, tbAddreass.GetText, Convert.ToDateTime(dtpBirthDate.Text), _ImagePath, cbGendor.Text.ToString()[0], clsCurrentUserInfo.Users.UserName, tbPhoneNumber.GetText, cbContries.SelectedIndex );
                    int ID = await clsPersonLogic.AddNewPerson(dto);
                    tbID.SetText(ID.ToString());
                    if (ID != 0)
                        MessageBox.Show("The Account Added Successfully ", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Wanna To Save The Info!?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    PersonsDTO dtoo = new PersonsDTO(_dto.ID, tbFirstName.GetText, tbLastName.GetText, tbEmail.GetText, tbAddreass.GetText, Convert.ToDateTime(dtpBirthDate.Text), _ImagePath, cbGendor.Text.ToString()[0], clsCurrentUserInfo.Users.UserName, tbPhoneNumber.GetText, cbContries.SelectedIndex );
                    _dto = dtoo;
                    PersonsDTO dto = await clsPersonLogic.UpDatePerso(_dto.ID, _dto);
                    if (dto != null)
                    {
                        MessageBox.Show("The Account UpDated Successfully ", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            guna2CirclePictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            _ImagePath = openFileDialog1.FileName;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ImagePath = "C:\\Images\\Icons\\UnChecked Icons\\Profile.png";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(_Clientdto!=null)
            {
                frmCusteamClientSetting c=new frmCusteamClientSetting(_Clientdto.PersonID);
                c.ShowDialog();
            }
            else
            {
                frmCusteamUserSetting u=new frmCusteamUserSetting(_Userdto.ID);
                u.ShowDialog();
            }
        }
    }
}
