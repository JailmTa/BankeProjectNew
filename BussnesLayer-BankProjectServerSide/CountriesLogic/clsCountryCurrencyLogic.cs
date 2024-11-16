using DataAccesslayer_BankProjectServerSide.CountriesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnesLayer_BankProjectServerSide.CountriesLogic
{
    public class clsCountryCurrencyLogic
    {
        public static List<CountryCurrencyDTO> GetAll()
        {
            return clsCountryCurrencyData.GetAllCountries();
        }

        public static CountryCurrencyDTO Get(string id)
        {
            return clsCountryCurrencyData.FindCurrency(id);
        }
    }
}
