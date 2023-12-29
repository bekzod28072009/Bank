using Bank.DataAcces.IRepository;
using Bank.Domain.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DataAcces.Repository
{
    public static class BankRepository
    {

        public static void Add(BankNomi bankNomi)
        {
            IBankRepository.Insert(bankNomi.Id, bankNomi.Name, bankNomi.Yil);
        }

        public static void GetAll()
        {
            IBankRepository.GetAll();
        }

        public static void Delete(int id)
        {
            IBankRepository.Delete(id);
        }

        public static void Update()
        {
            IBankRepository.Update();
        }
    }
}
