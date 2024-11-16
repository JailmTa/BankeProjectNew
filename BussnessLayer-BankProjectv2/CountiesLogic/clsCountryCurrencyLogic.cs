using DataAccsessLayer_BankClientSidev2.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnessLayer_BankProjectv2.CountiesLogic
{
    public class clsCountryCurrencyLogic
    {
        public static async Task<List<CountryCurrencyDTO>> GetAll()
        {
            return await clsCountryCurrencyData.GetAllCountries();
        }

        public static async Task<CountryCurrencyDTO> Find(string Name)
        {
            return await clsCountryCurrencyData.FindCurrency(Name);
        }

    }
}
