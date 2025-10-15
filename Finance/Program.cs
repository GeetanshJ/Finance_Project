using System;
using Underwriter;
using VehicleApp;
using admin;
namespace Project
{
    class Hello
    {
        public static void Main(string[] args)
        {
            int count = 000000;
            Auth(count);

        }
        public static void ShowAdminOptions(int count)
        {
            Admin admin = new Admin();
            int choice = 0;

            do
            {
                Console.WriteLine("\n--- Admin Menu ---");
                Console.WriteLine("1. Register/Create UnderWriter");
                Console.WriteLine("2. Search UnderWriter by Id");
                Console.WriteLine("3. Update UnderWriter Password");
                Console.WriteLine("4. Delete UnderWriter by Id");
                Console.WriteLine("5. View All UnderWriters");
                Console.WriteLine("6. View All Vehicles specific to UnderWriter Id");
                Console.WriteLine("7. Go back to User Role Choosing Screen");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        count++;
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Date of Birth (dd-MM-yyyy): ");
                        DateTime dob = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Enter Joining Date (dd-MM-yyyy): ");
                        DateTime joiningDate = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Enter Password: ");
                        string password = Console.ReadLine();

                        admin.CreateUnderWriter(count, name, dob, joiningDate, password);
                        break;

                    case 2:
                        Console.Write("Enter UnderWriter Id: ");
                        int searchId = int.Parse(Console.ReadLine());
                        admin.SearchUnderWriterById(searchId);
                        break;

                    case 3:
                        Console.Write("Enter UnderWriter Id: ");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Password: ");
                        string newPassword = Console.ReadLine();
                        admin.UpdateUnderWriterPassword(updateId, newPassword);
                        break;

                    case 4:
                        Console.Write("Enter UnderWriter Id to Delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        admin.DeleteUnderWriterById(deleteId);
                        break;

                    case 5:
                        admin.ViewAllUnderWriters();
                        break;

                    case 6:
                        Console.Write("Enter UnderWriter Id: ");
                        int UnderWriterId = int.Parse(Console.ReadLine());
                        admin.ViewVehiclesByUnderWriterId(UnderWriterId);
                        break;

                    case 7:
                        Console.WriteLine("Returning to User Role Choosing Screen...");
                        Auth(count);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (choice != 7);
            return;
        }

        public static void ShowUnderWriterOptions(int count)
        {
            UnderWriter UnderWriter = new UnderWriter();
            int choice = 0;

            do
            {
                Console.WriteLine("\n--- UnderWriter Menu ---");
                Console.WriteLine("1. Create a New Vehicle Insurance");
                Console.WriteLine("2. Renewal of a Policy");
                Console.WriteLine("3. Change Policy Type");
                Console.WriteLine("4. View All Vehicle Insurance Policies");
                Console.WriteLine("5. Go back to Role Choosing Menu");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Vehicle vehicle = new Vehicle();

                        Console.Write("Enter Vehicle No: ");
                        vehicle.vNo = Console.ReadLine();

                        Console.Write("Enter Vehicle Type \n choice 1 for 2 wheeler \n choice 2 for 4 wheeler : ");
                        int vchoice = int.Parse(Console.ReadLine());
                        if (vchoice == 1) vehicle.vType = "2-Wheeler";
                        else vehicle.vType = "4-Wheeler";

                        Console.Write("Enter Customer Name: ");
                        vehicle.custName = Console.ReadLine();

                        Console.Write("Enter Engine No: ");
                        vehicle.engNo = int.Parse(Console.ReadLine());

                        Console.Write("Enter Chasis No: ");
                        vehicle.chaNo = int.Parse(Console.ReadLine());

                        Console.Write("Enter Customer Phone No: ");
                        vehicle.phone = long.Parse(Console.ReadLine());

                        Console.Write("Enter Insurance Type (Full Insurance / Third Party): ");
                        vehicle.insType = Console.ReadLine();

                        Console.Write("Enter Premium Amount: ");
                        if (vchoice == 1) vehicle.premium = 2500;
                        else vehicle.premium = 6500;

                        Console.Write("Enter Policy Start Date (dd-MM-yyyy): ");
                        vehicle.fromDt = Convert.ToDateTime(Console.ReadLine());

                        Console.Write("Enter Policy End Date (dd-MM-yyyy): ");
                        vehicle.toDt = Convert.ToDateTime(Console.ReadLine());

                        Console.Write("Enter Your UnderWriter Id: ");
                        vehicle.uwId = Console.ReadLine();

                        // Pass this object to the method
                        UnderWriter.CreateVehicleInsurance(vehicle);
                        break;


                    case 2:
                        Console.Write("Enter Vehicle Id for Renewal: ");
                        int renewId = int.Parse(Console.ReadLine());
                        UnderWriter.RenewPolicy(renewId);
                        break;

                    case 3:
                        Console.Write("Enter Vehicle Id to Change Policy Type: ");
                        int changeId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Policy Type (Full/Third Party): ");
                        string newType = Console.ReadLine();
                        UnderWriter.ChangePolicyType(changeId, newType);
                        break;

                    case 4:
                        UnderWriter.ViewAllPolicies();
                        break;

                    case 5:
                        Console.WriteLine("Returning to Role Choosing Menu...");
                        Auth(count);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (choice != 5);
        }


        public static void Auth(int count)
        {
            int adminId = 259286;
            string adminPassword = "admin123";
            Console.WriteLine("Please Select your choice to login\n 1 for Admin \n 2 for UnderWriter");
            int choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                Console.WriteLine("Enter Your Admin Id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your Passoword");
                string password = Console.ReadLine();

                if (id == adminId && adminPassword.Equals(password))
                {
                    Console.WriteLine("Logged in Successfully");
                    ShowAdminOptions(count);
                }
                else
                {
                    Console.WriteLine("Entered Wrong Details");
                    Auth(count);
                }
            }
            else
            {
                Console.WriteLine("Enter your UnderWriter ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your Password: ");
                string password = Console.ReadLine();

                UnderWriter underWriter = new UnderWriter();
                if (underWriter.UnderWriterId == id && password.Equals(underWriter.password))
                {
                    Console.WriteLine("Logged in Successfully");
                    ShowUnderWriterOptions(count);
                } else
                {
                    Console.WriteLine("Entered Wrong Details");
                    Auth(count);
                }
            }
        }
    }
}

