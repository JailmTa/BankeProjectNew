using DataAccsessLayer_BankClientSidev2.LogginData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnessLayer_BankProjectv2.LogginLogic
{
    public class clsUserLogLogic
    {

        public static async Task<List<LoginIDDTO>> GetAllUsersLog()
        {
            return await clsUserLogData.GetAllLoginID();
        }

        public static async Task<int> AddNewUserLog(LoginIDDTO dto)
        {
            return await clsUserLogData.AddNewLoginID(dto);
        }

        public static async Task<List<LoginIDDTO>> SearchingLoggin(int Num, string Text, string Filter, DateTime StartTime, DateTime EndTime)
        {
            return await clsUserLogData.SerchinfLoggin(Num, Text, Filter, StartTime, EndTime);
        }

    }
}
