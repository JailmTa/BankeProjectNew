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


    public class UsersDataGradeViewDTO
    {
        public int ID { get; set; }
        public int PersonID { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsAdmin { get; set; }
        public UsersDataGradeViewDTO(int ID, int PersonID, string UserName, string FullName, string Email, DateTime BirthDate, bool Accsess)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.BirthDate = BirthDate;
            this.FullName = FullName;
            this.Email = Email;
            this.UserName = UserName;
            IsAdmin = Accsess;
        }
    }


    public class UsersDTO
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string PassWord { get; set; }
        public string UserName { get; set; }
        public int Accsess { get; set; }
        public UsersDTO(int ID, int PersonID, string PassWord, string UserName, int Accsess)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.PassWord = PassWord;
            this.UserName = UserName;
            this.Accsess = Accsess;
        }
    }


    public class clsUserData
    {

        public static int AddUsers(UsersDTO dto)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_AddUsers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter output = new SqlParameter("@ID", SqlDbType.Int);
                    output.Direction = ParameterDirection.Output;
                    command.Parameters.Add(output);
                    command.Parameters.AddWithValue("@PersonID", dto.PersonID);
                    command.Parameters.AddWithValue("@PassWord", dto.PassWord);
                    command.Parameters.AddWithValue("@UserName", dto.UserName);
                    command.Parameters.AddWithValue("@Accsess", dto.Accsess);
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



        public static int DeleteUsers(int ID)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_DeleteUsers", connection))
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



        public static UsersDTO UpDateUsers(int ID, UsersDTO dto)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_UpDateUsers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@PersonID", dto.PersonID);
                    command.Parameters.AddWithValue("@PassWord", dto.PassWord);
                    command.Parameters.AddWithValue("@UserName", dto.UserName);
                    command.Parameters.AddWithValue("@Accsess", dto.Accsess);
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



        public static UsersDTO FindUsers(int ID)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_FindUsers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", ID);
                    try
                    {
                        connection.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            UsersDTO dto = null; if (reader.HasRows)
                            {
                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    dto = new UsersDTO(Convert.ToInt32(row["ID"]),
                                     Convert.ToInt32(row["PersonID"]),
                                     Convert.ToString(row["PassWord"]),
                                     Convert.ToString(row["UserName"]),
                                     Convert.ToInt32(row["Accsess"])
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



        public static List<UsersDTO> FindUsersFilter(int Num, string Text, string Filter)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_SerchingFilter", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Num", Num);
                    command.Parameters.AddWithValue("@String", Text);
                    command.Parameters.AddWithValue("@SerchFilter", Filter);
                    try
                    {
                        connection.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<UsersDTO> list = new List<UsersDTO>();
                            UsersDTO dto = null;
                            if (reader.HasRows)
                            {

                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    dto = new UsersDTO(Convert.ToInt32(row["ID"]),
                                     Convert.ToInt32(row["PersonID"]),
                                     Convert.ToString(row["PassWord"]),
                                     Convert.ToString(row["UserName"]),
                                     Convert.ToInt32(row["Accsess"])
                                    );
                                    list.Add(dto);
                                }
                                return list;
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


        public static UsersDTO FindUsersByEmail(string Email)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_FindUserByEmail", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Email", Email);
                    try
                    {
                        connection.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            UsersDTO dto = null; if (reader.HasRows)
                            {
                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    dto = new UsersDTO(Convert.ToInt32(row["ID"]),
                                     Convert.ToInt32(row["PersonID"]),
                                     Convert.ToString(row["PassWord"]),
                                     Convert.ToString(row["UserName"]),
                                     Convert.ToInt32(row["Accsess"])
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

        public static UsersDTO LogInUser(string UserName, string PassWord)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_LogInUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@PassWord", PassWord);
                    try
                    {
                        connection.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            UsersDTO dto = null;
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    dto = new UsersDTO(Convert.ToInt32(row["ID"]),
                                     Convert.ToInt32(row["PersonID"]),
                                     Convert.ToString(row["PassWord"]),
                                     Convert.ToString(row["UserName"]),
                                     Convert.ToInt32(row["Accsess"])
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



        public static List<UsersDataGradeViewDTO> GetAllUsers()
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllUsers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<UsersDataGradeViewDTO> listdto = new List<UsersDataGradeViewDTO>();
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
                                    UsersDataGradeViewDTO dto = new UsersDataGradeViewDTO(Convert.ToInt32(row["ID"]),
                                     Convert.ToInt32(row["PersonID"]),
                                     Convert.ToString(row["UserName"]),
                                      Convert.ToString(row["FullName"]),
                                      Convert.ToString(row["Email"]),
                                       Convert.ToDateTime(row["BirthDate"]),
                                     Convert.ToBoolean(row["IsAdmin"])
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

        public static List<UsersDataGradeViewDTO> SearchingFilterUsers(int Num, string Text, string Filter)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_SerchingFilterUsers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<UsersDataGradeViewDTO> listdto = new List<UsersDataGradeViewDTO>();
                    command.Parameters.AddWithValue("@Num", Num);
                    command.Parameters.AddWithValue("@String", Text);
                    command.Parameters.AddWithValue("@SerchFilter", Filter);
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
                                    UsersDataGradeViewDTO dto = new UsersDataGradeViewDTO(Convert.ToInt32(row["ID"]),
                                     Convert.ToInt32(row["PersonID"]),
                                     Convert.ToString(row["UserName"]),
                                      Convert.ToString(row["FullName"]),
                                      Convert.ToString(row["Email"]),
                                       Convert.ToDateTime(row["BirthDate"]),
                                     Convert.ToBoolean(row["IsAdmin"])
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

