using DataAccesslayer_BankProjectServerSide.Others;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer_BankProjectServerSide.CountriesData
{
    public class CountryCurrencyDTO
    {
        public string CountryName { get; set; }

        public string CurrencyCode { get; set; }

        public string CurrencyName { get; set; }

        public float ExchangeRate { get; set; }


        public CountryCurrencyDTO(string CountryName, string CurrencyCode, string CurrencyName, float ExchangeRate)
        {
            this.CountryName = CountryName;
            this.CurrencyCode = CurrencyCode;
            this.CurrencyName = CurrencyName;
            this.ExchangeRate = ExchangeRate;

        }
    }

    public class clsCountryCurrencyData
    {

        public static List<CountryCurrencyDTO> GetAllCountries()
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllCountryCurrency", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<CountryCurrencyDTO> listdto = new List<CountryCurrencyDTO>();
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
                                    CountryCurrencyDTO dto = new CountryCurrencyDTO(
                                        Convert.ToString(row["CountryName"]),
                                        Convert.ToString(row["CurrencyCode"]),
                                        Convert.ToString(row["CurrencyName"]),
                                        float.Parse(row["ExchangeRate"].ToString())
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



        public static CountryCurrencyDTO FindCurrency(string ID)
        {
            using (SqlConnection connection = new SqlConnection(clsAccessSetting.Server()))
            {
                using (SqlCommand command = new SqlCommand("SP_FindCurrency", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", ID);
                    try
                    {
                        connection.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            CountryCurrencyDTO dto = null; if (reader.HasRows)
                            {
                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    dto = new CountryCurrencyDTO(
                                        Convert.ToString(row["CountryName"]),
                                        Convert.ToString(row["CurrencyCode"]),
                                        Convert.ToString(row["CurrencyName"]),
                                        float.Parse(row["ExchangeRate"].ToString())
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



    }
}
