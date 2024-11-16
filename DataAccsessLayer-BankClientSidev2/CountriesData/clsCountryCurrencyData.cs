using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer_BankClientSidev2.Countries
{

    public class CountryCurrencyDTO
    {
        public string CountryName { get; set; }

        public string CurrencyCode { get; set; }

        public string CurrencyName { get; set; }

        public float ExchangeRate { get; set; }


        public CountryCurrencyDTO(string CountryName, string CurrencyCode, string CurrencyName, float ExchangeRate)
        {
            this.CountryName = CountryName;
            this.CurrencyCode = CurrencyCode;
            this.CurrencyName = CurrencyName;
            this.ExchangeRate = ExchangeRate;

        }
    }

    public class clsCountryCurrencyData
    {

        public static async Task<CountryCurrencyDTO> FindCurrency(string ID)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/CountryCurrency/");
            try
            {
                var response = await client.GetAsync($"Find/{ID}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var Table = JsonConvert.DeserializeObject<CountryCurrencyDTO>(jsonResponse);


                    CountryCurrencyDTO dto = new CountryCurrencyDTO(Table.CountryName, Table.CurrencyCode, Table.CurrencyName, Table.ExchangeRate);

                    return dto;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static async Task<List<CountryCurrencyDTO>> GetAllCountries()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/CountryCurrency/");
            try
            {
                var response = await client.GetAsync("GetAllCountries");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var Table = JsonConvert.DeserializeObject<List<CountryCurrencyDTO>>(jsonResponse);
                    List<CountryCurrencyDTO> list = new List<CountryCurrencyDTO>();
                    foreach (var row in Table)
                    {
                        CountryCurrencyDTO dto = new CountryCurrencyDTO(row.CountryName, row.CurrencyCode, row.CurrencyName, row.ExchangeRate);
                        list.Add(dto);
                    }
                    return list;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
