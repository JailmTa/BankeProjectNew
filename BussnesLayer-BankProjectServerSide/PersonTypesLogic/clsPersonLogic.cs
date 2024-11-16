using DataAccesslayer_BankProjectServerSide.PersonTypesData;
namespace BussnesLayer_BankProjectServerSide.PersonTypesLogic
{
    public class clsPersonLogic
    {
        public enum enMode { AddNew = 0, UpDate = 1 };
        public enMode Mode = enMode.AddNew;
        public PersonsDTO PDTO
        {
            get { return new PersonsDTO(ID, FirstName, LastName, Email, Addreass, BirthDate, ImagePath, Gender, UserAdded, PhoneNumber, CountryID); }
        }
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
        public clsPersonLogic(PersonsDTO PDTO, enMode cMode = enMode.AddNew)
        {
            ID = PDTO.ID;
            FirstName = PDTO.FirstName;
            LastName = PDTO.LastName;
            Email = PDTO.Email;
            Addreass = PDTO.Addreass;
            BirthDate = PDTO.BirthDate;
            ImagePath = PDTO.ImagePath;
            Gender = PDTO.Gender;
            UserAdded = PDTO.UserAdded;
            PhoneNumber = PDTO.PhoneNumber;
            CountryID = PDTO.CountryID;
            Mode = cMode;
        }

        private int Add(PersonsDTO DTO)
        {
            return clsPersonData.AddPersons(DTO);
        }

        private PersonsDTO UpDate(int ID, PersonsDTO DTO)
        {
            return clsPersonData.UpDatePersons(ID, DTO);
        }

        public static PersonsDTO Find(int ID)
        {
            return clsPersonData.FindPersons(ID);
        }

        public static List<PersonsDTO> GetAll()
        {
            return clsPersonData.GetAllPersons();
        }

        public static int Delete(int ID)
        {
            return clsPersonData.DeletePersons(ID);
        }


        public int Save()
        {
            if (Mode == enMode.AddNew)
            {
                int ID = Add(PDTO);
                this.ID = ID;
                PDTO.ID = ID;
                return ID;
            }
            else
            {
                return UpDate(PDTO.ID, PDTO).ID;
            }

        }

    }
}
