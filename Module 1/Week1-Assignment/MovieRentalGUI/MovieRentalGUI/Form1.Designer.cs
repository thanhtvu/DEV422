namespace MovieRentalGUI
{
    partial class Form1
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
            this.textBox_movieTitle = new System.Windows.Forms.TextBox();
            this.textBox_movieGenre = new System.Windows.Forms.TextBox();
            this.textBox_movieYear = new System.Windows.Forms.TextBox();
            this.button_addMovie = new System.Windows.Forms.Button();
            this.DisplayAllMovie = new System.Windows.Forms.ListBox();
            this.button_displayAllMovie = new System.Windows.Forms.Button();
            this.button_registerCustomer = new System.Windows.Forms.Button();
            this.textBox_customerName = new System.Windows.Forms.TextBox();
            this.textBox_customerEmail = new System.Windows.Forms.TextBox();
            this.textBox_customerPhone = new System.Windows.Forms.TextBox();
            this.DisplayAllRegisteredCustomer = new System.Windows.Forms.ListBox();
            this.button_displayAllCustomers = new System.Windows.Forms.Button();
            this.button_rentMovie = new System.Windows.Forms.Button();
            this.textBox_customerID = new System.Windows.Forms.TextBox();
            this.textBox_movieID = new System.Windows.Forms.TextBox();
            this.button_returnMovie = new System.Windows.Forms.Button();
            this.textBox_returnMovieId = new System.Windows.Forms.TextBox();
            this.DisplayAllActiveRentals = new System.Windows.Forms.ListBox();
            this.button_displayActiveRentals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_movieTitle
            // 
            this.textBox_movieTitle.Location = new System.Drawing.Point(13, 13);
            this.textBox_movieTitle.Name = "textBox_movieTitle";
            this.textBox_movieTitle.Size = new System.Drawing.Size(100, 20);
            this.textBox_movieTitle.TabIndex = 0;
            this.textBox_movieTitle.Text = "TITLE";
            // 
            // textBox_movieGenre
            // 
            this.textBox_movieGenre.Location = new System.Drawing.Point(150, 13);
            this.textBox_movieGenre.Name = "textBox_movieGenre";
            this.textBox_movieGenre.Size = new System.Drawing.Size(100, 20);
            this.textBox_movieGenre.TabIndex = 1;
            this.textBox_movieGenre.Text = "GENRE";
            // 
            // textBox_movieYear
            // 
            this.textBox_movieYear.Location = new System.Drawing.Point(287, 13);
            this.textBox_movieYear.Name = "textBox_movieYear";
            this.textBox_movieYear.Size = new System.Drawing.Size(100, 20);
            this.textBox_movieYear.TabIndex = 2;
            this.textBox_movieYear.Text = "YEAR";
            // 
            // button_addMovie
            // 
            this.button_addMovie.Location = new System.Drawing.Point(702, 9);
            this.button_addMovie.Name = "button_addMovie";
            this.button_addMovie.Size = new System.Drawing.Size(75, 23);
            this.button_addMovie.TabIndex = 3;
            this.button_addMovie.Text = "ADD MOVIE";
            this.button_addMovie.UseVisualStyleBackColor = true;
            this.button_addMovie.Click += new System.EventHandler(this.button_addMovie_ClickAsync);
            // 
            // DisplayAllMovie
            // 
            this.DisplayAllMovie.FormattingEnabled = true;
            this.DisplayAllMovie.Location = new System.Drawing.Point(13, 49);
            this.DisplayAllMovie.Name = "DisplayAllMovie";
            this.DisplayAllMovie.Size = new System.Drawing.Size(582, 43);
            this.DisplayAllMovie.TabIndex = 4;
            // 
            // button_displayAllMovie
            // 
            this.button_displayAllMovie.Location = new System.Drawing.Point(702, 49);
            this.button_displayAllMovie.Name = "button_displayAllMovie";
            this.button_displayAllMovie.Size = new System.Drawing.Size(75, 23);
            this.button_displayAllMovie.TabIndex = 5;
            this.button_displayAllMovie.Text = "LIST ALL MOVIES";
            this.button_displayAllMovie.UseVisualStyleBackColor = true;
            this.button_displayAllMovie.Click += new System.EventHandler(this.button_displayAllMovie_Click);
            // 
            // button_registerCustomer
            // 
            this.button_registerCustomer.Location = new System.Drawing.Point(702, 112);
            this.button_registerCustomer.Name = "button_registerCustomer";
            this.button_registerCustomer.Size = new System.Drawing.Size(75, 23);
            this.button_registerCustomer.TabIndex = 6;
            this.button_registerCustomer.Text = "REGISTER";
            this.button_registerCustomer.UseVisualStyleBackColor = true;
            this.button_registerCustomer.Click += new System.EventHandler(this.button_registerCustomer_Click);
            // 
            // textBox_customerName
            // 
            this.textBox_customerName.Location = new System.Drawing.Point(13, 115);
            this.textBox_customerName.Name = "textBox_customerName";
            this.textBox_customerName.Size = new System.Drawing.Size(100, 20);
            this.textBox_customerName.TabIndex = 7;
            this.textBox_customerName.Text = "NAME";
            // 
            // textBox_customerEmail
            // 
            this.textBox_customerEmail.Location = new System.Drawing.Point(150, 115);
            this.textBox_customerEmail.Name = "textBox_customerEmail";
            this.textBox_customerEmail.Size = new System.Drawing.Size(100, 20);
            this.textBox_customerEmail.TabIndex = 8;
            this.textBox_customerEmail.Text = "EMAIL";
            // 
            // textBox_customerPhone
            // 
            this.textBox_customerPhone.Location = new System.Drawing.Point(287, 115);
            this.textBox_customerPhone.Name = "textBox_customerPhone";
            this.textBox_customerPhone.Size = new System.Drawing.Size(100, 20);
            this.textBox_customerPhone.TabIndex = 9;
            this.textBox_customerPhone.Text = "PHONE";
            // 
            // DisplayAllRegisteredCustomer
            // 
            this.DisplayAllRegisteredCustomer.FormattingEnabled = true;
            this.DisplayAllRegisteredCustomer.Location = new System.Drawing.Point(13, 164);
            this.DisplayAllRegisteredCustomer.Name = "DisplayAllRegisteredCustomer";
            this.DisplayAllRegisteredCustomer.Size = new System.Drawing.Size(582, 43);
            this.DisplayAllRegisteredCustomer.TabIndex = 10;
            // 
            // button_displayAllCustomers
            // 
            this.button_displayAllCustomers.Location = new System.Drawing.Point(702, 164);
            this.button_displayAllCustomers.Name = "button_displayAllCustomers";
            this.button_displayAllCustomers.Size = new System.Drawing.Size(75, 23);
            this.button_displayAllCustomers.TabIndex = 11;
            this.button_displayAllCustomers.Text = "DISPLAY ALL";
            this.button_displayAllCustomers.UseVisualStyleBackColor = true;
            this.button_displayAllCustomers.Click += new System.EventHandler(this.button_displayAllCustomers_Click);
            // 
            // button_rentMovie
            // 
            this.button_rentMovie.Location = new System.Drawing.Point(702, 230);
            this.button_rentMovie.Name = "button_rentMovie";
            this.button_rentMovie.Size = new System.Drawing.Size(75, 23);
            this.button_rentMovie.TabIndex = 12;
            this.button_rentMovie.Text = "RENT!";
            this.button_rentMovie.UseVisualStyleBackColor = true;
            this.button_rentMovie.Click += new System.EventHandler(this.button_rentMovie_Click);
            // 
            // textBox_customerID
            // 
            this.textBox_customerID.Location = new System.Drawing.Point(13, 233);
            this.textBox_customerID.Name = "textBox_customerID";
            this.textBox_customerID.Size = new System.Drawing.Size(100, 20);
            this.textBox_customerID.TabIndex = 13;
            this.textBox_customerID.Text = "CUSTOMER-ID";
            // 
            // textBox_movieID
            // 
            this.textBox_movieID.Location = new System.Drawing.Point(150, 233);
            this.textBox_movieID.Name = "textBox_movieID";
            this.textBox_movieID.Size = new System.Drawing.Size(100, 20);
            this.textBox_movieID.TabIndex = 14;
            this.textBox_movieID.Text = "MOVIE-ID";
            // 
            // button_returnMovie
            // 
            this.button_returnMovie.Location = new System.Drawing.Point(702, 282);
            this.button_returnMovie.Name = "button_returnMovie";
            this.button_returnMovie.Size = new System.Drawing.Size(75, 23);
            this.button_returnMovie.TabIndex = 15;
            this.button_returnMovie.Text = "RETURN";
            this.button_returnMovie.UseVisualStyleBackColor = true;
            this.button_returnMovie.Click += new System.EventHandler(this.button_returnMovie_Click);
            // 
            // textBox_returnMovieId
            // 
            this.textBox_returnMovieId.Location = new System.Drawing.Point(13, 282);
            this.textBox_returnMovieId.Name = "textBox_returnMovieId";
            this.textBox_returnMovieId.Size = new System.Drawing.Size(100, 20);
            this.textBox_returnMovieId.TabIndex = 16;
            this.textBox_returnMovieId.Text = "MOVIE-ID";
            // 
            // DisplayAllActiveRentals
            // 
            this.DisplayAllActiveRentals.FormattingEnabled = true;
            this.DisplayAllActiveRentals.Location = new System.Drawing.Point(13, 334);
            this.DisplayAllActiveRentals.Name = "DisplayAllActiveRentals";
            this.DisplayAllActiveRentals.Size = new System.Drawing.Size(582, 43);
            this.DisplayAllActiveRentals.TabIndex = 17;
            // 
            // button_displayActiveRentals
            // 
            this.button_displayActiveRentals.Location = new System.Drawing.Point(702, 334);
            this.button_displayActiveRentals.Name = "button_displayActiveRentals";
            this.button_displayActiveRentals.Size = new System.Drawing.Size(75, 23);
            this.button_displayActiveRentals.TabIndex = 18;
            this.button_displayActiveRentals.Text = "DISPLAY";
            this.button_displayActiveRentals.UseVisualStyleBackColor = true;
            this.button_displayActiveRentals.Click += new System.EventHandler(this.button_displayActiveRentals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_displayActiveRentals);
            this.Controls.Add(this.DisplayAllActiveRentals);
            this.Controls.Add(this.textBox_returnMovieId);
            this.Controls.Add(this.button_returnMovie);
            this.Controls.Add(this.textBox_movieID);
            this.Controls.Add(this.textBox_customerID);
            this.Controls.Add(this.button_rentMovie);
            this.Controls.Add(this.button_displayAllCustomers);
            this.Controls.Add(this.DisplayAllRegisteredCustomer);
            this.Controls.Add(this.textBox_customerPhone);
            this.Controls.Add(this.textBox_customerEmail);
            this.Controls.Add(this.textBox_customerName);
            this.Controls.Add(this.button_registerCustomer);
            this.Controls.Add(this.button_displayAllMovie);
            this.Controls.Add(this.DisplayAllMovie);
            this.Controls.Add(this.button_addMovie);
            this.Controls.Add(this.textBox_movieYear);
            this.Controls.Add(this.textBox_movieGenre);
            this.Controls.Add(this.textBox_movieTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_movieTitle;
        private System.Windows.Forms.TextBox textBox_movieGenre;
        private System.Windows.Forms.TextBox textBox_movieYear;
        private System.Windows.Forms.Button button_addMovie;
        private System.Windows.Forms.ListBox DisplayAllMovie;
        private System.Windows.Forms.Button button_displayAllMovie;
        private System.Windows.Forms.Button button_registerCustomer;
        private System.Windows.Forms.TextBox textBox_customerName;
        private System.Windows.Forms.TextBox textBox_customerEmail;
        private System.Windows.Forms.TextBox textBox_customerPhone;
        private System.Windows.Forms.ListBox DisplayAllRegisteredCustomer;
        private System.Windows.Forms.Button button_displayAllCustomers;
        private System.Windows.Forms.Button button_rentMovie;
        private System.Windows.Forms.TextBox textBox_customerID;
        private System.Windows.Forms.TextBox textBox_movieID;
        private System.Windows.Forms.Button button_returnMovie;
        private System.Windows.Forms.TextBox textBox_returnMovieId;
        private System.Windows.Forms.ListBox DisplayAllActiveRentals;
        private System.Windows.Forms.Button button_displayActiveRentals;
    }
}

