using DataAccesslayer_BankProjectServerSide.LogginData;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnesLayer_BankProjectServerSide.LogginLogic
{
    public class clsUserLogLogic
    {
        public static List<LoginIDDTO> GetAllUsersLog()
        {
            return clsUserLogData.GetAllLoginID();
        }

        public static int AddNewLogUser(LoginIDDTO loginID)
        {
            return clsUserLogData.AddLoginID(loginID);
        }

        public static List<LoginIDDTO> SerchingLoggin(int Num, string Text, string Filter, DateTime StartTime, DateTime EndTime)
        {
            return clsUserLogData.SerchingLoggin(Num, Text, Filter, StartTime, EndTime);
        }

    }
}
