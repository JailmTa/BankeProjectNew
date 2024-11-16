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
    public partial class frmAddClient : Form
    {
        public frmAddClient()
        {
            InitializeComponent();
        }
        PersonsDTO _dto;
        public frmAddClient(PersonsDTO dto)
        {
            InitializeComponent();
            _dto = dto;
            guna2Button1.Text = "UpDate PinCode";
            tbPinCode.Visible = false;
        }


        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (_dto == null)
            {
                if (MessageBox.Show("Are You Sure You Wanna To Save The Info!?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    PersonsDTO dto = new PersonsDTO(0, tbFirstName.GetText, tbLastName.GetText, tbEmail.GetText, tbAddreass.GetText, Convert.ToDateTime(dtpBirthDate.Text), _ImagePath, cbGendore.Text.ToString()[0], clsCurrentUserInfo.Users.UserName, tbPhoneNumber.GetText, cbCountries.SelectedIndex + 1);
                    int ID = await clsPersonLogic.AddNewPerson(dto);
                    ClientsDTO cdto = new ClientsDTO(0, ID, tbPinCode.GetText, 0.0f);
                    int logic = await clsClientLogic.AddClient(cdto);
                    tbID.SetText(ID.ToString());
                }
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Wanna To Save The Info!?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    PersonsDTO dtoo = new PersonsDTO(_dto.ID, tbFirstName.GetText, tbLastName.GetText, tbEmail.GetText, tbAddreass.GetText, Convert.ToDateTime(dtpBirthDate.Text), _ImagePath, cbGendore.Text[0], clsCurrentUserInfo.Users.UserName, tbPhoneNumber.GetText, cbCountries.SelectedIndex + 1);
                    _dto = dtoo;
                    PersonsDTO dto = await clsPersonLogic.UpDatePerso(_dto.ID, _dto);
                    frmCusteamClientSetting c = new frmCusteamClientSetting(dto.ID);
                    c.ShowDialog();
                }
            }
        }

        private async void frmAddClient_Load(object sender, EventArgs e)
        {
            List<Countriy> list = await clsCountriesLogic.GetAllCountries();

            foreach(Countriy countriy in list)
            {
                cbCountries.Items.Add(countriy.CountryName.ToString());
            }

            if (_dto != null)
            {
                dtpBirthDate.Text = _dto.BirthDate.ToString();
                tbID.SetText(_dto.ID.ToString());
                tbFirstName.SetText(_dto.FirstName);
                tbLastName.SetText(_dto.LastName);
                tbEmail.SetText(_dto.Email);
                tbAddreass.SetText(_dto.Addreass);
                cbCountries.SelectedValue= _dto.CountryID;
                if (_dto.Gender=='M')
                {
                    cbGendore.Text = "Male";
                }
                else
                {
                    cbGendore.Text = "Female";
                }
                guna2CirclePictureBox1.Image = Image.FromFile(_dto.ImagePath);
            }
        }
        string _ImagePath = "C:\\Images\\Icons\\UnChecked Icons\\Profile.png";
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                guna2CirclePictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                _ImagePath = openFileDialog1.FileName;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ImagePath = "C:\\Images\\Icons\\UnChecked Icons\\Profile.png";
        }
    }
}
