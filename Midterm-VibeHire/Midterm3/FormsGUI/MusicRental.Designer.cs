namespace MusicRentalManagementGUI
{
    partial class MusicRental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_addAlbum = new System.Windows.Forms.Button();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_artist = new System.Windows.Forms.TextBox();
            this.textBox_genre = new System.Windows.Forms.TextBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_listAllAlbums = new System.Windows.Forms.Button();
            this.listBox_allAlbums = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_albumId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_userId = new System.Windows.Forms.TextBox();
            this.button_rentAlbum = new System.Windows.Forms.Button();
            this.textBox_returnAlbum = new System.Windows.Forms.TextBox();
            this.button_return = new System.Windows.Forms.Button();
            this.button_activeRentals = new System.Windows.Forms.Button();
            this.listBox_activeRentals = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_addUser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox_allUsers = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button_allUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_addAlbum
            // 
            this.button_addAlbum.BackColor = System.Drawing.Color.LightGreen;
            this.button_addAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addAlbum.Location = new System.Drawing.Point(86, 383);
            this.button_addAlbum.Margin = new System.Windows.Forms.Padding(1);
            this.button_addAlbum.Name = "button_addAlbum";
            this.button_addAlbum.Size = new System.Drawing.Size(227, 30);
            this.button_addAlbum.TabIndex = 1;
            this.button_addAlbum.Text = "Add Music Album";
            this.button_addAlbum.UseVisualStyleBackColor = false;
            this.button_addAlbum.Click += new System.EventHandler(this.button_addAlbum_Click);
            // 
            // textBox_title
            // 
            this.textBox_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_title.Location = new System.Drawing.Point(86, 176);
            this.textBox_title.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(227, 26);
            this.textBox_title.TabIndex = 2;
            // 
            // textBox_artist
            // 
            this.textBox_artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_artist.Location = new System.Drawing.Point(86, 227);
            this.textBox_artist.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_artist.Name = "textBox_artist";
            this.textBox_artist.Size = new System.Drawing.Size(227, 26);
            this.textBox_artist.TabIndex = 3;
            // 
            // textBox_genre
            // 
            this.textBox_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_genre.Location = new System.Drawing.Point(86, 283);
            this.textBox_genre.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_genre.Name = "textBox_genre";
            this.textBox_genre.Size = new System.Drawing.Size(227, 26);
            this.textBox_genre.TabIndex = 4;
            // 
            // textBox_year
            // 
            this.textBox_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_year.Location = new System.Drawing.Point(86, 342);
            this.textBox_year.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(227, 26);
            this.textBox_year.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Artist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 322);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Year";
            // 
            // button_listAllAlbums
            // 
            this.button_listAllAlbums.BackColor = System.Drawing.Color.Gold;
            this.button_listAllAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_listAllAlbums.Location = new System.Drawing.Point(329, 507);
            this.button_listAllAlbums.Margin = new System.Windows.Forms.Padding(1);
            this.button_listAllAlbums.Name = "button_listAllAlbums";
            this.button_listAllAlbums.Size = new System.Drawing.Size(232, 30);
            this.button_listAllAlbums.TabIndex = 10;
            this.button_listAllAlbums.Text = "List All Music Albums";
            this.button_listAllAlbums.UseVisualStyleBackColor = false;
            this.button_listAllAlbums.Click += new System.EventHandler(this.button_listAllAlbums_Click);
            // 
            // listBox_allAlbums
            // 
            this.listBox_allAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_allAlbums.FormattingEnabled = true;
            this.listBox_allAlbums.HorizontalScrollbar = true;
            this.listBox_allAlbums.Location = new System.Drawing.Point(334, 177);
            this.listBox_allAlbums.Margin = new System.Windows.Forms.Padding(1);
            this.listBox_allAlbums.Name = "listBox_allAlbums";
            this.listBox_allAlbums.ScrollAlwaysVisible = true;
            this.listBox_allAlbums.Size = new System.Drawing.Size(227, 316);
            this.listBox_allAlbums.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(984, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "AlbumID";
            // 
            // textBox_albumId
            // 
            this.textBox_albumId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_albumId.Location = new System.Drawing.Point(1057, 152);
            this.textBox_albumId.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_albumId.Name = "textBox_albumId";
            this.textBox_albumId.Size = new System.Drawing.Size(46, 26);
            this.textBox_albumId.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(871, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "UserID";
            // 
            // textBox_userId
            // 
            this.textBox_userId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_userId.Location = new System.Drawing.Point(933, 152);
            this.textBox_userId.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_userId.Name = "textBox_userId";
            this.textBox_userId.Size = new System.Drawing.Size(45, 26);
            this.textBox_userId.TabIndex = 17;
            // 
            // button_rentAlbum
            // 
            this.button_rentAlbum.BackColor = System.Drawing.Color.LightGreen;
            this.button_rentAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rentAlbum.Location = new System.Drawing.Point(872, 191);
            this.button_rentAlbum.Margin = new System.Windows.Forms.Padding(1);
            this.button_rentAlbum.Name = "button_rentAlbum";
            this.button_rentAlbum.Size = new System.Drawing.Size(229, 30);
            this.button_rentAlbum.TabIndex = 18;
            this.button_rentAlbum.Text = "Rent Album";
            this.button_rentAlbum.UseVisualStyleBackColor = false;
            this.button_rentAlbum.Click += new System.EventHandler(this.button_rentAlbum_Click);
            // 
            // textBox_returnAlbum
            // 
            this.textBox_returnAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_returnAlbum.Location = new System.Drawing.Point(987, 250);
            this.textBox_returnAlbum.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_returnAlbum.Name = "textBox_returnAlbum";
            this.textBox_returnAlbum.Size = new System.Drawing.Size(114, 26);
            this.textBox_returnAlbum.TabIndex = 19;
            // 
            // button_return
            // 
            this.button_return.BackColor = System.Drawing.Color.Pink;
            this.button_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_return.Location = new System.Drawing.Point(874, 283);
            this.button_return.Margin = new System.Windows.Forms.Padding(1);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(225, 30);
            this.button_return.TabIndex = 20;
            this.button_return.Text = "Return Album";
            this.button_return.UseVisualStyleBackColor = false;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // button_activeRentals
            // 
            this.button_activeRentals.BackColor = System.Drawing.Color.Gold;
            this.button_activeRentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_activeRentals.Location = new System.Drawing.Point(876, 511);
            this.button_activeRentals.Margin = new System.Windows.Forms.Padding(1);
            this.button_activeRentals.Name = "button_activeRentals";
            this.button_activeRentals.Size = new System.Drawing.Size(229, 26);
            this.button_activeRentals.TabIndex = 21;
            this.button_activeRentals.Text = "Show Active Rentals";
            this.button_activeRentals.UseVisualStyleBackColor = false;
            this.button_activeRentals.Click += new System.EventHandler(this.button_activeRentals_Click);
            // 
            // listBox_activeRentals
            // 
            this.listBox_activeRentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_activeRentals.FormattingEnabled = true;
            this.listBox_activeRentals.HorizontalScrollbar = true;
            this.listBox_activeRentals.Location = new System.Drawing.Point(876, 353);
            this.listBox_activeRentals.Margin = new System.Windows.Forms.Padding(1);
            this.listBox_activeRentals.Name = "listBox_activeRentals";
            this.listBox_activeRentals.ScrollAlwaysVisible = true;
            this.listBox_activeRentals.Size = new System.Drawing.Size(227, 147);
            this.listBox_activeRentals.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(877, 332);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "All Active Rentals";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(432, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(357, 37);
            this.label11.TabIndex = 24;
            this.label11.Text = "MUSIC RENTAL SYSTEM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(82, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 29);
            this.label12.TabIndex = 25;
            this.label12.Text = "MUSIC ALBUM";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(599, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 29);
            this.label13.TabIndex = 26;
            this.label13.Text = "USER";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(869, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(249, 29);
            this.label14.TabIndex = 27;
            this.label14.Text = "RENT MUSIC ALBUM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "All Available Music Albums";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(602, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Name";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(602, 163);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(227, 26);
            this.textBox_name.TabIndex = 31;
            // 
            // button_addUser
            // 
            this.button_addUser.BackColor = System.Drawing.Color.LightGreen;
            this.button_addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addUser.Location = new System.Drawing.Point(602, 208);
            this.button_addUser.Margin = new System.Windows.Forms.Padding(1);
            this.button_addUser.Name = "button_addUser";
            this.button_addUser.Size = new System.Drawing.Size(225, 30);
            this.button_addUser.TabIndex = 32;
            this.button_addUser.Text = "Add User";
            this.button_addUser.UseVisualStyleBackColor = false;
            this.button_addUser.Click += new System.EventHandler(this.button_addUser_ClickAsync);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(877, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "AlbumID";
            // 
            // listBox_allUsers
            // 
            this.listBox_allUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_allUsers.FormattingEnabled = true;
            this.listBox_allUsers.HorizontalScrollbar = true;
            this.listBox_allUsers.Location = new System.Drawing.Point(604, 274);
            this.listBox_allUsers.Margin = new System.Windows.Forms.Padding(1);
            this.listBox_allUsers.Name = "listBox_allUsers";
            this.listBox_allUsers.ScrollAlwaysVisible = true;
            this.listBox_allUsers.Size = new System.Drawing.Size(227, 225);
            this.listBox_allUsers.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(602, 253);
            this.label15.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "All Users";
            // 
            // button_allUsers
            // 
            this.button_allUsers.BackColor = System.Drawing.Color.Gold;
            this.button_allUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_allUsers.Location = new System.Drawing.Point(604, 511);
            this.button_allUsers.Margin = new System.Windows.Forms.Padding(1);
            this.button_allUsers.Name = "button_allUsers";
            this.button_allUsers.Size = new System.Drawing.Size(229, 26);
            this.button_allUsers.TabIndex = 36;
            this.button_allUsers.Text = "List All Users";
            this.button_allUsers.UseVisualStyleBackColor = false;
            this.button_allUsers.Click += new System.EventHandler(this.button_allUsers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1194, 607);
            this.Controls.Add(this.button_allUsers);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.listBox_allUsers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_addUser);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox_activeRentals);
            this.Controls.Add(this.button_activeRentals);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.textBox_returnAlbum);
            this.Controls.Add(this.button_rentAlbum);
            this.Controls.Add(this.textBox_userId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_albumId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox_allAlbums);
            this.Controls.Add(this.button_listAllAlbums);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.textBox_genre);
            this.Controls.Add(this.textBox_artist);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.button_addAlbum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_addAlbum;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_artist;
        private System.Windows.Forms.TextBox textBox_genre;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_listAllAlbums;
        private System.Windows.Forms.ListBox listBox_allAlbums;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_albumId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_userId;
        private System.Windows.Forms.Button button_rentAlbum;
        private System.Windows.Forms.TextBox textBox_returnAlbum;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_activeRentals;
        private System.Windows.Forms.ListBox listBox_activeRentals;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_addUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox_allUsers;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_allUsers;
    }
}

