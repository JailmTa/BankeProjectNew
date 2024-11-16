using DataAccesslayer_BankProjectServerSide.Others;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer_BankProjectServerSide.PersonTypesData
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

        public PersonsDTO(int ID, string FirstName, string LastName, string Email, string Addreass, DateTime BirthDate, string ImagePath, char Gender, string UserAdded, string phoneNumber, int countryID)
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
            PhoneNumber = phoneNumber;
            CountryID = countryID;
        }
    }

    public class clsPersonData
    {
        public static int AddPersons(PersonsDTO dto)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_AddPersons", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter output = new SqlParameter("@ID", SqlDbType.Int);
                    output.Direction = ParameterDirection.Output;
                    command.Parameters.Add(output);
                    command.Parameters.AddWithValue("@FirstName", dto.FirstName);
                    command.Parameters.AddWithValue("@LastName", dto.LastName);
                    command.Parameters.AddWithValue("@Email", dto.Email);
                    command.Parameters.AddWithValue("@Addreass", dto.Addreass);
                    command.Parameters.AddWithValue("@BirthDate", dto.BirthDate);
                    command.Parameters.AddWithValue("@ImagePath", dto.ImagePath);
                    command.Parameters.AddWithValue("@Gender", dto.Gender);
                    command.Parameters.AddWithValue("@UserAdded", dto.UserAdded);
                    command.Parameters.AddWithValue("@PhoneNumber", dto.PhoneNumber);
                    command.Parameters.AddWithValue("@CountryID", dto.CountryID);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        return Convert.ToInt32(command.Parameters["@ID"].Value);
                    }
                    catch (Exception ex)
                    {
                        return 0;
                    }
                }
            }
            return 0;
        }



        public static int DeletePersons(int ID)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_DeletePersons", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", ID);
                    try
                    {
                        connection.Open();
                        int reader = command.ExecuteNonQuery();
                        return reader;
                    }
                    catch (Exception ex)
                    {
                        return 0;
                    }
                }
            }
            return 0;
        }



        public static PersonsDTO UpDatePersons(int ID, PersonsDTO dto)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_UpDatePersons", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@FirstName", dto.FirstName);
                    command.Parameters.AddWithValue("@LastName", dto.LastName);
                    command.Parameters.AddWithValue("@Email", dto.Email);
                    command.Parameters.AddWithValue("@Addreass", dto.Addreass);
                    command.Parameters.AddWithValue("@BirthDate", dto.BirthDate);
                    command.Parameters.AddWithValue("@ImagePath", dto.ImagePath);
                    command.Parameters.AddWithValue("@Gender", dto.Gender);
                    command.Parameters.AddWithValue("@UserAdded", dto.UserAdded);
                    command.Parameters.AddWithValue("@PhoneNumber", dto.PhoneNumber);
                    command.Parameters.AddWithValue("@CountryID", dto.CountryID);
                    try
                    {
                        connection.Open();
                        dto.ID = command.ExecuteNonQuery();
                        return dto;
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }
            }
            return null;
        }



        public static PersonsDTO FindPersons(int ID)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_FindPersons", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", ID);
                    try
                    {
                        connection.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            PersonsDTO dto = null; if (reader.HasRows)
                            {
                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    dto = new PersonsDTO(Convert.ToInt32(row["ID"]),
                                     Convert.ToString(row["FirstName"]),
                                     Convert.ToString(row["LastName"]),
                                     Convert.ToString(row["Email"]),
                                     Convert.ToString(row["Addreass"]),
                                     Convert.ToDateTime(row["BirthDate"]),
                                     Convert.ToString(row["ImagePath"]),
                                     Convert.ToChar(row["Gender"]),
                                     Convert.ToString(row["UserAdded"]),
                                     Convert.ToString(row["PhoneNumber"]),
                                     Convert.ToInt32(row["CountryID"])
                                    );
                                    break;
                                }
                                return dto;
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
                }
                return null;
            }
        }



        public static List<PersonsDTO> GetAllPersons()
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllPersons", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<PersonsDTO> listdto = new List<PersonsDTO>();
                    try
                    {
                        connection.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    PersonsDTO dto = new PersonsDTO(Convert.ToInt32(row["ID"]),
                                     Convert.ToString(row["FirstName"]),
                                     Convert.ToString(row["LastName"]),
                                     Convert.ToString(row["Email"]),
                                     Convert.ToString(row["Addreass"]),
                                     Convert.ToDateTime(row["BirthDate"]),
                                     Convert.ToString(row["ImagePath"]),
                                     Convert.ToChar(row["Gender"]),
                                     Convert.ToString(row["UserAdded"]),
                                     Convert.ToString(row["PhoneNumber"]),
                                     Convert.ToInt32(row["CountryID"])
                                    );
                                    listdto.Add(dto);
                                }
                                return listdto;
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
                }
            }
            return null;
        }
    }

}
