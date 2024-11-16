using System.Net.Http.Json;
using Newtonsoft.Json;

namespace DataAccsessLayer_BankClientSidev2.PersonTypesData
{
    public class PersonsDTO
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Addreass { get; set; }
        public DateTime BirthDate { get; set; }
        public string ImagePath { get; set; }
        public char Gender { get; set; }
        public string UserAdded { get; set; }

        public string PhoneNumber { get; set; }

        public int CountryID { get; set; }

        public PersonsDTO(int ID, string FirstName, string LastName, string Email, string Addreass, DateTime BirthDate, string ImagePath, char Gender, string UserAdded,string PhoneNumber,int CountryID)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Addreass = Addreass;
            this.BirthDate = BirthDate;
            this.ImagePath = ImagePath;
            this.Gender = Gender;
            this.UserAdded = UserAdded;
            this.PhoneNumber= PhoneNumber;
            this.CountryID = CountryID;
        }
    }



    public class clsPersonData
    {
        public static async Task<int> AddNewPersons(PersonsDTO dto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Persons/");
            try
            {
                var response = await client.PostAsJsonAsync("AddNewPerson", dto);
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



        public static async Task<int> DeletePersons(int ID)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Persons/");
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



        public static async Task<List<PersonsDTO>> FindPersons(int ID)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Persons/");
            try
            {
                var requst = await client.GetAsync($"{ID}");
                PersonsDTO response = await requst.Content.ReadFromJsonAsync<PersonsDTO>();
                if (response != null)
                {
                    List<PersonsDTO> list = new List<PersonsDTO>();
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



        public static async Task<PersonsDTO> UpDatePersons(int ID, PersonsDTO dto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Persons/");
            try
            {
                var Response = await client.PutAsJsonAsync($"{ID}", dto);
                if (Response.IsSuccessStatusCode)
                {
                    var Person = await Response.Content.ReadFromJsonAsync<PersonsDTO>();
                    if (Person != null)
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



        public static async Task<List<PersonsDTO>> GetAllPersons()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7118/api/Persons/");
            try
            {
                var response = await client.GetAsync("GetAllPersons");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var Table = JsonConvert.DeserializeObject<List<PersonsDTO>>(jsonResponse);
                    List<PersonsDTO> list = new List<PersonsDTO>();
                    foreach (var row in Table)
                    {
                        PersonsDTO dto = new PersonsDTO(row.ID, row.FirstName, row.LastName, row.Email, row.Addreass, row.BirthDate,row.ImagePath,row.Gender,row.UserAdded,row.PhoneNumber,row.CountryID);
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
