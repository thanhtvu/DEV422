using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PlaylistManagerForm
{
    public partial class Playlist : Form
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // HttpClient instance to communicate with Playlist API
        private readonly HttpClient _httpClient;


        public Playlist()
        {
            InitializeComponent();

            // set address of the API
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7294") }; //where should I get this API address


            // load playlists on form load to populate dropdowns
            LoadPlaylists();
        }




        //Playlist model with properties matching API response
        public class PlaylistModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        //Song model with properties matching with API response
        public class Song
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public int Votes { get; set; }
        }





        // Method to Load the playlist and Populates playlist dropdowns
        private async void LoadPlaylists()
        {
            // send GET request to retrieve playlists
            var response = await _httpClient.GetAsync("/api/playlists"); // what is this "playlists"?
            Console.WriteLine(response);
            // check if request was successful
            if (response.IsSuccessStatusCode)
            {
                // read response content as a string 
                var responseData = await response.Content.ReadAsStringAsync();

                // deserialize JSON to list of Playlist
                var playlists = JsonConvert.DeserializeObject<List<Playlist>>(responseData);

                // Populate playlist/dropdown for adding songs, inviting collaborator, voting, viewing rankings
                comboBox_Playlists.DataSource = playlists;
                comboBox_Playlists.DisplayMember = "Name";
                comboBox_PlaylistInvite.DataSource = playlists;
                comboBox_PlaylistInvite.DisplayMember = "Name";
                comboBox_PlaylistVote.DataSource = playlists;
                comboBox_PlaylistVote.DisplayMember = "Name";
                comboBox_PlaylistsRankings.DataSource = playlists;
                comboBox_PlaylistsRankings.DisplayMember = "Name";

            }
            else
            {
                MessageBox.Show("Failed to load playlists.");
            }

        }









        private void textBox_PlaylistName_TextChanged(object sender, EventArgs e)
        {

        }



        // Local variable to store the Collaborative status
        private bool isCollaborative;
        private void checkBox_Collaborative_CheckedChanged(object sender, EventArgs e)
        {
            // check current state of the Checkbox
            //bool isCollaborative = checkBox_Collaborative.Checked;

            //// display a noti messge to confirm collaborative status
            //if (isCollaborative)
            //{
            //    MessageBox.Show("This playlist is now set to collaborative!!!!");
            //}
            //else
            //{
            //    MessageBox.Show("This playlist is NOT collaborative!!!");
            //}


        }


        // Button to Create a new 'playlist'
        private async void button_CreatePlaylist_Click(object sender, EventArgs e)
        {
            // create an object for the playlist data
            var playlist = new
            {
                // retrieve playlist Name from textBox_PlaylistName
                Name = textBox_PlaylistName.Text,

                // get the coborative status from the checkBox_Coborative
                IsCollaborative = checkBox_Collaborative.Checked,
            };


            // serialize playlist object to JSON and prepare it for sending
            var content = new StringContent(JsonConvert.SerializeObject(playlist), Encoding.UTF8, "application/json");

            // send POST request to create the playlist
            var response = await _httpClient.PostAsync("/api/playlists", content);


            // check if the playlist was created successfully
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Playlist created successfully!");
                LoadPlaylists();
            }
            else
            {
                MessageBox.Show("Failed to Create a new Playlist!");
            }
        }

        private void textBox_SongTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Artist_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Genres_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Playlists_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        // Button to ADD a New Song to a selected playlist
        private async void button_AddSong_Click(object sender, EventArgs e)
        {
            // get selected playlist from dropdown
            var selectedPlaylist = (Playlist)comboBox_Playlists.SelectedItem;

            // create a Song object with song details
            var song = new
            {
                Title = textBox_SongTitle.Text,
                Artist = textBox_Artist.Text,
                Genre = textBox_Genres.Text,
            };

            // serialize song object to JSON & prepare for sending
            var content = new StringContent(JsonConvert.SerializeObject(song), Encoding.UTF8, "application/json");

            // send PUT request to add song to playlist
            var response = await _httpClient.PutAsync($"/api/playlists/{selectedPlaylist.Id}/add", content);

            // check if song addition was succesful
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Song Added Successfully!");
            }
            else
            {
                MessageBox.Show("Failed to Add New Song!");
            }
        }

        private void textBox_FriendName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_PlaylistInvite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        // Button to INVITE a Collaborator to a selected playlist
        private async void button_InviteCollaborator_Click(object sender, EventArgs e)
        {
            // get selected playlist for collaboration
            var selectedPlaylist = (Playlist)comboBox_PlaylistInvite.SelectedItem;

            // create an anonymous object with collaborator's name 
            if (int.TryParse(textBox_FriendName.Text, out int friendId))
            {
                // If successful, use the integer value (friendId)
                MessageBox.Show($"Friend ID: {friendId} was successfully parsed.");

                // Now you can use the friendId in your logic (e.g., to send an invitation)
            }
            else
            {
                // If parsing fails, show an error message
                MessageBox.Show("Please enter a valid integer for Friend ID.");
                return;
            }

            // Serialize collaborator data to JSON and prepare for sending
            var content = new StringContent(JsonConvert.SerializeObject(friendId), Encoding.UTF8, "application/json");

            // send PUT request to invite a collaborator
            var response = await _httpClient.PutAsync($"/api/playlists/{selectedPlaylist.Id}/invite", content);

            // check if the action is successful
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Collaborator Invited Successfully!");
            }
            else
            {
                Console.WriteLine(response.Content);
                MessageBox.Show("Failed to Invite the Collaborator!");
            }

        }

        private void comboBox_PlaylistVote_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_SongSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        // Button to VOTE on a song within a collaborative playlist
        private async void button_VoteSong_Click(object sender, EventArgs e)
        {
            // get the playlist for voting
            var selectedPlaylist = comboBox_PlaylistVote.SelectedItem as Playlist;

            // get the selected song for voting
            if (int.TryParse(SongId.Text, out int selectedSong))
            {

            }
            else
            {
                // If parsing fails, show an error message
                MessageBox.Show("Please enter a valid integer for Friend ID.");
                return;
            }

            var content = new StringContent(JsonConvert.SerializeObject(selectedSong), Encoding.UTF8, "application/json");
            // check if song & playlist have been selected
            if (selectedPlaylist != null && selectedSong != null)
            {
                // send POST request to cast/get a vote for the selected song in the playlist
                var voteResponse = await _httpClient.PostAsync($"/api/playlists/{selectedPlaylist.Id}/vote", content);

                // check if the voting was successful
                if (voteResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Voted Successfully!");
                }
                else
                {
                    MessageBox.Show("Voting Failed!");
                }
            }
            else
            {
                MessageBox.Show("Please selected a playlist and a song to vote.");
            }

        }



        // Button to VIEW the Ranking og Songs in a selected Playlist
        private async void button_ViewRankings_Click(object sender, EventArgs e)
        {
            // get the selected playlist
            var selectedPlaylist = (Playlist)comboBox_PlaylistsRankings.SelectedItem;

            // send GET request to retrieve song rankings within the playlist
            var response = await _httpClient.GetAsync($"/api/playlists/{selectedPlaylist.Id}/rankings");

            if (response.IsSuccessStatusCode) // Check if request was successful
            {
                var rankings = await response.Content.ReadAsAsync<List<Song>>(); // Deserialize response to get rankings
                listBox_Rankings.Items.Clear(); // Clear current rankings in list box

                // Display each ranked song in the list box
                foreach (var song in rankings)
                {
                    listBox_Rankings.Items.Add($"{song.Title} - Votes: {song.Votes}"); // Display title and votes
                }
            }
            else
            {
                MessageBox.Show("Failed to retrieve rankings."); // Inform the user if failed
            }
        }

        private void SongId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Playlist_Load(object sender, EventArgs e)
        {

        }
    }
}
