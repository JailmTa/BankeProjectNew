using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer_BankClientSidev2.PersonTypesData
{

    public class UsersDataGradeViewDTO
    {
        public int ID { get; set; }
        public int PersonID { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsAdmin { get; set; }
        public UsersDataGradeViewDTO(int ID, int PersonID, string UserName, string FullName, string Email, DateTime BirthDate, bool Accsess)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.BirthDate = BirthDate;
            this.FullName = FullName;
            this.Email = Email;
            this.UserName = UserName;
            this.IsAdmin = Accsess;
        }
    }

    public class UsersDTO
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string PassWord { get; set; }
        public string UserName { get; set; }
        public int Accsess { get; set; }
        public UsersDTO(int ID, int PersonID, string PassWord, string UserName, int Accsess)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.PassWord = PassWord;
            this.UserName = UserName;
            this.Accsess = Accsess;
        }
    }



    public class clsUserData
    {

        public static async Task<int> AddNewUsers(UsersDTO dto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Users/");
            try
            {
                var response = await client.PostAsJsonAsync("AddNewUsers", dto);
                if (response.IsSuccessStatusCode)
                {
                    var AddedObject = await response.Content.ReadAsStringAsync();
                    return Convert.ToInt32(AddedObject);
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            return 0;
        }



        public static async Task<int> DeleteUsers(int ID)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Users/");
            var response = await client.DeleteAsync($"{ID}"); try
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



        public static async Task<List<UsersDTO>> FindUsersByEmail(string Email)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Users/");
            try
            {
                var requst = await client.GetAsync($"FindUsersByEmail/{Email}");
                UsersDTO response = await requst.Content.ReadFromJsonAsync<UsersDTO>();
                if (response != null)
                {
                    List<UsersDTO> list = new List<UsersDTO>();
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

        public static async Task<List<UsersDataGradeViewDTO>> FindUsersByFilter(int Num, string Text, string Filter)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Users/");
            try
            {
                var requst = await client.GetAsync($"Searching/{Num}/{Text}/{Filter}");
                if (requst.IsSuccessStatusCode)
                {
                    var jsonResponse = await requst.Content.ReadAsStringAsync();
                    var Table = JsonConvert.DeserializeObject<List<UsersDataGradeViewDTO>>(jsonResponse);
                    List<UsersDataGradeViewDTO> list = new List<UsersDataGradeViewDTO>();
                    foreach (var row in Table)
                    {
                        UsersDataGradeViewDTO dto = new UsersDataGradeViewDTO(row.ID, row.PersonID, row.UserName,row.FullName,row.Email,row.BirthDate, row.IsAdmin);
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


        public static async Task<List<UsersDTO>> FindUsers(int ID)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Users/");
            try
            {
                var requst = await client.GetAsync($"{ID}");
                UsersDTO response = await requst.Content.ReadFromJsonAsync<UsersDTO>();
                if (response != null)
                {
                    List<UsersDTO> list = new List<UsersDTO>();
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

        public static async Task<List<UsersDTO>> LoGin(string UserName, string PassWord)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Users/");
            try
            {
                var requst = await client.GetAsync($"LoginUser/{UserName}/{PassWord}");
                UsersDTO response = await requst.Content.ReadFromJsonAsync<UsersDTO>();
                if (response.PersonID != 0)
                {
                    List<UsersDTO> list = new List<UsersDTO>();
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



        public static async Task<UsersDTO> UpDateUsers(int ID, UsersDTO dto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Users/");
            try
            {
                var Response = await client.PutAsJsonAsync($"{ID}", dto); if (Response.IsSuccessStatusCode)
                {
                    var Person = await Response.Content.ReadFromJsonAsync<UsersDTO>(); if (Person != null)
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



        public static async Task<List<UsersDataGradeViewDTO>> GetAllUsers()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Users/");
            try
            {
                var response = await client.GetAsync("GetAllUsers");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var Table = JsonConvert.DeserializeObject<List<UsersDataGradeViewDTO>>(jsonResponse);
                    List<UsersDataGradeViewDTO> list = new List<UsersDataGradeViewDTO>();
                    foreach (var row in Table)
                    {
                        UsersDataGradeViewDTO dto = new UsersDataGradeViewDTO(row.ID, row.PersonID,row.UserName, row.FullName, row.Email, row.BirthDate, row.IsAdmin);
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
