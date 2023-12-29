using Bank.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Domain.Bank
{
    public class BankNomi : Auditable
    {
        public string Name { get; set; }

        public int Yil { get; set; }
    }
}
