using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer_BankProjectServerSide.Others
{
    public class clsAccessSetting
    {
        public static string Server()
        {
            return "server=.;database=DBBankProject;user id=sa;password=sa123456;Encrypt=False;TrustServerCertificate=True;Connection Timeout=30;";
        }
    }
}
