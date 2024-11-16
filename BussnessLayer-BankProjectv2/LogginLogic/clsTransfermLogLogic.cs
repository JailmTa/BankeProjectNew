using DataAccsessLayer_BankClientSidev2.LogginData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnessLayer_BankProjectv2.LogginLogic
{
    public class clsTransfermLogLogic
    {
        public static async Task<List<TransfermLogDTO>> GetTransfermLog()
        {
            return await clsTransfermLogData.GetAllTransfermLog();
        }

        public static async Task<int> AddTransferm(TransfermLogDTO dto)
        {
            return await clsTransfermLogData.AddNewTransfermLog(dto);
        }

        public static async Task<List<TransfermLogDTO>> SearchingLoggin(int Num, string Text, string Filter, DateTime StartTime, DateTime EndTime)
        {
            return await clsTransfermLogData.SerchinfLoggin(Num, Text, Filter, StartTime, EndTime);
        }

    }
}
