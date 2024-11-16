using DataAccesslayer_BankProjectServerSide.CountriesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnesLayer_BankProjectServerSide.CountriesLogic
{
    public class clsCountriesLogic
    {

        public static List<Countriy> GetAllCountries()
        {
            return clsCountriesData.GetAllCountries();
        }

        public static Countriy FindCountry(int ID)
        {
            return clsCountriesData.FindCountry(ID);
        }

    }
}
