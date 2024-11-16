using DataAccsessLayer_BankClientSidev2.PersonTypesData;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BussnessLayer_BankProjectv2.PersonTypesLogic
{
    public class clsPersonLogic
    {
        public static async Task<List<PersonsDTO>> GetAllPerson()
        {
            return await clsPersonData.GetAllPersons();
        }

        public static async Task<int> AddNewPerson(PersonsDTO dto)
        {
            return await clsPersonData.AddNewPersons(dto);
        }


        public static async Task<PersonsDTO> UpDatePerso(int ID, PersonsDTO dto)
        {
            return await clsPersonData.UpDatePersons(ID, dto);
        }

        public static async Task<PersonsDTO> FindPerson(int ID)
        {
            List<PersonsDTO> list = await clsPersonData.FindPersons(ID);
            if (list != null)
                return list[0];
            else
                return null;

        }



    }
}
