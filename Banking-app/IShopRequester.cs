using banking_logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_app
{
    public interface IShopRequester
    {
        void userEntered(UserModel user);
    }
}
