using Microsoft.AspNetCore.Mvc;

namespace RentalServicemanagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class RentalServiceController : ControllerBase
    {
        // Create the list Vehicles
        private static List<MockVehicle> Vehicles = new List<MockVehicle>();
        private static List<MockCustomer> Customers = new List<MockCustomer>();
        private static List<RentalService> Rentals = new List<RentalService>();

        private static int RentalId = 0;

        // Rent a vehicle
        [HttpPost]
        public ActionResult RentVehicle(int vehicleId, int customerId)
        {
            var vehicle = Vehicles.FirstOrDefault(v => v.VehicleID == vehicleId);
            var customer = Customers.FirstOrDefault(c => c.CustomerID == customerId);

            if (vehicle != null && customer != null)
            {
                if (vehicle.IsAvailable)
                {
                    vehicle.IsAvailable = false;
                    var rental = new RentalService
                    {
                        VehicleID = vehicleId,
                        CustomerID = customerId,
                        RentalID = RentalId,
                        rentDate = new DateTime(),
                        returnDate = null,
                    };

                    Rentals.Add(rental);
                    RentalId++;
                    return Ok("Vehicle is rented successfully!");
                }
            }

            return Ok("Failed to rent!");
        }


        // Return a vehicle
        [HttpPost("{vehicleId}")]
        public ActionResult RentVehicle(int vehicleId)
        {
            var vehicle = Vehicles.FirstOrDefault(v => v.VehicleID == vehicleId);
            var rental = Rentals.FirstOrDefault(r => r.VehicleID == vehicleId);

            if (vehicle == null || rental == null)
            {
                return Ok("Vehicle or Rental not found!");
            }
            vehicle.IsAvailable = true;
            rental.returnDate = new DateTime();

            return Ok("Vehicle is returned successfully!");
        }

        // Track rental records
        [HttpGet]
        public ActionResult TrackRentalrecord()
        {
            return Ok(Rentals);
        }
    }
}
