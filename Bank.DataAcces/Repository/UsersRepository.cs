using Bank.DataAcces.IRepository;
using Bank.Domain.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DataAcces.Repository
{
    public class UsersRepository
    {
        public void  Add(Users users) 
        {
            IUserRepository.Insert(users.Id, users.Name, users.Familiya, users.BankName, users.Shot);
        }

        public void GetAll()
        {
            IUserRepository.GetAll();
        }

        public void Delete(int id)
        {
            IUserRepository.Delete(id);
        }

        public void Update()
        {
            IUserRepository.Update();
        }
    }
}
