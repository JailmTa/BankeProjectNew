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
    public partial class ctrlClientCard : UserControl
    {
        public ctrlClientCard()
        {
            InitializeComponent();
        }
        int _ID = 0;
        public ctrlClientCard(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void ctrlClientCard_Load(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        public void SetDefult()
        {
            lblAddreass.Text = "[N/A]";
            lblBirthDate.Text = "[N/A]";
            lblFullName.Text = "[N/A]";
            lblGendor.Text = "[N/A]";
            lblEmail.Text = "[N/A]";
            lblCountry.Text = "[N/A]";
            lblPhoneNumber.Text = "[N/A]";
            lblID.Text = "[N/A]";
            guna2CirclePictureBox1.Image = Image.FromFile(@"C:\Images\Icons\UnChecked Icons\Profile.png");
            _ID = 0;
        }

        public string GetFullName()
        {
            return lblFullName.Text;
        }

        public int GetID()
        {
            return _ID;
        }

        public void SetID(int ID)
        {
            _ID = ID;
        }

        public async void FindID(int ID)
        {
            PersonsDTO dto = await clsPersonLogic.FindPerson(ID);
            lblID.Text = dto.ID.ToString();
            lblFullName.Text = dto.FirstName.ToString() + " " + dto.LastName.ToString();
            lblEmail.Text = dto.Email.ToString();
            lblAddreass.Text = dto.Addreass.ToString();
            lblBirthDate.Text = dto.BirthDate.ToString();
            lblGendor.Text=dto.Gender.ToString();
            lblPhoneNumber.Text = dto.PhoneNumber.ToString();
            Countriy countriy=await clsCountriesLogic.FindCountry(dto.CountryID);
            lblCountry.Text=countriy.CountryName;
            guna2CirclePictureBox1.Image = Image.FromFile(dto.ImagePath);
            _ID = ID;
        }

        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int ID = 0;
            if(int.TryParse(lblID.Text,out ID))
            {
                PersonsDTO p =await clsPersonLogic.FindPerson(ID);
                if (p != null)
                {
                    frmAddPerson a = new frmAddPerson(p);
                    a.ShowDialog();
                }
            }
        }
    }
}
