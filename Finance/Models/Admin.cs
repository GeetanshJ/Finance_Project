using System;
using VehicleApp;
using Underwriter;
namespace admin
{
    public class Admin
    {
        // List to store all UnderWriters
        private static List<UnderWriter> underWriters = new List<UnderWriter>();

        // ✅ 1. Create UnderWriter
        public void CreateUnderWriter(int id, string name, DateTime dob, DateTime joiningDate, string password)
        {
            UnderWriter uw = new UnderWriter(
                id,
                name = name,
                dob = dob,
                joiningDate = joiningDate,
                password = password
            );

            underWriters.Add(uw);
            Console.WriteLine($"✅ UnderWriter '{name}' (ID: {id}) added successfully!\n");
        }

        // ✅ 2. Search UnderWriter by ID
        public void SearchUnderWriterById(int id)
        {
            UnderWriter uw = underWriters.Find(u => u.UnderWriterId == id);
            if (uw != null)
            {
                Console.WriteLine($"--- UnderWriter Found ---");
                Console.WriteLine($"ID: {uw.UnderWriterId}");
                Console.WriteLine($"Name: {uw.name}");
                Console.WriteLine($"DOB: {uw.dob:dd-MM-yyyy}");
                Console.WriteLine($"Joining Date: {uw.joiningDate:dd-MM-yyyy}");
                Console.WriteLine($"Password: {uw.password}");
            }
            else
            {
                Console.WriteLine($"❌ UnderWriter with ID {id} not found.\n");
            }
        }

        // ✅ 3. Update UnderWriter Password
        public void UpdateUnderWriterPassword(int id, string newPassword)
        {
            UnderWriter uw = underWriters.Find(u => u.UnderWriterId == id);
            if (uw != null)
            {
                uw.password = newPassword;
                Console.WriteLine($"🔑 Password updated successfully for ID {id}.\n");
            }
            else
            {
                Console.WriteLine($"❌ UnderWriter with ID {id} not found.\n");
            }
        }

        // ✅ 4. Delete UnderWriter by ID
        public void DeleteUnderWriterById(int id)
        {
            UnderWriter uw = underWriters.Find(u => u.UnderWriterId == id);
            if (uw != null)
            {
                underWriters.Remove(uw);
                Console.WriteLine($"🗑️ UnderWriter with ID {id} deleted successfully.\n");
            }
            else
            {
                Console.WriteLine($"❌ UnderWriter with ID {id} not found.\n");
            }
        }

        // ✅ 5. View All UnderWriters
        public void ViewAllUnderWriters()
        {
            if (underWriters.Count == 0)
            {
                Console.WriteLine("⚠️ No UnderWriters found in the system.\n");
                return;
            }

            Console.WriteLine("--- List of All UnderWriters ---");
            foreach (UnderWriter uw in underWriters)
            {
                Console.WriteLine($"ID: {uw.UnderWriterId}, Name: {uw.name}, DOB: {uw.dob:dd-MM-yyyy}, Joining: {uw.joiningDate:dd-MM-yyyy}");
            }
            Console.WriteLine();
        }

        // ✅ 6. View All Vehicles specific to UnderWriter Id
        public void ViewVehiclesByUnderWriterId(int underwriterId)
        {
            // For now, since you have a separate Vehicle class, 
            // you can later connect it here.
            Console.WriteLine($"🚗 Displaying all vehicles linked to UnderWriter ID: {underwriterId}");
            Console.WriteLine("➡️ (This will show vehicle data once linked to the database or list.)\n");
        }
    }
}
