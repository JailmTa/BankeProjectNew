using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer_BankClientSidev2.PersonTypesData
{


    public class ClientsDataGradeViewDTO
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string FullName { get; set; }

        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public float Balanced { get; set; }
        public ClientsDataGradeViewDTO(int ID, int PersonID, string FullName, string Email, DateTime BirthDate, float Balanced)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.BirthDate = BirthDate;
            this.FullName = FullName;
            this.Email = Email;
            this.Balanced = Balanced;
        }
    }


    public class ClientsDTO
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string PinCode { get; set; }
        public float Balanced { get; set; }
        public ClientsDTO(int ID, int PersonID, string PinCode, float Balanced)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.PinCode = PinCode;
            this.Balanced = Balanced;
        }
    }
    public class TotalBalancedDTO
    {
        public int ID { get; set; }

        public string FullName { get; set; }
        public float Balanced { get; set; }

        public TotalBalancedDTO(int ID, float Balanced, string FullName)
        {
            this.ID = ID;
            this.Balanced = Balanced;
            this.FullName = FullName;
        }
    }
    public class clsClientData
    {
        public static async Task<int> AddNewClients(ClientsDTO dto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Clients/");
            try
            {
                var response = await client.PostAsJsonAsync("AddNewClient", dto);
                if (response.IsSuccessStatusCode)
                {
                    var AddedObject = await response.Content.ReadFromJsonAsync<ClientsDTO>();
                    return AddedObject.ID;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            return 0;
        }



        public static async Task<int> DeleteClients(int ID)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Clients/");
            var response = await client.DeleteAsync($"{ID}");
            try
            {
                var requst = response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }



        public static async Task<List<ClientsDTO>> FindClients(int ID)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Clients/");
            try
            {
                var requst = await client.GetAsync($"{ID}");
                ClientsDTO response = await requst.Content.ReadFromJsonAsync<ClientsDTO>();
                if (response != null)
                {
                    List<ClientsDTO> list = new List<ClientsDTO>();
                    list.Add(response);
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

        public static async Task<List<ClientsDTO>> FindClientsByPersonID(int ID)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Clients/");
            try
            {
                var requst = await client.GetAsync($"FindClientsByPerson/{ID}");
                ClientsDTO response = await requst.Content.ReadFromJsonAsync<ClientsDTO>();
                if (response != null)
                {
                    List<ClientsDTO> list = new List<ClientsDTO>();
                    list.Add(response);
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



        public static async Task<ClientsDTO> UpDateClients(int ID, ClientsDTO dto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Clients/");
            try
            {
                var Response = await client.PutAsJsonAsync($"{ID}", dto); if (Response.IsSuccessStatusCode)
                {
                    var Person = await Response.Content.ReadFromJsonAsync<ClientsDTO>(); if (Person != null)
                    {
                        return Person;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }



        public static async Task<List<ClientsDataGradeViewDTO>> GetAllClients()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Clients/");
            try
            {
                var response = await client.GetAsync("GetAllClients");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var Table = JsonConvert.DeserializeObject<List<ClientsDataGradeViewDTO>>(jsonResponse);
                    List<ClientsDataGradeViewDTO> list = new List<ClientsDataGradeViewDTO>();
                    foreach (var row in Table)
                    {
                        ClientsDataGradeViewDTO dto = new ClientsDataGradeViewDTO(row.ID, row.PersonID, row.FullName,row.Email,row.BirthDate, row.Balanced);
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

      

        public static async Task<List<ClientsDataGradeViewDTO>> SearchingFilter(int num, string text, string filter)
        {
              HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Clients/");
            try
            {
                var response = await client.GetAsync($"Searching/{num}/{text}/{filter}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var table = JsonConvert.DeserializeObject<List<ClientsDataGradeViewDTO>>(jsonResponse);

                    if (table != null)
                    {
                        return table;
                    }
                }

               
                return null;
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }


        public static async Task<List<TotalBalancedDTO>> GetTotalBalnced()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/TotalBalanced/");
            try
            {
                var response = await client.GetAsync("GetTotalBalanced");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var Table = JsonConvert.DeserializeObject<List<TotalBalancedDTO>>(jsonResponse);
                    List<TotalBalancedDTO> list = new List<TotalBalancedDTO>();
                    foreach (var row in Table)
                    {
                        TotalBalancedDTO dto = new TotalBalancedDTO(row.ID, row.Balanced, row.FullName);
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


        public static async Task<float> GetTotalBalncedNumber()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/TotalBalanced/");
            try
            {
                var response = await client.GetAsync("GetTotalBalancedNumber/1");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var Table = JsonConvert.DeserializeObject<float>(jsonResponse);

                    return Table;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


    }
}
