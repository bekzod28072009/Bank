using Bank.DataAcces.Repository;
using Bank.Domain.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service.Service
{
    public class UsersService
    {
        public void Add(Users users) 
        {
            UsersRepository.Add(users);
        }

        public void GetAll()
        {
            UsersRepository.GetAll(); 
        }

        public void Delete(int Id) 
        {
            UsersRepository.Delete(Id);
        }
        public void Update()
        {
            UsersRepository.Update();
        }
    }
}
