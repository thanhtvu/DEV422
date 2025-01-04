using Microsoft.AspNetCore.Mvc;

namespace CustomerManagementService.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class CustomerController : ControllerBase
    {
        // list
        private static List<CustomerManagement> customers = new List<CustomerManagement>();

        // get Customer
        [HttpPost]
        public ActionResult AddCustomer(CustomerManagement newCustomer)
        {
            newCustomer.CustomerID = customers.Count +1;
            customers.Add(newCustomer);
            return Ok("New Customer added successfully!");

        }

        // list all customers
        [HttpGet]
        public ActionResult<List<CustomerManagement>> ListAllCustomers()
        {
            return Ok(customers);
        }

        // delete a customer by their ID
        [HttpPost("{CustomerId}")]
        public ActionResult DeleteCustomerById(int CustomerId)
        {
            var deleteCustomer = customers.FirstOrDefault(c => c.CustomerID == CustomerId);

            if (deleteCustomer != null)
            {
                customers.Remove(deleteCustomer);
                return Ok("Customer deleted successfully!");
            }

            return Ok("Customer NOT found!");
        }

    }
}   
