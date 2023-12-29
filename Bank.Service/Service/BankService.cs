using Bank.DataAcces.Repository;
using Bank.Domain.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service.Service
{
    public class BankService
    {
        public void Add(BankNomi bank) 
        {
            BankRepository.Add(bank);
        }

        public void GetAll()
        {
            BankRepository.GetAll();
        }

        public void Delete(int Id)
        {
            BankRepository.Delete(Id);
        }

        public void Update()
        {
            BankRepository.Update();
        }
    }
}
