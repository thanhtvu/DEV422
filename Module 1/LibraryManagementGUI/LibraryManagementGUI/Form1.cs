using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementGUI
{
    public partial class Form1 : Form
    {

        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button_addBook_Click(object sender, EventArgs e)
        {
            // Create an object for the book, same name as it appears in the API
            var newBook = new
            {
                Title = textBox_title.Text,
                Author = textBox_Author.Text,
                ISBN = textBox_ISBN.Text,
                Category = textBox_category.Text,
            };

            // Manually serialize the object to JSON
            var json = JsonConvert.SerializeObject(newBook);

            // Create HttpContent with JSON string
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send the POST request
            HttpResponseMessage message = null;
            try
            {
                message = await client.PostAsync("https://localhost:7211/api/book", content);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error");
            }
            
            // Check if the status code is successful, then tell the user's book was added
            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show("Book Added Successfully!", "Success");
            } else
            {
                MessageBox.Show("Failed to Add a Book!", "Error");
            }


        }

        private void textBox_Author_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_ISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button_addUser_ClickAsync(object sender, EventArgs e)
        {
            // Create an object
            var newUser = new
            {
                Name = textBox_userName.Text,
                UserType = textBox_userType.Text,
            };

            // Manually serialize the object to JSON
            var json = JsonConvert.SerializeObject(newUser);

            // Create HttpContent with JSON string
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send the POST request
            HttpResponseMessage message = null;
            try
            {
                message = await client.PostAsync("https://localhost:7148/api/user", content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error");
            }

            // Check if the status code is successful, then tell the user's book was added
            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show("User Added Successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Failed to Add a User!", "Error");
            }
        }

        private void textBox_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button_borrowBook_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(textBox_UserID.Text);
            int bookID = int.Parse(textBox_BookID.Text);

            HttpResponseMessage message = null;
            try
            {
                message = await client.PostAsync($"https://localhost:7259/api/borrowing?userId={userID}&bookId={bookID}", null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error");
            }

            // Check if the status code is successful, then tell the user was added
            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show("Book Borrowed Successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Failed to Borrow a Book!", "Error");
            }


        }

        // Display all the books
        private async void button_displayAllBooks(object sender, EventArgs e)
        {
            // clear the list box before display new list box (after deleted the unwanted book)
            listBox.Items.Clear();
            HttpResponseMessage message = await client.GetAsync("https://localhost:7211/api/Book");

            if (message.IsSuccessStatusCode)
            {
                // Read the response content as a string
                string jsonString = await message.Content.ReadAsStringAsync();

                // Deserialize the json string into of book objects
                var book = JsonConvert.DeserializeObject<List<Book>>(jsonString);
                Console.WriteLine(book);
                foreach (var books in book)
                {
                    listBox.Items.Add($"{books.Id}: {books.Title} by {books.Author} (ISBN: {books.ISBN}) - {books.Category} ");
                }
            } else
            {
                MessageBox.Show("Failed to retrieve books", "Error");
            }
        }

        
        // Delete 
        private async void button_deleteBook_Click(object sender, EventArgs e)
        {
            int bookIDtoDelete = int.Parse(textBox_deleteBook.Text);

            HttpResponseMessage message = await client.DeleteAsync($"https://localhost:7211/api/Book/{bookIDtoDelete}");

            // Check if the status code is successful, then tell the user was added
            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show("Book Deleted Successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Failed to Delete a Book!", "Error");
            }
        }

        public class Book
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
            public string Category { get; set; }
            public bool IsAvailable { get; set; }

        }
    }
}
