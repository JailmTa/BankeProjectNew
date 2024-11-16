using DataAccsessLayer_BankClientSidev2.PersonTypesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProjectClientSidev2.Classes
{
    public class clsCurrentUserInfo
    {
        public static UsersDTO Users { get; set; }

        public clsCurrentUserInfo(UsersDTO users)
        {
            Users = users;
        }
    }
}
