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

namespace MusicRentalManagementGUI
{
    public partial class MusicRental : Form
    {
        // HttpClient to make requests to the API
        private static readonly HttpClient client = new HttpClient();
        public MusicRental()
        {
            InitializeComponent();
        }

        private async void button_addAlbum_Click(object sender, EventArgs e)
        {
            // Create a new music album object
            var newAlbum = new
            {
                Title = textBox_title.Text,
                Artist = textBox_artist.Text,
                Genre = textBox_genre.Text,
                Year = textBox_year.Text
            };

            // Manually serialize the object to JSON
            var json = JsonConvert.SerializeObject(newAlbum);

            // Create HttpContent with JSON string
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send the POST request
            HttpResponseMessage message = null;
            try
            {
                message = await client.PostAsync("https://localhost:7231/api/music", content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error");
            }

            // Check if the request was successful
            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show("Music album added successfully", "Success");
            }
            else
            {
                MessageBox.Show("Failed to add music album", "Error");
            }
        }

        private async void button_listAllAlbums_Click(object sender, EventArgs e)
        {
            listBox_allAlbums.Items.Clear(); // crear the list box
            HttpResponseMessage message = await client.GetAsync("https://localhost:7231/api/music");

            if (message.IsSuccessStatusCode)
            {
                // Read the response as a string
                string jsonString = await message.Content.ReadAsStringAsync();

                // Deserialize the JSON string to a list of movies
                var albums = JsonConvert.DeserializeObject<List<Music>>(jsonString);

                // Display the movies in the listbox
                foreach (var album in albums)
                {
                    listBox_allAlbums.Items.Add($"Album Id: {album.Id}, Title: {album.Title}, Genre: {album.Genre}, Year: {album.Year}");
                }
            }
            else
            {
                MessageBox.Show("Failed to get music albums", "Error");
            }
        }

        private async void button_rentAlbum_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(textBox_userId.Text);
            int albumID = int.Parse(textBox_albumId.Text);

            HttpResponseMessage message = null;

            try
            {
                message = await client.PostAsync($"https://localhost:7012/api/rentals?userId={userID}&albumId={albumID}", null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error");
            }

            // Check if the request was successful
            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show("Music album rented successfully", "Success");
            }
            else
            {
                MessageBox.Show("Failed to rent music album", "Error");
            }
        }

        private async void button_activeRentals_Click(object sender, EventArgs e)
        {
            listBox_activeRentals.Items.Clear(); // Clear the listbox before displaying new data

            HttpResponseMessage message = await client.GetAsync("https://localhost:7012/api/rentals/");

            // Check if the request was successful
            if (message.IsSuccessStatusCode)
            {
                // Read the response as a string
                string jsonString = await message.Content.ReadAsStringAsync();

                // Deserialize the JSON string into a list of Rental objects
                var activeRentals = JsonConvert.DeserializeObject<List<Rentals>>(jsonString);

                // Display each active rental in the listbox
                foreach (var rental in activeRentals)
                {
                    listBox_activeRentals.Items.Add($"{rental.UserId} rented ' {rental.AlbumId}' on {rental.RentalDate}");
                }
            }
            else
            {
                MessageBox.Show("Failed to retrieve active rentals", "Error");
            }
        }

        private async void button_return_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(textBox_userId.Text);
            int albumId = int.Parse(textBox_returnAlbum.Text);

            HttpResponseMessage message = await client.PostAsync($"https://localhost:7012/api/rentals?userId={userId}&{albumId}/return", null);

            // Check if the request was successful
            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show("Music album returned successfully", "Success");
            }
            else
            {
                MessageBox.Show("Failed to return music album", "Error");
            }
        }

        private async void button_addUser_ClickAsync(object sender, EventArgs e)
        {
            var newUser = new
            {
                Name = textBox_name.Text,
            };

            // Manually serizalize the object to JSON
            var json = JsonConvert.SerializeObject(newUser);

            // Create HttpContent with JSON string
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send the POST request
            HttpResponseMessage message = null;
            try
            {
                message = await client.PostAsync("https://localhost:7056/api/user", content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error");
            }

            // Check if the request was successful
            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show("User added successfully", "Success");
            }
            else
            {
                MessageBox.Show("Failed to add user", "Error");
            }
        }

        private async void button_allUsers_Click(object sender, EventArgs e)
        {
            listBox_allUsers.Items.Clear();
            HttpResponseMessage message = await client.GetAsync("https://localhost:7056/api/user");

            if (message.IsSuccessStatusCode)
            {
                // read the response as a string
                string jsonString = await message.Content.ReadAsStringAsync();

                // Deserialize the JSON string to a list of users
                var users = JsonConvert.DeserializeObject<List<User>>(jsonString);

                // Display the users in the listbox
                foreach (var user in users)
                {
                    listBox_allUsers.Items.Add($"{user.Id}: {user.Name}");
                }
            }
            else
            {
                MessageBox.Show("Failed to get users", "Error");
            }
        }


        // Music class to represent the music album object
        public class Music
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Artist { get; set; }
            public string Genre { get; set; }
            public string Year { get; set; }
            public bool isAvailable { get; set; }

        }

        // User class to represent the user object
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        // Rental class to represent the rental object
        public class Rentals
        {
            public int UserId { get; set; }
            public int AlbumId { get; set; }
            public DateTime RentalDate { get; set; }
            public DateTime? ReturnDate { get; set; }
        }
    }
}

