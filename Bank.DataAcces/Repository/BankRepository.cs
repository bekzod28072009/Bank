using Bank.DataAcces.IRepository;
using Bank.Domain.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DataAcces.Repository
{
    public class BankRepository
    {

        public void Add(BankNomi bankNomi)
        {
            IBankRepository.Insert(bankNomi.Id, bankNomi.Name, bankNomi.Yil);
        }

        public void GetAll()
        {
            IBankRepository.GetAll();
        }

        public void Delete(int id)
        {
            IBankRepository.Delete(id);
        }

        public void Update()
        {
            IBankRepository.Update();
        }
    }
}
