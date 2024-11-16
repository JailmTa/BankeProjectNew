using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using DataAccsessLayer_BankClientSidev2.PersonTypesData;

namespace DataAccsessLayer_BankClientSidev2.TransactionData
{
    public class clsTrancationData
    {

        public static async Task<int> DepositMoney(int ID, float Money)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Clients/");
            try
            {
                List<ClientsDTO> list = await clsClientData.FindClients(ID);
                ClientsDTO dto = list[0];
                dto.Balanced += Money;
                var Response = await client.PutAsJsonAsync($"{ID}", dto);
                if (Response.IsSuccessStatusCode)
                {
                    var Person = await Response.Content.ReadFromJsonAsync<ClientsDTO>();
                    if (Person != null)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            return 0;
        }


        public static async Task<int> WithdrawMoney(int ID, float Money)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Clients/");
            try
            {
                List<ClientsDTO> list = await clsClientData.FindClients(ID);
                ClientsDTO dto = list[0];
                if (dto.Balanced >= Money)
                    dto.Balanced -= Money;
                else
                    return 0;
                var Response = await client.PutAsJsonAsync($"{ID}", dto);
                if (Response.IsSuccessStatusCode)
                {
                    var Person = await Response.Content.ReadFromJsonAsync<ClientsDTO>();
                    if (Person != null)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            return 0;
        }

    }
}
