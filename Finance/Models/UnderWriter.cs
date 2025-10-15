using VehicleApp;

namespace Underwriter
{
    public class UnderWriter
    {
        public int UnderWriterId { get; set; }    // Auto-generated 
        public string name { get; set; }         // From console
        public DateTime dob { get; set; }        // From console
        public DateTime joiningDate { get; set; } // System date
        public string password { get; set; }     // From console

        //  Constructor
        public UnderWriter()
        {
            
        }
        public UnderWriter(int id, string name, DateTime dob, DateTime joiningDate, string password)
        {
            this.UnderWriterId = id;
            this.name = name;
            this.dob = dob;
            this.password = password;

            // Auto capture system date for joining
            this.joiningDate = joiningDate;
        }
        // Simulated database of vehicles
        private static List<Vehicle> vehicleList = new List<Vehicle>();

        // Create a new Vehicle Insurance
        public void CreateVehicleInsurance(Vehicle vehicle)
        {
            // Simulate DB auto increment
            vehicle.policyNo = vehicleList.Count + 1;

            // Add to our list
            vehicleList.Add(vehicle);

            Console.WriteLine("\n Vehicle Insurance Created Successfully!");
            Console.WriteLine($"Policy No: {vehicle.policyNo}");
            Console.WriteLine($"Vehicle No: {vehicle.vNo}");
            Console.WriteLine($"Customer: {vehicle.custName}");
            Console.WriteLine($"Insurance Type: {vehicle.insType}");
            Console.WriteLine($"Premium: {vehicle.premium}");
            Console.WriteLine($"Valid From: {vehicle.fromDt:dd-MM-yyyy} To {vehicle.toDt:dd-MM-yyyy}");
        }

        // 2️⃣ Renewal of a Policy
        public void RenewPolicy(int policyNo)
        {
            Vehicle vehicle = vehicleList.Find(v => v.policyNo == policyNo);

            if (vehicle != null)
            {
                Console.WriteLine($"Current Policy End Date: {vehicle.toDt:dd-MM-yyyy}");
                Console.Write("Enter New End Date (dd-MM-yyyy): ");
                DateTime newEndDate = Convert.ToDateTime(Console.ReadLine());

                vehicle.fromDt = DateTime.Now;
                vehicle.toDt = newEndDate;

                Console.WriteLine("Policy renewed successfully!");
                Console.WriteLine($"New Validity: {vehicle.fromDt:dd-MM-yyyy} To {vehicle.toDt:dd-MM-yyyy}");
            }
            else
            {
                Console.WriteLine("Policy not found with the given Policy No.");
            }
        }

        // 3️⃣ Change Policy Type (Full ↔ Third Party)
        public void ChangePolicyType(int policyNo, string newType)
        {
            Vehicle vehicle = vehicleList.Find(v => v.policyNo == policyNo);

            if (vehicle != null)
            {
                Console.WriteLine($"Current Policy Type: {vehicle.insType}");
                vehicle.insType = newType;
                Console.WriteLine($"✅ Policy Type Updated Successfully to {vehicle.insType}");
            }
            else
            {
                Console.WriteLine("❌ Policy not found with the given Policy No.");
            }
        }

        // 4️⃣ View All Vehicle Insurance Policies
        public void ViewAllPolicies()
        {
            if (vehicleList.Count == 0)
            {
                Console.WriteLine("No policies found in the system.");
                return;
            }

            Console.WriteLine("\n--- All Vehicle Insurance Policies ---");
            foreach (var v in vehicleList)
            {
                Console.WriteLine($"\nPolicy No: {v.policyNo}");
                Console.WriteLine($"Vehicle No: {v.vNo}");
                Console.WriteLine($"Vehicle Type: {v.vType}");
                Console.WriteLine($"Customer Name: {v.custName}");
                Console.WriteLine($"Engine No: {v.engNo}");
                Console.WriteLine($"Chasis No: {v.chaNo}");
                Console.WriteLine($"Phone: {v.phone}");
                Console.WriteLine($"Insurance Type: {v.insType}");
                Console.WriteLine($"Premium: {v.premium}");
                Console.WriteLine($"From: {v.fromDt:dd-MM-yyyy} To: {v.toDt:dd-MM-yyyy}");
                Console.WriteLine($"UnderWriter ID: {v.uwId}");
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}