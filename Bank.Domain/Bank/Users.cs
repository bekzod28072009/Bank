using Bank.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Domain.Bank
{
    public class Users : Auditable
    {
        public string Name { get; set; }

        public string Familiya { get; set; }

        public string BankName { get; set; }

        public int Shot { get; set; }
    }
}
