using DataAccesslayer_BankProjectServerSide.Others;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer_BankProjectServerSide.LogginData
{
    public class LoginIDDTO
    {
        public int LoginID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public DateTime LoginDate { get; set; }
        public bool IsDone { get; set; }
        public LoginIDDTO(int LoginID, int UserID, string UserName, DateTime LoginDate, bool IsDone)
        {
            this.LoginID = LoginID;
            this.UserID = UserID;
            this.UserName = UserName;
            this.LoginDate = LoginDate;
            this.IsDone = IsDone;
        }
    }

    public class clsUserLogData
    {

        public static List<LoginIDDTO> GetAllLoginID()
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllLoginID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<LoginIDDTO> listdto = new List<LoginIDDTO>();
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
                                    LoginIDDTO dto = new LoginIDDTO(Convert.ToInt32(row["LoginID"]),
                                     Convert.ToInt32(row["UserID"]),
                                     Convert.ToString(row["UserName"]),
                                     Convert.ToDateTime(row["LoginDate"]),
                                     Convert.ToBoolean(row["IsDone"])
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

        public static List<LoginIDDTO> SerchingLoggin(int Num, string Text, string Filter, DateTime StartTime, DateTime EndTime)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_SerchingLogingUsers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<LoginIDDTO> listdto = new List<LoginIDDTO>();
                    command.Parameters.AddWithValue("@Num", Num);
                    command.Parameters.AddWithValue("@String", Text);
                    command.Parameters.AddWithValue("@SerchFilter", Filter);
                    command.Parameters.AddWithValue("@StartDate", StartTime);
                    command.Parameters.AddWithValue("@EndDate", EndTime);
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
                                    LoginIDDTO dto = new LoginIDDTO(Convert.ToInt32(row["LoginID"]),
                                     Convert.ToInt32(row["UserID"]),
                                     Convert.ToString(row["UserName"]),
                                     Convert.ToDateTime(row["LoginDate"]),
                                     Convert.ToBoolean(row["IsDone"])
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



        public static int AddLoginID(LoginIDDTO dto)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_AddLoginID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter output = new SqlParameter("@LoginID", SqlDbType.Int);
                    output.Direction = ParameterDirection.Output;
                    command.Parameters.Add(output);
                    command.Parameters.AddWithValue("@UserID", dto.UserID);
                    command.Parameters.AddWithValue("@UserName", dto.UserName);
                    command.Parameters.AddWithValue("@LoginDate", dto.LoginDate);
                    command.Parameters.AddWithValue("@IsDone", dto.IsDone);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        return Convert.ToInt32(command.Parameters["@LoginID"].Value);
                    }
                    catch (Exception ex)
                    {
                        return 0;
                    }
                }
            }
            return 0;
        }


    }
}
