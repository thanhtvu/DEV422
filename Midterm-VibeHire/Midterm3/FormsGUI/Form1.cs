using MusicRentalManagementGUI;
using PlaylistManagerForm;

namespace FormsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void music_button_Click(object sender, EventArgs e)
        {
            MusicRental music_rental_form = new MusicRental();
            music_rental_form.Show();
        }
        
        private void album_button_Click(object sender, EventArgs e)
        {
            Album album_form = new Album();
            album_form.Show();
        }

        private void playlist_button_Click(object sender, EventArgs e)
        {
            Playlist playlist_form = new Playlist();
            playlist_form.Show();
        }
    }
}
