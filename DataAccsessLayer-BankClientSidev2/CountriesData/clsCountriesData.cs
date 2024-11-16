using DataAccsessLayer_BankClientSidev2.PersonTypesData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer_BankClientSidev2.Countries
{
    public class Countriy
    {
        public int ID { get; set; }

        public string CountryName { get; set; }

        public Countriy(int ID, string CountryName)
        {
            this.ID = ID;
            this.CountryName = CountryName;
        }
    }
    public class clsCountriesData
    {

        public static async Task<List<Countriy>> GetAllCountries()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Countries/");
            try
            {
                var response = await client.GetAsync("GetAllCountries");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var Table = JsonConvert.DeserializeObject<List<Countriy>>(jsonResponse);
                    List<Countriy> list = new List<Countriy>();
                    foreach (var row in Table)
                    {
                        Countriy dto = new Countriy(row.ID, row.CountryName);
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

        public static async Task<Countriy> FindCountry(int ID)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Countries/");
            try
            {
                var response = await client.GetAsync($"Find/{ID}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var Table = JsonConvert.DeserializeObject<Countriy>(jsonResponse);


                    Countriy dto = new Countriy(Table.ID, Table.CountryName);

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

    }
}
