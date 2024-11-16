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

    public class ClientsDTO
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string PinCode { get; set; }
        public float Balanced { get; set; }
        public ClientsDTO(int ID, int PersonID, string PinCode, float Balanced)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.PinCode = PinCode;
            this.Balanced = Balanced;
        }
    }

    public class ClientsDataGradeViewDTO
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string FullName { get; set; }

        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public float Balanced { get; set; }
        public ClientsDataGradeViewDTO(int ID, int PersonID, string FullName, string Email, DateTime BirthDate, float Balanced)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.BirthDate = BirthDate;
            this.FullName = FullName;
            this.Email = Email;
            this.Balanced = Balanced;
        }
    }


    public class TotalBalancedDTO
    {
        public int ID { get; set; }

        public string FullName { get; set; }
        public float Balanced { get; set; }

        public TotalBalancedDTO(int ID, float Balanced, string FullName)
        {
            this.ID = ID;
            this.Balanced = Balanced;
            this.FullName = FullName;
        }
    }



    public class clsClientsData
    {

        public static int AddClients(ClientsDTO dto)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_AddClients", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter output = new SqlParameter("@ID", SqlDbType.Int);
                    output.Direction = ParameterDirection.Output;
                    command.Parameters.Add(output);
                    command.Parameters.AddWithValue("@PersonID", dto.PersonID);
                    command.Parameters.AddWithValue("@PinCode", dto.PinCode);
                    command.Parameters.AddWithValue("@Balanced", dto.Balanced);
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



        public static int DeleteClients(int ID)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_DeleteClients", connection))
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



        public static ClientsDTO UpDateClients(int ID, ClientsDTO dto)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_UpDateClients", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@PersonID", dto.PersonID);
                    command.Parameters.AddWithValue("@PinCode", dto.PinCode);
                    command.Parameters.AddWithValue("@Balanced", dto.Balanced);
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



        public static ClientsDTO FindClients(int ID)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_FindClients", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", ID);
                    try
                    {
                        connection.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            ClientsDTO dto = null; if (reader.HasRows)
                            {
                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    dto = new ClientsDTO(Convert.ToInt32(row["ID"]),
                                     Convert.ToInt32(row["PersonID"]),
                                     Convert.ToString(row["PinCode"]),
                                     Convert.ToInt32(row["Balanced"])
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

        public static ClientsDTO FindClientsByPersonID(int ID)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_FindClientByPersonID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", ID);
                    try
                    {
                        connection.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            ClientsDTO dto = null; if (reader.HasRows)
                            {
                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    dto = new ClientsDTO(Convert.ToInt32(row["ID"]),
                                     Convert.ToInt32(row["PersonID"]),
                                     Convert.ToString(row["PinCode"]),
                                     Convert.ToInt32(row["Balanced"])
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



        public static List<ClientsDataGradeViewDTO> GetAllClients()
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllClients", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<ClientsDataGradeViewDTO> listdto = new List<ClientsDataGradeViewDTO>();
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
                                    ClientsDataGradeViewDTO dto = new ClientsDataGradeViewDTO(Convert.ToInt32(row["ID"]),
                                     Convert.ToInt32(row["PersonID"]),
                                     Convert.ToString(row["FullName"]),
                                      Convert.ToString(row["Email"]),
                                       Convert.ToDateTime(row["BirthDate"]),
                                     Convert.ToInt32(row["Balanced"])
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


        public static List<ClientsDataGradeViewDTO> SerchingFilter(int Num, string Text, string Filter)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_SerchingFilterClients", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<ClientsDataGradeViewDTO> listdto = new List<ClientsDataGradeViewDTO>();
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
                                    ClientsDataGradeViewDTO dto = new ClientsDataGradeViewDTO(Convert.ToInt32(row["ID"]),
                                     Convert.ToInt32(row["PersonID"]),
                                     Convert.ToString(row["FullName"]),
                                      Convert.ToString(row["Email"]),
                                       Convert.ToDateTime(row["BirthDate"]),
                                     Convert.ToInt32(row["Balanced"])
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



        public static List<TotalBalancedDTO> GetTotalBalanced(ref float TotalBalanced)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_GetTotalMoney", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<TotalBalancedDTO> listdto = new List<TotalBalancedDTO>();
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
                                    TotalBalancedDTO dto = new TotalBalancedDTO(
                                     Convert.ToInt32(row["ClientID"]),
                                     float.Parse(row["Balanced"].ToString()),
                                     Convert.ToString(row["FullName"])
                                    );
                                    TotalBalanced += dto.Balanced;
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
