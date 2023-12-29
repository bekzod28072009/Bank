using Bank.DataAcces.IRepository;
using Bank.Domain.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DataAcces.Repository
{
    public static class UsersRepository
    {
        public static void  Add(Users users) 
        {
            IUserRepository.Insert(users.Id, users.Name, users.Familiya, users.BankName, users.Shot);
        }

        public static void GetAll()
        {
            IUserRepository.GetAll();
        }

        public static void Delete(int id)
        {
            IUserRepository.Delete(id);
        }

        public static void Update()
        {
            IUserRepository.Update();
        }
    }
}
