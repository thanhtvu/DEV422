namespace PlaylistManagerForm
{
    partial class Playlist
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_CreatePlaylistSection = new Label();
            label_InviteCollaborationSection = new Label();
            label_AddSongSection = new Label();
            label_VotingSection = new Label();
            label_ViewRankingSection = new Label();
            textBox_PlaylistName = new TextBox();
            checkBox_Collaborative = new CheckBox();
            button_CreatePlaylist = new Button();
            textBox_SongTitle = new TextBox();
            textBox_Artist = new TextBox();
            textBox_Genres = new TextBox();
            comboBox_Playlists = new ComboBox();
            button_AddSong = new Button();
            button_InviteCollaborator = new Button();
            textBox_FriendName = new TextBox();
            comboBox_PlaylistInvite = new ComboBox();
            comboBox_PlaylistVote = new ComboBox();
            button_VoteSong = new Button();
            button_ViewRankings = new Button();
            comboBox_PlaylistsRankings = new ComboBox();
            listBox_Rankings = new ListBox();
            SongId = new TextBox();
            SuspendLayout();
            // 
            // label_CreatePlaylistSection
            // 
            label_CreatePlaylistSection.AutoSize = true;
            label_CreatePlaylistSection.Location = new Point(38, 29);
            label_CreatePlaylistSection.Margin = new Padding(2, 0, 2, 0);
            label_CreatePlaylistSection.Name = "label_CreatePlaylistSection";
            label_CreatePlaylistSection.Size = new Size(148, 15);
            label_CreatePlaylistSection.TabIndex = 0;
            label_CreatePlaylistSection.Text = "CREATE PLAYLIST SECTION";
            // 
            // label_InviteCollaborationSection
            // 
            label_InviteCollaborationSection.AutoSize = true;
            label_InviteCollaborationSection.Location = new Point(38, 206);
            label_InviteCollaborationSection.Margin = new Padding(2, 0, 2, 0);
            label_InviteCollaborationSection.Name = "label_InviteCollaborationSection";
            label_InviteCollaborationSection.Size = new Size(188, 15);
            label_InviteCollaborationSection.TabIndex = 1;
            label_InviteCollaborationSection.Text = "INVITE COLLABORATION SECTION";
            // 
            // label_AddSongSection
            // 
            label_AddSongSection.AutoSize = true;
            label_AddSongSection.Location = new Point(38, 112);
            label_AddSongSection.Margin = new Padding(2, 0, 2, 0);
            label_AddSongSection.Name = "label_AddSongSection";
            label_AddSongSection.Size = new Size(116, 15);
            label_AddSongSection.TabIndex = 2;
            label_AddSongSection.Text = "ADD SONG SECTION";
            // 
            // label_VotingSection
            // 
            label_VotingSection.AutoSize = true;
            label_VotingSection.Location = new Point(38, 308);
            label_VotingSection.Margin = new Padding(2, 0, 2, 0);
            label_VotingSection.Name = "label_VotingSection";
            label_VotingSection.Size = new Size(98, 15);
            label_VotingSection.TabIndex = 3;
            label_VotingSection.Text = "VOTING SECTION";
            // 
            // label_ViewRankingSection
            // 
            label_ViewRankingSection.AutoSize = true;
            label_ViewRankingSection.Location = new Point(38, 412);
            label_ViewRankingSection.Margin = new Padding(2, 0, 2, 0);
            label_ViewRankingSection.Name = "label_ViewRankingSection";
            label_ViewRankingSection.Size = new Size(138, 15);
            label_ViewRankingSection.TabIndex = 4;
            label_ViewRankingSection.Text = "VIEW RANKING SECTION";
            // 
            // textBox_PlaylistName
            // 
            textBox_PlaylistName.Location = new Point(259, 31);
            textBox_PlaylistName.Margin = new Padding(2, 2, 2, 2);
            textBox_PlaylistName.Name = "textBox_PlaylistName";
            textBox_PlaylistName.Size = new Size(106, 23);
            textBox_PlaylistName.TabIndex = 5;
            textBox_PlaylistName.Text = "Playlist Name";
            textBox_PlaylistName.TextAlign = HorizontalAlignment.Center;
            textBox_PlaylistName.TextChanged += textBox_PlaylistName_TextChanged;
            // 
            // checkBox_Collaborative
            // 
            checkBox_Collaborative.AutoSize = true;
            checkBox_Collaborative.Location = new Point(756, 32);
            checkBox_Collaborative.Margin = new Padding(2, 2, 2, 2);
            checkBox_Collaborative.Name = "checkBox_Collaborative";
            checkBox_Collaborative.Size = new Size(101, 19);
            checkBox_Collaborative.TabIndex = 6;
            checkBox_Collaborative.Text = "Collaborative?";
            checkBox_Collaborative.UseVisualStyleBackColor = true;
            checkBox_Collaborative.CheckedChanged += checkBox_Collaborative_CheckedChanged;
            // 
            // button_CreatePlaylist
            // 
            button_CreatePlaylist.Location = new Point(918, 26);
            button_CreatePlaylist.Margin = new Padding(2, 2, 2, 2);
            button_CreatePlaylist.Name = "button_CreatePlaylist";
            button_CreatePlaylist.Size = new Size(78, 20);
            button_CreatePlaylist.TabIndex = 7;
            button_CreatePlaylist.Text = "Create Playlist";
            button_CreatePlaylist.UseVisualStyleBackColor = true;
            button_CreatePlaylist.Click += button_CreatePlaylist_Click;
            // 
            // textBox_SongTitle
            // 
            textBox_SongTitle.Location = new Point(259, 109);
            textBox_SongTitle.Margin = new Padding(2, 2, 2, 2);
            textBox_SongTitle.Name = "textBox_SongTitle";
            textBox_SongTitle.Size = new Size(106, 23);
            textBox_SongTitle.TabIndex = 8;
            textBox_SongTitle.Text = "Title";
            textBox_SongTitle.TextAlign = HorizontalAlignment.Center;
            textBox_SongTitle.TextChanged += textBox_SongTitle_TextChanged;
            // 
            // textBox_Artist
            // 
            textBox_Artist.Location = new Point(417, 109);
            textBox_Artist.Margin = new Padding(2, 2, 2, 2);
            textBox_Artist.Name = "textBox_Artist";
            textBox_Artist.Size = new Size(106, 23);
            textBox_Artist.TabIndex = 9;
            textBox_Artist.Text = "Artist";
            textBox_Artist.TextAlign = HorizontalAlignment.Center;
            textBox_Artist.TextChanged += textBox_Artist_TextChanged;
            // 
            // textBox_Genres
            // 
            textBox_Genres.Location = new Point(588, 109);
            textBox_Genres.Margin = new Padding(2, 2, 2, 2);
            textBox_Genres.Name = "textBox_Genres";
            textBox_Genres.Size = new Size(106, 23);
            textBox_Genres.TabIndex = 10;
            textBox_Genres.Text = "Genre(s)";
            textBox_Genres.TextAlign = HorizontalAlignment.Center;
            textBox_Genres.TextChanged += textBox_Genres_TextChanged;
            // 
            // comboBox_Playlists
            // 
            comboBox_Playlists.FormattingEnabled = true;
            comboBox_Playlists.Location = new Point(756, 107);
            comboBox_Playlists.Margin = new Padding(2, 2, 2, 2);
            comboBox_Playlists.Name = "comboBox_Playlists";
            comboBox_Playlists.Size = new Size(129, 23);
            comboBox_Playlists.TabIndex = 11;
            comboBox_Playlists.Text = "Playlist Selection";
            comboBox_Playlists.SelectedIndexChanged += comboBox_Playlists_SelectedIndexChanged;
            // 
            // button_AddSong
            // 
            button_AddSong.Location = new Point(918, 107);
            button_AddSong.Margin = new Padding(2, 2, 2, 2);
            button_AddSong.Name = "button_AddSong";
            button_AddSong.Size = new Size(78, 20);
            button_AddSong.TabIndex = 12;
            button_AddSong.Text = "ADD SONG";
            button_AddSong.UseVisualStyleBackColor = true;
            button_AddSong.Click += button_AddSong_Click;
            // 
            // button_InviteCollaborator
            // 
            button_InviteCollaborator.Location = new Point(918, 206);
            button_InviteCollaborator.Margin = new Padding(2, 2, 2, 2);
            button_InviteCollaborator.Name = "button_InviteCollaborator";
            button_InviteCollaborator.Size = new Size(78, 20);
            button_InviteCollaborator.TabIndex = 13;
            button_InviteCollaborator.Text = "INVITE";
            button_InviteCollaborator.UseVisualStyleBackColor = true;
            button_InviteCollaborator.Click += button_InviteCollaborator_Click;
            // 
            // textBox_FriendName
            // 
            textBox_FriendName.Location = new Point(259, 206);
            textBox_FriendName.Margin = new Padding(2, 2, 2, 2);
            textBox_FriendName.Name = "textBox_FriendName";
            textBox_FriendName.Size = new Size(106, 23);
            textBox_FriendName.TabIndex = 14;
            textBox_FriendName.Text = "Friend's Id";
            textBox_FriendName.TextChanged += textBox_FriendName_TextChanged;
            // 
            // comboBox_PlaylistInvite
            // 
            comboBox_PlaylistInvite.FormattingEnabled = true;
            comboBox_PlaylistInvite.Location = new Point(417, 205);
            comboBox_PlaylistInvite.Margin = new Padding(2, 2, 2, 2);
            comboBox_PlaylistInvite.Name = "comboBox_PlaylistInvite";
            comboBox_PlaylistInvite.Size = new Size(129, 23);
            comboBox_PlaylistInvite.TabIndex = 15;
            comboBox_PlaylistInvite.Text = "Playlist Selection";
            comboBox_PlaylistInvite.SelectedIndexChanged += comboBox_PlaylistInvite_SelectedIndexChanged;
            // 
            // comboBox_PlaylistVote
            // 
            comboBox_PlaylistVote.FormattingEnabled = true;
            comboBox_PlaylistVote.Location = new Point(259, 308);
            comboBox_PlaylistVote.Margin = new Padding(2, 2, 2, 2);
            comboBox_PlaylistVote.Name = "comboBox_PlaylistVote";
            comboBox_PlaylistVote.Size = new Size(129, 23);
            comboBox_PlaylistVote.TabIndex = 16;
            comboBox_PlaylistVote.Text = "PlaylistSelection";
            comboBox_PlaylistVote.SelectedIndexChanged += comboBox_PlaylistVote_SelectedIndexChanged;
            // 
            // button_VoteSong
            // 
            button_VoteSong.Location = new Point(918, 308);
            button_VoteSong.Margin = new Padding(2, 2, 2, 2);
            button_VoteSong.Name = "button_VoteSong";
            button_VoteSong.Size = new Size(78, 20);
            button_VoteSong.TabIndex = 18;
            button_VoteSong.Text = "VOTE";
            button_VoteSong.UseVisualStyleBackColor = true;
            button_VoteSong.Click += button_VoteSong_Click;
            // 
            // button_ViewRankings
            // 
            button_ViewRankings.Location = new Point(918, 412);
            button_ViewRankings.Margin = new Padding(2, 2, 2, 2);
            button_ViewRankings.Name = "button_ViewRankings";
            button_ViewRankings.Size = new Size(78, 20);
            button_ViewRankings.TabIndex = 19;
            button_ViewRankings.Text = "VIEW RANKINGS";
            button_ViewRankings.UseVisualStyleBackColor = true;
            button_ViewRankings.Click += button_ViewRankings_Click;
            // 
            // comboBox_PlaylistsRankings
            // 
            comboBox_PlaylistsRankings.FormattingEnabled = true;
            comboBox_PlaylistsRankings.Location = new Point(259, 412);
            comboBox_PlaylistsRankings.Margin = new Padding(2, 2, 2, 2);
            comboBox_PlaylistsRankings.Name = "comboBox_PlaylistsRankings";
            comboBox_PlaylistsRankings.Size = new Size(129, 23);
            comboBox_PlaylistsRankings.TabIndex = 20;
            comboBox_PlaylistsRankings.Text = "PlaylistSelection";
            // 
            // listBox_Rankings
            // 
            listBox_Rankings.FormattingEnabled = true;
            listBox_Rankings.ItemHeight = 15;
            listBox_Rankings.Location = new Point(419, 412);
            listBox_Rankings.Margin = new Padding(2, 2, 2, 2);
            listBox_Rankings.Name = "listBox_Rankings";
            listBox_Rankings.Size = new Size(276, 79);
            listBox_Rankings.TabIndex = 21;
            // 
            // SongId
            // 
            SongId.Location = new Point(417, 310);
            SongId.Margin = new Padding(2, 2, 2, 2);
            SongId.Name = "SongId";
            SongId.Size = new Size(106, 23);
            SongId.TabIndex = 22;
            SongId.Text = "Song Id";
            SongId.TextChanged += SongId_TextChanged;
            // 
            // Playlist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 449);
            Controls.Add(SongId);
            Controls.Add(listBox_Rankings);
            Controls.Add(comboBox_PlaylistsRankings);
            Controls.Add(button_ViewRankings);
            Controls.Add(button_VoteSong);
            Controls.Add(comboBox_PlaylistVote);
            Controls.Add(comboBox_PlaylistInvite);
            Controls.Add(textBox_FriendName);
            Controls.Add(button_InviteCollaborator);
            Controls.Add(button_AddSong);
            Controls.Add(comboBox_Playlists);
            Controls.Add(textBox_Genres);
            Controls.Add(textBox_Artist);
            Controls.Add(textBox_SongTitle);
            Controls.Add(button_CreatePlaylist);
            Controls.Add(checkBox_Collaborative);
            Controls.Add(textBox_PlaylistName);
            Controls.Add(label_ViewRankingSection);
            Controls.Add(label_VotingSection);
            Controls.Add(label_AddSongSection);
            Controls.Add(label_InviteCollaborationSection);
            Controls.Add(label_CreatePlaylistSection);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Playlist";
            Text = "Form1";
            Load += Playlist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_CreatePlaylistSection;
        private Label label_InviteCollaborationSection;
        private Label label_AddSongSection;
        private Label label_VotingSection;
        private Label label_ViewRankingSection;
        private TextBox textBox_PlaylistName;
        private CheckBox checkBox_Collaborative;
        private Button button_CreatePlaylist;
        private TextBox textBox_SongTitle;
        private TextBox textBox_Artist;
        private TextBox textBox_Genres;
        private ComboBox comboBox_Playlists;
        private Button button_AddSong;
        private Button button_InviteCollaborator;
        private TextBox textBox_FriendName;
        private ComboBox comboBox_PlaylistInvite;
        private ComboBox comboBox_PlaylistVote;
        private Button button_VoteSong;
        private Button button_ViewRankings;
        private ComboBox comboBox_PlaylistsRankings;
        private ListBox listBox_Rankings;
        private TextBox SongId;
    }
}
