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
        private readonly UsersRepository repository;
        public UsersService()
        {
            repository = new UsersRepository();
        }
        public void Add(Users users) 
        {
            repository.Add(users);
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
