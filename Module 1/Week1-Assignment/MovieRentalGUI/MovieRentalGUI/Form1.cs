using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MovieRentalGUI.Form1;

namespace MovieRentalGUI
{
    public partial class Form1 : Form
    {
        //
        private static readonly HttpClient client = new HttpClient();

        // MovieManagementAPI
        public class Movie
        {
            public int MovieID { get; set; }
            public string Title { get; set; }
            public string Genre { get; set; }
            public int Year { get; set; }
            public bool Available { get; set; }
        }
        // CustomerManagementAPI
        public class Customer
        {
            public int CustomerID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
        }
        // RentalServiceAPI
        public class Rental
        {
            public int CustomerId { get; set; }
            public int MovieId { get; set; }
            public int RentalId { get; set; }
            public DateTime RentalDate { get; set; }
            public DateTime? ReturnDate { get; set; }

        }


        public Form1()
        {
            InitializeComponent();
        }


        private async void button_addMovie_ClickAsync(object sender, EventArgs e)
        {
            // Create an Object for the movie (same as in the API)
            var newMovie = new
            {
                Title = textBox_movieTitle.Text,
                Genre = textBox_movieGenre.Text,
                Year = textBox_movieYear.Text,
            };

            // Manually serialize the object to JSON
            var json = JsonConvert.SerializeObject(newMovie);

            // Create HttpContent with JSON string
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send the POST request
            HttpResponseMessage message = null;
            try
            {
                message = await client.PostAsync("https://localhost:7171/api/Movie", content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error");
            }

            // Check if the status code is successful, then tell the Movie was added
            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show("Movie Added Successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Failed to Add Movie!", "Error");
            }


        }

        private async void button_displayAllMovie_Click(object sender, EventArgs e)
        {
            // Clear the list box before display New list box (after deleted the unwanted book)
            DisplayAllMovie.Items.Clear();

            //
            HttpResponseMessage message = await client.GetAsync("https://localhost:7171/api/Movie");

            if (message.IsSuccessStatusCode)
            {
                // Read the response content as a string
                string jsonString = await message.Content.ReadAsStringAsync();

                // Deserialize the json string into of book objects
                var movies= JsonConvert.DeserializeObject<List<Movie>>(jsonString); //?
                Console.WriteLine(movies);                                          //?
                foreach (var movie in movies)
                {
                    DisplayAllMovie.Items.Add($"{movie.MovieID}: {movie.Title} - {movie.Genre} - {movie.Year} ");
                }
            }
            else
            {
                MessageBox.Show("Failed to Retrieve Movies", "Error");
            }
        }

        private async void button_registerCustomer_Click(object sender, EventArgs e)
        {
            // Create an Object 
            var newCustomer = new
            {
                Name = textBox_customerName.Text,
                Email = textBox_customerEmail.Text,
                Phone = textBox_customerPhone.Text,
            };

            // Manually serialize the object to JSON
            var json = JsonConvert.SerializeObject(newCustomer);

            // Create HttpContent with JSON string
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send the POST request
            HttpResponseMessage message = null;
            try
            {
                message = await client.PostAsync("https://localhost:7044/api/customer", content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error");
            }

            // Check if the status code is successful, then tell the user's book was added
            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show("Customer Added Successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Failed to Add Customer!", "Error");
            }
        }

        private async void button_displayAllCustomers_Click(object sender, EventArgs e)
        {
            HttpResponseMessage message = await client.GetAsync("https://localhost:7044/api/Customer");

            if (message.IsSuccessStatusCode)
            {
                // Read the response content as a string
                string jsonString = await message.Content.ReadAsStringAsync();

                // Deserialize the json string into of book objects
                var customers = JsonConvert.DeserializeObject<List<Customer>>(jsonString);
                Console.WriteLine(customers);
                foreach (var customer in customers)
                {
                    DisplayAllRegisteredCustomer.Items.Add($"{customer.CustomerID}: {customer.Name} - {customer.Email} with {customer.Phone} ");
                }
            }
            else
            {
                MessageBox.Show("Failed to Retrieve Customers", "Error");
            }
        }


        private async void button_rentMovie_Click(object sender, EventArgs e)
        {
            // Assuming there are text boxes or dropdowns for customer ID and movie ID
            if (string.IsNullOrEmpty(textBox_customerID.Text) || string.IsNullOrEmpty(textBox_movieID.Text))
            {
                MessageBox.Show("Please enter both Customer ID and Movie ID.", "Missing Information");
                return;
            }

            // Parse CustomerId and MovieId
            int customerId;
            int movieId;

            if (!int.TryParse(textBox_customerID.Text, out customerId))
            {
                MessageBox.Show("Invalid Customer ID", "Error");
                return;
            }

            if (!int.TryParse(textBox_movieID.Text, out movieId))
            {
                MessageBox.Show("Invalid Movie ID", "Error");
                return;
            }

            // Create rental object
            var newRental = new
            {
                customerId,
                movieId
            };
            

            // Serialize to JSON
            var json = JsonConvert.SerializeObject(newRental);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            Console.WriteLine(content);
            // Send POST request to /api/rentals
            HttpResponseMessage message = null;
            try
            {
                message = await client.PostAsync("https://localhost:7017/api/rental", content); // replace XXXX with your API's port number
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error while connecting to API");
                return;
            }

            // Handle the API response
            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show("Movie rented successfully!", "Success");
            }
            else
            {
                string jsonString = await message.Content.ReadAsStringAsync();
                MessageBox.Show("Failed to rent the movie. Please check the details." + jsonString, "Error");
            }
        }


        private async void button_returnMovie_Click(object sender, EventArgs e)
        {
            // Assuming you have a text box or input field for Movie ID
            if (string.IsNullOrEmpty(textBox_returnMovieId.Text))
            {
                MessageBox.Show("Please enter a Movie ID.", "Missing Information");
                return;
            }

            // Parse MovieId
            int movieId;
            if (!int.TryParse(textBox_returnMovieId.Text, out movieId))
            {
                MessageBox.Show("Invalid Movie ID", "Error");
                return;
            }

            // Send POST request to /api/rentals/{id}/return to return the movie
            HttpResponseMessage message = null;
            try
            {
                message = await client.PostAsync($"https://localhost:7017/api/Rental/{movieId}", null); // replace XXXX with your API's port number
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error while connecting to API");
                return;
            }

            // Handle the API response
            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show("Movie returned successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Failed to return the movie. Please check the Movie ID.", "Error");
            }
        }


        private async void button_displayActiveRentals_Click(object sender, EventArgs e)
        {
            DisplayAllActiveRentals.Items.Clear();
            HttpResponseMessage message = await client.GetAsync("https://localhost:7017/api/Rental");

            if (message.IsSuccessStatusCode)
            {
                // Read the response content as a string
                string jsonString = await message.Content.ReadAsStringAsync();

                // Deserialize the json string into of rental objects
                var rentals = JsonConvert.DeserializeObject<List<Rental>>(jsonString);
                foreach (var rental in rentals)
                {
                    DisplayAllActiveRentals.Items.Add(
                        $"Rental ID: {rental.RentalId} " +
                        $"| CustomerID: {rental.CustomerId} " +
                        $"| MovieID: {rental.MovieId} " +
                        $"| Rented On: {rental.RentalDate.ToString("MM/dd/yyyy")} " +
                        $"| Returned On: {(rental.ReturnDate.HasValue ? rental.ReturnDate.Value.ToString("MM/dd/yyyy") : "Not Returned")}");

                }
            }
            else
            {
                MessageBox.Show("Failed to Retrieve Active Rentals", "Error");
            }
        }
    }
}
