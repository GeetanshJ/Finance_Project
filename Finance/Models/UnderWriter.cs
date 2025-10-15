namespace FinanceApp
{
    public class Underwriter : User
    {
        public int underwriterId { get; set; }    // Auto-generated 
        public string name { get; set; }         // From console
        public DateTime dob { get; set; }        // From console
        public DateTime joiningDate { get; set; } // System date
        public string password { get; set; }     // From console

        //  Constructor
        public Underwriter(string name, DateTime dob, string password)
        {
            this.name = name;
            this.dob = dob;      
            this.password = password;

            // Auto capture system date for joining
            joiningDate = DateTime.Now;
        }
    }
}
