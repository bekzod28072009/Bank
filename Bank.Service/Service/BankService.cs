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
        private readonly BankRepository repository;
        public BankService()
        {
            repository = new BankRepository();
        }
        public void Add(BankNomi bank) 
        {
            repository.Add(bank);
        }

        public void GetAll()
        {
            repository.GetAll();
        }

        public void Delete(int Id)
        {
            repository.Delete(Id);
        }

        public void Update()
        {
            repository.Update();
        }
    }
}
