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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }
        PersonsDTO _dto;
        public frmAddUser(PersonsDTO dto)
        {
            InitializeComponent();
            _dto = dto;
            tbUserName.Visible = false;
            tbPassWord.Visible = false;
            tbConfiremPassWord.Visible = false;
            guna2Button1.Text = "Edit PassWord";
            guna2Button2.Text = "Done";
            tbFirstName.SetText(dto.FirstName);
            tbLastName.SetText(dto.LastName);
            tbEmail.SetText(dto.Email);
            tbAddreass.SetText(dto.Addreass);
            dtpBirthDate.Text = dto.BirthDate.ToString();
            tbUserID.SetText(dto.ID.ToString());
        }

        private async void frmAddUser_Load(object sender, EventArgs e)
        {
            List<Countriy> list = await clsCountriesLogic.GetAllCountries();

            foreach (Countriy countriy in list)
            {
                cbContry.Items.Add(countriy.CountryName);
            }

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (_dto == null)
            {
                if (MessageBox.Show("Are You Sure You Wanna To Save The Info!?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    PersonsDTO dto = new PersonsDTO(0, tbFirstName.GetText, tbLastName.GetText, tbEmail.GetText, tbAddreass.GetText, Convert.ToDateTime(dtpBirthDate.Text), _ImagePath, cbGendor.Text.ToString()[0], clsCurrentUserInfo.Users.UserName, tbPhoneNumber.GetText, cbContry.SelectedIndex + 1);
                    _dto = dto;
                    _dto.ID = await clsPersonLogic.AddNewPerson(_dto);
                    UsersDTO udto = new UsersDTO(0, _dto.ID, tbPassWord.GetText, tbUserName.GetText, 1);
                    int ID = await clsUserLogic.AddUser(udto);
                    tbUserID.SetText(ID.ToString());
                }
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Wanna To Save The Info!?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    PersonsDTO dtoo = new PersonsDTO(0, tbFirstName.GetText, tbLastName.GetText, tbEmail.GetText, tbAddreass.GetText, Convert.ToDateTime(dtpBirthDate.Text), _ImagePath, cbGendor.Text.ToString()[0], clsCurrentUserInfo.Users.UserName, tbPhoneNumber.GetText, cbContry.SelectedIndex + 1);
                    _dto = dtoo;
                    PersonsDTO dto = await clsPersonLogic.UpDatePerso(_dto.ID, _dto);
                    frmCusteamUserSetting c = new frmCusteamUserSetting(dto.ID);
                    c.ShowDialog();
                }
            }
        }
        string _ImagePath = "C:\\Images\\Icons\\UnChecked Icons\\Profile.png";
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            guna2CirclePictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            _ImagePath = openFileDialog1.FileName;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ImagePath= "C:\\Images\\Icons\\UnChecked Icons\\Profile.png";
        }
    }
}
