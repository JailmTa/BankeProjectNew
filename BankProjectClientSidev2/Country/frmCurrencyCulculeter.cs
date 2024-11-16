using BussnessLayer_BankProjectv2.CountiesLogic;
using DataAccsessLayer_BankClientSidev2.Countries;
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
    public partial class frmCurrencyCulculeter : Form
    {
        public frmCurrencyCulculeter()
        {
            InitializeComponent();
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            float Money = 0.0f;
            if (float.TryParse(tbMoney.Text, out Money))
            {
                if (!guna2ToggleSwitch1.Checked)
                {
                    CountryCurrencyDTO fromdto = await clsCountryCurrencyLogic.Find(guna2ComboBox1.Text);
                    CountryCurrencyDTO todto = await clsCountryCurrencyLogic.Find(guna2ComboBox2.Text);

                    float Num = ((Money) / fromdto.ExchangeRate) * todto.ExchangeRate;
                    tbExgangedMoney.Text = Num.ToString();
                }
                else
                {
                    CountryCurrencyDTO fromdto = await clsCountryCurrencyLogic.Find(guna2ComboBox1.Text);
                    CountryCurrencyDTO todto = await clsCountryCurrencyLogic.Find(guna2ComboBox2.Text);

                    float Num = ((Money) / todto.ExchangeRate) * fromdto.ExchangeRate;
                    tbExgangedMoney.Text = Num.ToString();
                }
            }

        }

        private async void frmCurrencyCulculeter_Load(object sender, EventArgs e)
        {
            List<CountryCurrencyDTO> list = await clsCountryCurrencyLogic.GetAll();
            for (int i = 0; i < list.Count; i++)
            {
                guna2ComboBox1.Items.Add(list[i].CurrencyCode);
                guna2ComboBox2.Items.Add(list[i].CurrencyCode);
            }
        }

        private async void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbMoney_Validating(object sender, CancelEventArgs e)
        {
            float Money = 0.0f;
            if (float.TryParse(tbMoney.Text, out Money))
            {
                e.Cancel = false;
                errorProvider1.SetError(tbMoney, "");
            }
            else
            {
                e.Cancel = true;
                guna2ComboBox1.Focus();
                errorProvider1.SetError(tbMoney, "The Filed Must By Numbers Only...");
            }
        }

        private void tbMoney_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
