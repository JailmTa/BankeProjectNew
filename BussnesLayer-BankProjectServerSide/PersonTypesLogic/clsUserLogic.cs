using DataAccesslayer_BankProjectServerSide.PersonTypesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnesLayer_BankProjectServerSide.PersonTypesLogic
{
    public class clsUserLogic
    {
        public enum enMode { AddNew = 0, UpDate = 1 };
        public enMode Mode = enMode.AddNew;
        public UsersDTO UDTO
        {
            get { return new UsersDTO(ID, PersonID, PassWord, UserName, Accsess); }
        }
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string PassWord { get; set; }
        public string UserName { get; set; }
        public int Accsess { get; set; }
        public clsUserLogic(UsersDTO UDTO, enMode cMode = enMode.AddNew)
        {
            ID = UDTO.ID;
            PersonID = UDTO.PersonID;
            PassWord = UDTO.PassWord;
            UserName = UDTO.UserName;
            Accsess = UDTO.Accsess;
            Mode = cMode;
        }



        private int Add(UsersDTO DTO)
        {
            return clsUserData.AddUsers(DTO);
        }

        private UsersDTO UpDate(int ID, UsersDTO DTO)
        {
            return clsUserData.UpDateUsers(ID, DTO);
        }

        public static UsersDTO Find(int ID)
        {
            return clsUserData.FindUsers(ID);
        }

        public static UsersDTO Login(string UserName, string PassWord)
        {
            return clsUserData.LogInUser(UserName, PassWord);
        }

        public static List<UsersDataGradeViewDTO> GetAll()
        {
            return clsUserData.GetAllUsers();
        }

        public static List<UsersDataGradeViewDTO> SerchingByFilter(int Num, string Text, string Filter)
        {
            return clsUserData.SearchingFilterUsers(Num, Text, Filter);
        }

        public static int Delete(int ID)
        {
            return clsUserData.DeleteUsers(ID);
        }

        public static UsersDTO FindUserByEmai(string Email)
        {
            return clsUserData.FindUsersByEmail(Email);
        }

        public static List<UsersDTO> FindByFilter(int Num, string Text, string Filter)
        {
            return clsUserData.FindUsersFilter(Num, Text, Filter);
        }

        public int Save()
        {
            if (Mode == enMode.AddNew)
            {
                int ID = Add(UDTO);
                this.ID = ID;
                UDTO.ID = ID;
                return ID;
            }
            else
            {
                return UpDate(UDTO.ID, UDTO).ID;
            }

        }

    }
}
