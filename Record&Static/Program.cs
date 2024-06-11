using System;

namespace Record_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[3];
            int userCount = 0;
            while (userCount < users.Length)
            {
                Console.WriteLine("Zehmet olmasa email daxil edin:");
                string email = Console.ReadLine();
                Console.WriteLine("Zehmet olmasa şifrəni daxil edin:");
                string password = Console.ReadLine();
                Console.WriteLine("Zehmet olmasa Fullname daxil edin:");
                string fullName = Console.ReadLine();

                users[userCount] = new User(email, password, fullName);
                userCount++;
                Console.WriteLine("Istifadeci elave olundu");
            }
            while (true)
            {
                Console.WriteLine
                    ("1.Show all users \n" +
                     "2.Get info by id\n" +
                     "0.Quit");

                int command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("All users:");
                        for (int i = 0; i < userCount; i++)
                        {
                            users[i].GetInfo();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Id daxil edin");
                        int id = Convert.ToInt32(Console.ReadLine());
                        int index = User.FindByID(users, id);
                        if (index != -1)
                        {
                            users[index].GetInfo();
                        }
                        else
                        {
                            Console.WriteLine("Bele istifadeci movcud deyil");
                        }
                        break;
                    default:
                        Console.WriteLine("Zehmet olmasa duzgun komanda daxil edin");
                        break;
                }
            }
        }
    }
}
