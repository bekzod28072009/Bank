





using Bank.Domain.Bank;
using Bank.Service.Service;

Users users = new Users();

BankNomi bank = new BankNomi();

UsersService usersService = new UsersService();
BankService bankService = new BankService();

Console.Write("Id : ");
int Id = int.Parse(Console.ReadLine());
Console.Write("Name : ");
string Name = Console.ReadLine();
Console.Write("Familiya : ");
string Fam = Console.ReadLine();
Console.Write("Bank Nomi : ");
string Bank =  Console.ReadLine();
Console.WriteLine("Shot : ");
int Shot  = int.Parse(Console.ReadLine());

Users users1 = new Users()
{
    Id = Id,
    Name = Name,
    Familiya = Fam,
    BankName = Bank,
    Shot = Shot
};

foreach (var i in users)
{

}