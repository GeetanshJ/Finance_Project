using System;
namespace Project
{
    class Hello
    {
        public static void Main(string[] args)
        {
            int adminId = 259286;
            string adminPassword = "Hello guys";
            bool isAdminLogIn = false;

            Console.WriteLine("Please Select your choice to login\n 1 for Admin \n 2 for Underwriter");
            int choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                while (!isAdminLogIn)
                {
                    Console.WriteLine("Enter Your Admin Id");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Your Passoword");
                    string password = Console.ReadLine();

                    if (id == adminId && adminPassword.Equals(password))
                    {
                        Console.WriteLine("Logged in Successfully");
                        isAdminLogIn = true;
                    }
                    else
                    {
                        Console.WriteLine("Entered Wrong Details");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please Select your choice \n 1 for Sign up \n 2 for Log in");
                int choice1 = int.Parse(Console.ReadLine());

                if(choice1 == 1)
                {
                    
                }
            }

        }
    }
}

