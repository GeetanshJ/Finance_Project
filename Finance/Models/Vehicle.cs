namespace VehicleApp
{
    class Vehicle
    {
        // Fields / Properties
        public int policyNo { get; set; }       // Auto Incremented (DB will handle)
        public string vNo { get; set; }         // Vehicle No
        public string vType { get; set; }       // Vehicle Type
        public string custName { get; set; }    // Customer Name
        public int engNo { get; set; }          // Engine No
        public int chaNo { get; set; }          // Chasis No
        public long phone { get; set; }         // Phone No
        public string insType { get; set; }     // Full Insurance / Third Party
        public double premium { get; set; }     // Premium Amount
        public DateTime fromDt { get; set; }    // From Date
        public DateTime toDt { get; set; }      // To Date
        public string uwId { get; set; }        // Underwriter Id

        // ✅ Constructor
        public Vehicle(string vNo, string vType, string custName,
                       int engNo, int chaNo, long phone, string insType,
                       DateTime fromDt, string uwId)
        {
            this.vNo = vNo;
            this.vType = vType;
            this.custName = custName;
            this.engNo = engNo;
            this.chaNo = chaNo;
            this.phone = phone;
            this.insType = insType;
            this.fromDt = fromDt;
            this.uwId = uwId;

            // Auto calculate Premium Amount based on VehicleType
            if (vType.Equals("2-wheeler", StringComparison.OrdinalIgnoreCase))
                premium = 2500;
            else if (vType.Equals("4-wheeler", StringComparison.OrdinalIgnoreCase))
                premium = 6500;
            else
                premium = 0;

            // Auto calculate ToDate
            toDt = fromDt.AddDays(365);
        }
    }
}
