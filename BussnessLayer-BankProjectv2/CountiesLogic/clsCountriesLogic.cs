using DataAccsessLayer_BankClientSidev2.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnessLayer_BankProjectv2.CountiesLogic
{
    public class clsCountriesLogic
    {

        public static async Task<List<Countriy>> GetAllCountries()
        {
            return await clsCountriesData.GetAllCountries();
        }

        public static async Task<Countriy> FindCountry(int ID)
        {
            return await clsCountriesData.FindCountry(ID);
        }

    }
}
