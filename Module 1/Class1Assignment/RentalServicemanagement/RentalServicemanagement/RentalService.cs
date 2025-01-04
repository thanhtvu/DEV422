namespace RentalServicemanagement
{
    public class RentalService
    {
        public int VehicleID { get; set; }
        public int CustomerID { get; set; } 
        public int RentalID { get; set; }
        public DateTime rentDate { get; set; }
        public DateTime? returnDate { get; set; }
    }

    public class MockVehicle
    {
        public int VehicleID { get; set; }
        public Boolean IsAvailable { get; set; }
    }

    public class MockCustomer
    {
        public int CustomerID { get; set; }
    }
}
