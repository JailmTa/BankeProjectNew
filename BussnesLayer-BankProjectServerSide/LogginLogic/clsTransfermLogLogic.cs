using DataAccesslayer_BankProjectServerSide.LogginData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnesLayer_BankProjectServerSide.LogginLogic
{
    public class clsTransfermLogLogic
    {

        public static List<TransfermLogDTO> GetAllLoges()
        {
            return clsTransfermLogData.GetAllTransfermLog();
        }

        public static int AddNewTransferm(TransfermLogDTO dto)
        {
            return clsTransfermLogData.AddTransfermLog(dto);
        }

        public static List<TransfermLogDTO> SerchingLoggin(int Num, string Text, string Filter, DateTime StartTime, DateTime EndTime)
        {
            return clsTransfermLogData.SerchingLoggin(Num, Text, Filter, StartTime, EndTime);
        }

    }
}
