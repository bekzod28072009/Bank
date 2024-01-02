using Bank.Domain.Bank;
using Bank.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Generic
{
    public  class Shell
    {
        public static async void Generic()
        {
            UsersService usersService = new UsersService();
            Console.WriteLine("1 - Users.");
            Console.WriteLine("2 - BankCard");
            int a = int.Parse(Console.ReadLine());
            switch(a)
            {
                // ------------- For Users --------------------
                case 1:
                    {
                        Console.WriteLine("1 - Add Users.");
                        Console.WriteLine("2 - Get List of Users.");
                        Console.WriteLine("3 - Delete Users.");
                        Console.WriteLine("4 - Update Users.");
                        int a1 = int.Parse(Console.ReadLine());
                        switch(a1)
                        {
                            // Function Add ---------------<>
                            case 1:
                                {
                                    Console.WriteLine("Siz Userlar qoshish joyidasiz. \n\n");
                                    Console.Write("Id kirting : ");
                                    int Id = int.Parse(Console.ReadLine());
                                    Console.Write("Ismingizni kirting : ");
                                    string Name = Console.ReadLine();
                                    Console.Write("Familiya kirting : ");
                                    string Fam = Console.ReadLine();
                                    Console.Write("Qaysi bankga ulanmoqchisiz ?! : ");
                                    string BankName = Console.ReadLine();
                                    Console.Write("Hisobingizni toldiring : ");
                                    int Shot = int.Parse(Console.ReadLine());

                                    Users users = new Users()
                                    {
                                        Id = Id,
                                        Name = Name,
                                        Familiya = Fam,
                                        BankName = BankName, 
                                        Shot = Shot
                                    };

                                    usersService.Add(users);
                                    Console.Clear();
                                    Console.WriteLine("Qoshildi !!!");
                                    break;
                                }
                            // Function GetAll ------------<>
                            case 2:
                                {
                                    Console.WriteLine("Siz Userlar olish joyidasiz .\n");
                                    string a2 = Console.ReadLine();
                                    switch(a2)
                                    {
                                        case "select * from users":
                                            {
                                                usersService.GetAll();
                                                break;
                                            }
                                    }
                                    break;
                                }
                            // Delete Function ------------<>
                            case 3:
                                {
                                    Console.WriteLine("Siz Userslar ochirish jayidasiz. \n\n");

                                    usersService.GetAll();
                                    Console.WriteLine("\nQaysi userni ochirmiqchisiz ?");
                                    
                                    string a3 = Console.ReadLine();
                                    int Id;

                                    if (a3 == $"delete users where Id = {Id = int.Parse(Console.ReadLine())}")
                                    {
                                        usersService.Delete(Id);
                                        Console.WriteLine("Ochirildi!");
                                        break;
                                    }
                                    break;
                                }
                            //  Update Function -----------<>
                            case 4:
                                {
                                    Console.WriteLine("Siz Userslarni Update qilish joyidasiz.");

                                    usersService.GetAll();
                                    Console.WriteLine("\nQaysi userni malummotlarini update qilmoqchisiz.");

                                    string update = Console.ReadLine();

                                    int Id;
                                    string Name;
                                    string Familiya;
                                    string BankName;
                                    int Shot;

                                    if(update == $"update users Set name = '{Name = Console.ReadLine()}', familiya = '{Familiya = Console.ReadLine()}', bankname = '{BankName = Console.ReadLine()}', shot = '{Shot = int.Parse(Console.ReadLine())}' where Id = {Id = int.Parse(Console.ReadLine())}")
                                    {
                                        usersService.Update();

                                    }
                                    break;
                                }
                        }
                        break;
                    }




                    // --------------- For BankCard ---------------------
                    case 2:
                    {
                        break;
                    }

            }
        }
    }
}
