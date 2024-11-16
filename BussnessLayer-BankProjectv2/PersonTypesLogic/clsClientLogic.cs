using DataAccsessLayer_BankClientSidev2.PersonTypesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnessLayer_BankProjectv2.PersonTypesLogic
{
    public class clsClientLogic
    {

        public static async Task<List<ClientsDataGradeViewDTO>> GetAllClients()
        {
            return await clsClientData.GetAllClients();
        }

        public static async Task<List<TotalBalancedDTO>> GetTotalBalnced()
        {
            return await clsClientData.GetTotalBalnced();
        }

        public static async Task<ClientsDTO> FindClient(int ID)
        {
            List<ClientsDTO> list = await clsClientData.FindClients(ID);
            if (list != null)
                return list[0];
            else
                return null;
        }


        public static async Task<List<ClientsDataGradeViewDTO>> SearcingFilter(int Num, string Text, string Filter)
        {
            List<ClientsDataGradeViewDTO> list = await clsClientData.SearchingFilter(Num, Text, Filter);
            if (list != null)
            {
                return list;
            }
            else
            {
                return null;
            }
        }

        public static async Task<ClientsDTO> FindClientByPersonID(int ID)
        {
            List<ClientsDTO> list = await clsClientData.FindClientsByPersonID(ID);
            if (list != null)
                return list[0];
            else
                return null;
        }

        public static async Task<ClientsDTO> UpDateClient(int ID, ClientsDTO dto)
        {
            return await clsClientData.UpDateClients(ID, dto);
        }

        public static async Task<int> AddClient(ClientsDTO dto)
        {
            return await clsClientData.AddNewClients(dto);
        }

        public static async Task<int> DeleteClient(int ID)
        {
            return await clsClientData.DeleteClients(ID);
        }

        public static async Task<float> GetTotalBalancedNumber()
        {
            return await clsClientData.GetTotalBalncedNumber();
        }

    }
}
