using DataAccsessLayer_BankClientSidev2.PersonTypesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnessLayer_BankProjectv2.PersonTypesLogic
{
    public class clsUserLogic
    {

        public static async Task<List<UsersDataGradeViewDTO>> GetAllUsers()
        {
            return await clsUserData.GetAllUsers();
        }

        public static async Task<int> AddUser(UsersDTO dto)
        {
            return await clsUserData.AddNewUsers(dto);
        }

        public static async Task<UsersDTO> FindUser(int ID)
        {
            List<UsersDTO> list = await clsUserData.FindUsers(ID);
            if (list != null)
                return list[0];
            else
                return null;
        }

        public static async Task<UsersDTO> FindUserByEmail(string Email)
        {
            List<UsersDTO> list = await clsUserData.FindUsersByEmail(Email);
            if (list != null)
                return list[0];
            else
                return null;
        }

        public static async Task<List<UsersDataGradeViewDTO>> FindByFilter(int Num, string Text, string Filter)
        {
            List<UsersDataGradeViewDTO> list = await clsUserData.FindUsersByFilter(Num, Text, Filter);
            if (list != null)
            {
                return list;
            }
            else
            {
                return null;
            }
        }


        public static async Task<UsersDTO> UpDateUser(int ID, UsersDTO dto)
        {
            return await clsUserData.UpDateUsers(ID, dto);
        }

        public static async Task<int> DeleteUser(int ID)
        {
            return await clsUserData.DeleteUsers(ID);
        }

        public static async Task<UsersDTO> Login(string UserName, string PassWord)
        {
            List<UsersDTO> list = await clsUserData.LoGin(UserName, PassWord);
            if (list != null)
                return list[0];
            else
                return null;
        }

    }
}
