using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer_BankClientSidev2.LogginData
{
    public class TransfermLogDTO
    {

        public int TransferID { get; set; }
        public int FirstAccount { get; set; }
        public string FirstName { get; set; }
        public int SecondAccount { get; set; }
        public string SecondName { get; set; }
        public DateTime TransferredDate { get; set; }
        public float TransferredMoney { get; set; }


        public TransfermLogDTO(int TransferID, int FirstAccount, string FirstName, int SecondAccount, string SecondName, float TransferredMoney, DateTime TransferredDate)
        {
            this.TransferID = TransferID;
            this.FirstAccount = FirstAccount;
            this.FirstName = FirstName;
            this.SecondAccount = SecondAccount;
            this.SecondName = SecondName;
            this.TransferredDate = TransferredDate;
            this.TransferredMoney = TransferredMoney;
        }

    }

    public class clsTransfermLogData
    {

        public static async Task<List<TransfermLogDTO>> GetAllTransfermLog()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Transferm/");
            try
            {
                var response = await client.GetAsync("GetAllTransferms");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var Table = JsonConvert.DeserializeObject<List<TransfermLogDTO>>(jsonResponse);
                    List<TransfermLogDTO> list = new List<TransfermLogDTO>();
                    foreach (var row in Table)
                    {
                        TransfermLogDTO dto = new TransfermLogDTO(row.TransferID, row.FirstAccount, row.FirstName, row.SecondAccount, row.SecondName, row.TransferredMoney, row.TransferredDate);
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

        public static async Task<int> AddNewTransfermLog(TransfermLogDTO dto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Transferm/");
            try
            {
                var response = await client.PostAsJsonAsync("AddNewTransferms", dto);
                if (response.IsSuccessStatusCode)
                {
                    var AddedObject = await response.Content.ReadFromJsonAsync<TransfermLogDTO>();
                    return AddedObject.FirstAccount;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            return 0;
        }


        public static async Task<List<TransfermLogDTO>> SerchinfLoggin(int Num, string Text, string Filter, DateTime StartTime, DateTime EndTime)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Transferm/");
            try
            {
                string s = StartTime.ToString("yyyy-MM-ddTHH:mm:ss");
                string e = EndTime.ToString("yyyy-MM-ddTHH:mm:ss");
                var response = await client.GetAsync($"Searching/{Num}/{Text}/{Filter}/{s}/{e}?StartTime={s}&EndTime={e}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var Table = JsonConvert.DeserializeObject<List<TransfermLogDTO>>(jsonResponse);
                    List<TransfermLogDTO> list = new List<TransfermLogDTO>();
                    foreach (var row in Table)
                    {
                        TransfermLogDTO dto = new TransfermLogDTO(row.TransferID, row.FirstAccount, row.FirstName, row.SecondAccount, row.SecondName, row.TransferredMoney, row.TransferredDate);
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
