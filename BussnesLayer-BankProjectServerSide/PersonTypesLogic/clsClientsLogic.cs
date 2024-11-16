using DataAccesslayer_BankProjectServerSide.PersonTypesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnesLayer_BankProjectServerSide.PersonTypesLogic
{
    public class clsClientsLogic
    {

        public enum enMode { AddNew = 0, UpDate = 1 };
        public enMode Mode = enMode.AddNew;
        public ClientsDTO CDTO
        {
            get { return new ClientsDTO(ID, PersonID, PinCode, Balanced); }
        }
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string PinCode { get; set; }
        public float Balanced { get; set; }
        public clsClientsLogic(ClientsDTO CDTO, enMode cMode = enMode.AddNew)
        {
            ID = CDTO.ID;
            PersonID = CDTO.PersonID;
            PinCode = CDTO.PinCode;
            Balanced = CDTO.Balanced;
            Mode = cMode;
        }



        private int Add(ClientsDTO DTO)
        {
            return clsClientsData.AddClients(DTO);
        }

        private ClientsDTO UpDate(int ID, ClientsDTO DTO)
        {
            return clsClientsData.UpDateClients(ID, DTO);
        }

        public static ClientsDTO Find(int ID)
        {
            return clsClientsData.FindClients(ID);
        }

        public static ClientsDTO FindByPersonID(int ID)
        {
            return clsClientsData.FindClientsByPersonID(ID);
        }

        public static List<ClientsDataGradeViewDTO> GetAll()
        {
            return clsClientsData.GetAllClients();
        }

        public static int Delete(int ID)
        {
            return clsClientsData.DeleteClients(ID);
        }

        public static List<TotalBalancedDTO> GetTotalBalanced(ref float Balanced)
        {
            return clsClientsData.GetTotalBalanced(ref Balanced);
        }


        public static List<ClientsDataGradeViewDTO> GetAllByFiltering(int Num, string Text, string Filter)
        {
            return clsClientsData.SerchingFilter(Num, Text, Filter);
        }

        public int Save()
        {
            if (Mode == enMode.AddNew)
            {
                int ID = Add(CDTO);
                this.ID = ID;
                CDTO.ID = ID;
                return ID;
            }
            else
            {
                return UpDate(CDTO.ID, CDTO).ID;
            }

        }

    }
}
