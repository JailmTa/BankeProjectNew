using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer_BankClientSidev2.LogginData
{
    public class LoginIDDTO
    {
        public int LoginID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public DateTime LoginDate { get; set; }
        public bool IsDone { get; set; }
        public LoginIDDTO(int LoginID, int UserID, string UserName, DateTime LoginDate, bool IsDone)
        {
            this.LoginID = LoginID;
            this.UserID = UserID;
            this.UserName = UserName;
            this.LoginDate = LoginDate;
            this.IsDone = IsDone;
        }
    }



    public class clsUserLogData
    {

        public static async Task<int> AddNewLoginID(LoginIDDTO dto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/UserLog/");
            try
            {
                var response = await client.PostAsJsonAsync("AddNewUserLog", dto);
                if (response.IsSuccessStatusCode)
                {
                    var AddedObject = await response.Content.ReadFromJsonAsync<LoginIDDTO>();
                    return AddedObject.LoginID;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            return 0;
        }


        public static async Task<List<LoginIDDTO>> GetAllLoginID()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/UserLog/");
            try
            {
                var response = await client.GetAsync("GetAllUserLog");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var Table = JsonConvert.DeserializeObject<List<LoginIDDTO>>(jsonResponse);
                    List<LoginIDDTO> list = new List<LoginIDDTO>();
                    foreach (var row in Table)
                    {
                        LoginIDDTO dto = new LoginIDDTO(row.LoginID, row.UserID, row.UserName, row.LoginDate, row.IsDone);
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

        public static async Task<List<LoginIDDTO>> SerchinfLoggin(int Num, string Text, string Filter, DateTime StartTime, DateTime EndTime)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/UserLog/");
            try
            {
                string s = StartTime.ToString("yyyy-MM-ddTHH:mm:ss");
                string e =  EndTime.ToString("yyyy-MM-ddTHH:mm:ss");
                var response = await client.GetAsync($"Searching/{Num}/{Text}/{Filter}/{s}/{e}?StartTime={s}&EndTime={e}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var Table = JsonConvert.DeserializeObject<List<LoginIDDTO>>(jsonResponse);
                    List<LoginIDDTO> list = new List<LoginIDDTO>();
                    foreach (var row in Table)
                    {
                        LoginIDDTO dto = new LoginIDDTO(row.LoginID, row.UserID, row.UserName, row.LoginDate, row.IsDone);
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
