using Microsoft.AspNetCore.Mvc;

namespace CustomerManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CustomerController : ControllerBase
    {
        // List of Customers
        private static List<Customer> customerList = new List<Customer>();

        // Register a new customer
        [HttpPost]
        public ActionResult AddNewCustomer(Customer customer)
        {
            customer.CustomerID = customerList.Count + 1;
            customerList.Add(customer);
            return Ok("New Customer Added Successfully");
        }


        // List all customers
        [HttpGet]
        public ActionResult<List<Customer>> ListAllCustomers()
        {
            return Ok(customerList);
        }
        


        // Delete a customer by their ID
        [HttpDelete("{customerID}")]
        public ActionResult DeleteCustomerByID(int customerID)
        {
            var customer = customerList.FirstOrDefault(c  => c.CustomerID == customerID); //?
            if (customer == null)
            {
                return NotFound("Customer Not Found!");
            } 
            customerList.Remove(customer);
            return Ok("Customer Removed Successfully!");
        }




    }
}
