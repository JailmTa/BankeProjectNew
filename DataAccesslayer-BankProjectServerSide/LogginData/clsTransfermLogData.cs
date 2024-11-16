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
    public class TransfermLogDTO
    {
     
            public int TransferID { get; set; }
            public int FirstAccount { get; set; }
            public string FirstName { get; set; }
            public int SecondAccount { get; set; }
            public string SecondName { get; set; }
            public DateTime TransferredDate { get; set; }
            public float TransferredMoney { get; set; }
        

        public TransfermLogDTO(int TransferID, int FirstAccount, string FirstName, int SecondAccount, string SecondName, float TransferredMoney, DateTime TransferredDate)
        {
            this.TransferID = TransferID;
            this.FirstAccount = FirstAccount;
            this.FirstName = FirstName;
            this.SecondAccount = SecondAccount;
            this.SecondName = SecondName;
            this.TransferredDate = TransferredDate;
            this.TransferredMoney = TransferredMoney;
        }

    }


    public class clsTransfermLogData
    {


        public static List<TransfermLogDTO> GetAllTransfermLog()
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllTransfermLog", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<TransfermLogDTO> listdto = new List<TransfermLogDTO>();
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
                                    TransfermLogDTO dto = new TransfermLogDTO(
                                     Convert.ToInt32(row["TransfermID"]),
                                     Convert.ToInt32(row["FirstAccount"]),
                                     Convert.ToString(row["FirstName"]),
                                     Convert.ToInt32(row["SecoundAccount"]),
                                     Convert.ToString(row["SecoundName"]),
                                     float.Parse(row["TransfermedMoney"].ToString()),
                                     Convert.ToDateTime(row["DateLog"])
                                    
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

        public static List<TransfermLogDTO> SerchingLoggin(int Num, string Text, string Filter, DateTime StartTime, DateTime EndTime)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_SerchingTransfermLog", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<TransfermLogDTO> listdto = new List<TransfermLogDTO>();
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
                                    TransfermLogDTO dto = new TransfermLogDTO(
                                     Convert.ToInt32(row["TransfermID"]),
                                     Convert.ToInt32(row["FirstAccount"]),
                                     Convert.ToString(row["FirstName"]),
                                     Convert.ToInt32(row["SecoundAccount"]),
                                     Convert.ToString(row["SecoundName"]),
                                     float.Parse(row["TransfermedMoney"].ToString()),
                                     Convert.ToDateTime(row["DateLog"])
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

        public static int AddTransfermLog(TransfermLogDTO dto)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_AddTransfermLog", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter output = new SqlParameter("@TransfermID", SqlDbType.Int);
                    output.Direction = ParameterDirection.Output;
                    command.Parameters.Add(output);
                    command.Parameters.AddWithValue("@FirstAccount", dto.FirstAccount);
                    command.Parameters.AddWithValue("@FirstName", dto.FirstName);
                    command.Parameters.AddWithValue("@SecoundAccount", dto.SecondAccount);
                    command.Parameters.AddWithValue("@SecoundName", dto.SecondName);
                   
                    command.Parameters.AddWithValue("@TransfermedMoney", dto.TransferredMoney);
                    command.Parameters.AddWithValue("@Date", dto.TransferredDate);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        return Convert.ToInt32(command.Parameters["@TransfermID"].Value);
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
