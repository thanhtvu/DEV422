using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;

namespace VehicleManagementAPI.Controllers
{
    //
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleManagementController : ControllerBase
    {
        // Create the list Vehicles
        private static List<VehicleManagement> Vehicles = new List<VehicleManagement>();
        private static int VehicleID = 0;
        // Add a new vehicle
        [HttpPost]
        public ActionResult AddNewVehicle (string VehicleMake, string VehicleModel, int Year, string VehicleType, bool VehicleAvailability)
        {
            var addingVehicle = new VehicleManagement
            {
                VehicleID = VehicleID,
                Make = VehicleMake,
                Model = VehicleModel,
                Year = Year,
                VehicleType = VehicleType,
                IsAvailable = VehicleAvailability   
            };

            Vehicles.Add(addingVehicle);
            VehicleID++;
            return Ok("Vehicle added successfully!");
        }


        // Listing available vehicles
        [HttpGet]
        public ActionResult<List<VehicleManagement>> ListAvailableVehicles()
        {
            List<VehicleManagement> availableVehicles = new List<VehicleManagement>();

            for (int i=0; i< Vehicles.Count; i++)
            {
                if (Vehicles[i].IsAvailable)
                {
                    availableVehicles.Add(Vehicles[i]);
                }
            }

            
            return Ok(availableVehicles);
        }


        // Updating vehicle availability
        [HttpPost("{vehicleId}")]
        public ActionResult UpdateVehicleAvailability (int vehicleId)
        {
            // create an object
            var vehicle = Vehicles.FirstOrDefault(v => v.VehicleID == vehicleId);

            if (vehicle == null)
            {
                return NotFound("Vehicle is NOT FOUND!");

            }
            if (vehicle.IsAvailable)
            {
                vehicle.IsAvailable = false;
                return Ok("Vehicle is Rented!");
            } else
            {
                vehicle.IsAvailable = true;
                return Ok("Vehicle is Available!");
            }

            
        }
        




    }
}
