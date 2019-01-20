using banking_logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_logic
{
    public class UserModel
    {
        public string userName { get; set; }
        public AccountModel regularAccount { get; set; }
    }
}
