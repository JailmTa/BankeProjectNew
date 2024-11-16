using DataAccsessLayer_BankClientSidev2.TransactionData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnessLayer_BankProjectv2.TransactionLogic
{
    public class clsTransactionLogic
    {

        public static async Task<int> DepositMoney(int ID, float Money)
        {
            return await clsTrancationData.DepositMoney(ID, Money);
        }

        public static async Task<int> WithDrawMoney(int ID, float Money)
        {
            return await clsTrancationData.WithdrawMoney(ID, Money);
        }

        public static async Task<int> Transferm(int FirstAcc, int SecondAcc, float Money)
        {
            int CanITransferm = await clsTrancationData.WithdrawMoney(FirstAcc, Money);
            if (CanITransferm != 0)
            {
                await clsTrancationData.DepositMoney(SecondAcc, Money);
                return CanITransferm;
            }
            else
            {
                return 0;
            }
        }

    }
}
