using AlbumClient;
using AlbumService;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsGUI
{
    public partial class Album : Form
    {
        DoAlbum DoAlbum = new DoAlbum();
        List<AlbumClient.AlbumResponse> _albums = new List<AlbumClient.AlbumResponse>();
        public Album()
        {
            InitializeComponent();
        }

        private void Album_Load(object sender, EventArgs e)
        {
            
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            DoAlbum.AddAlbum(textBox3.Text, textBox2.Text, textBox4.Text, Convert.ToInt32(textBox5.Text));
            _albums = DoAlbum.ListAlbums();
            List();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            int i = album_list.SelectedIndex;
            var album = _albums[i];
            String ID = album.AlbumId;
            DoAlbum.UpdateAlbum(ID, textBox3.Text, textBox2.Text, textBox4.Text, Convert.ToInt32(textBox5.Text), true);
            List();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int i = album_list.SelectedIndex;
            var album = _albums[i];
            String ID = album.AlbumId;
            DoAlbum.DeleteAlbum(ID);
            List();
        }

        private void list_button_Click(object sender, EventArgs e)
        {
            List();
        }
        private void List()
        {
            album_list.Items.Clear();
            _albums = DoAlbum.ListAlbums();
            foreach (var s in _albums)
            {
                album_list.Items.Add($"{s.Title} | {s.Artist} | {s.Genre} | {s.Year}");
            }
        }
    }
}
