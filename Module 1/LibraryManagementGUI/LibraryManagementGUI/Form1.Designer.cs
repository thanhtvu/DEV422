namespace LibraryManagementGUI
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
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.textBox_ISBN = new System.Windows.Forms.TextBox();
            this.textBox_category = new System.Windows.Forms.TextBox();
            this.button_addBook = new System.Windows.Forms.Button();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_userType = new System.Windows.Forms.TextBox();
            this.button_addUser = new System.Windows.Forms.Button();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.textBox_BookID = new System.Windows.Forms.TextBox();
            this.button_borrowBook = new System.Windows.Forms.Button();
            this.button_listAllBook = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBox_deleteBook = new System.Windows.Forms.TextBox();
            this.button_deleteBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(13, 13);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(100, 20);
            this.textBox_title.TabIndex = 0;
            this.textBox_title.Text = "Title";
            this.textBox_title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(163, 12);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(100, 20);
            this.textBox_Author.TabIndex = 1;
            this.textBox_Author.Text = "Author";
            this.textBox_Author.TextChanged += new System.EventHandler(this.textBox_Author_TextChanged);
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.Location = new System.Drawing.Point(302, 12);
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.Size = new System.Drawing.Size(100, 20);
            this.textBox_ISBN.TabIndex = 2;
            this.textBox_ISBN.Text = "ISBN";
            this.textBox_ISBN.TextChanged += new System.EventHandler(this.textBox_ISBN_TextChanged);
            // 
            // textBox_category
            // 
            this.textBox_category.Location = new System.Drawing.Point(442, 12);
            this.textBox_category.Name = "textBox_category";
            this.textBox_category.Size = new System.Drawing.Size(100, 20);
            this.textBox_category.TabIndex = 3;
            this.textBox_category.Text = "Category";
            // 
            // button_addBook
            // 
            this.button_addBook.Location = new System.Drawing.Point(600, 9);
            this.button_addBook.Name = "button_addBook";
            this.button_addBook.Size = new System.Drawing.Size(75, 23);
            this.button_addBook.TabIndex = 4;
            this.button_addBook.Text = "Add Book";
            this.button_addBook.UseVisualStyleBackColor = true;
            this.button_addBook.Click += new System.EventHandler(this.button_addBook_Click);
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(13, 88);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(100, 20);
            this.textBox_userName.TabIndex = 5;
            this.textBox_userName.Text = "Name";
            this.textBox_userName.TextChanged += new System.EventHandler(this.textBox_userName_TextChanged);
            // 
            // textBox_userType
            // 
            this.textBox_userType.Location = new System.Drawing.Point(163, 87);
            this.textBox_userType.Name = "textBox_userType";
            this.textBox_userType.Size = new System.Drawing.Size(100, 20);
            this.textBox_userType.TabIndex = 6;
            this.textBox_userType.Text = "User Type";
            // 
            // button_addUser
            // 
            this.button_addUser.Location = new System.Drawing.Point(600, 88);
            this.button_addUser.Name = "button_addUser";
            this.button_addUser.Size = new System.Drawing.Size(75, 23);
            this.button_addUser.TabIndex = 9;
            this.button_addUser.Text = "Add User";
            this.button_addUser.UseVisualStyleBackColor = true;
            this.button_addUser.Click += new System.EventHandler(this.button_addUser_ClickAsync);
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Location = new System.Drawing.Point(13, 166);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(100, 20);
            this.textBox_UserID.TabIndex = 10;
            this.textBox_UserID.Text = "UserID";
            // 
            // textBox_BookID
            // 
            this.textBox_BookID.Location = new System.Drawing.Point(163, 166);
            this.textBox_BookID.Name = "textBox_BookID";
            this.textBox_BookID.Size = new System.Drawing.Size(100, 20);
            this.textBox_BookID.TabIndex = 11;
            this.textBox_BookID.Text = "BookID";
            // 
            // button_borrowBook
            // 
            this.button_borrowBook.Location = new System.Drawing.Point(600, 166);
            this.button_borrowBook.Name = "button_borrowBook";
            this.button_borrowBook.Size = new System.Drawing.Size(75, 23);
            this.button_borrowBook.TabIndex = 12;
            this.button_borrowBook.Text = "Borrow Book";
            this.button_borrowBook.UseVisualStyleBackColor = true;
            this.button_borrowBook.Click += new System.EventHandler(this.button_borrowBook_Click);
            // 
            // button_listAllBook
            // 
            this.button_listAllBook.Location = new System.Drawing.Point(600, 248);
            this.button_listAllBook.Name = "button_listAllBook";
            this.button_listAllBook.Size = new System.Drawing.Size(75, 23);
            this.button_listAllBook.TabIndex = 13;
            this.button_listAllBook.Text = "List All Books";
            this.button_listAllBook.UseVisualStyleBackColor = true;
            this.button_listAllBook.Click += new System.EventHandler(this.button_displayAllBooks);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(13, 248);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(529, 160);
            this.listBox.TabIndex = 14;
            // 
            // textBox_deleteBook
            // 
            this.textBox_deleteBook.Location = new System.Drawing.Point(600, 304);
            this.textBox_deleteBook.Name = "textBox_deleteBook";
            this.textBox_deleteBook.Size = new System.Drawing.Size(100, 20);
            this.textBox_deleteBook.TabIndex = 15;
            this.textBox_deleteBook.Text = "ID to Delete Book";
            // 
            // button_deleteBook
            // 
            this.button_deleteBook.Location = new System.Drawing.Point(706, 301);
            this.button_deleteBook.Name = "button_deleteBook";
            this.button_deleteBook.Size = new System.Drawing.Size(75, 23);
            this.button_deleteBook.TabIndex = 16;
            this.button_deleteBook.Text = "Delete Book by ID";
            this.button_deleteBook.UseVisualStyleBackColor = true;
            this.button_deleteBook.Click += new System.EventHandler(this.button_deleteBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_deleteBook);
            this.Controls.Add(this.textBox_deleteBook);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.button_listAllBook);
            this.Controls.Add(this.button_borrowBook);
            this.Controls.Add(this.textBox_BookID);
            this.Controls.Add(this.textBox_UserID);
            this.Controls.Add(this.button_addUser);
            this.Controls.Add(this.textBox_userType);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.button_addBook);
            this.Controls.Add(this.textBox_category);
            this.Controls.Add(this.textBox_ISBN);
            this.Controls.Add(this.textBox_Author);
            this.Controls.Add(this.textBox_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.TextBox textBox_ISBN;
        private System.Windows.Forms.TextBox textBox_category;
        private System.Windows.Forms.Button button_addBook;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_userType;
        private System.Windows.Forms.Button button_addUser;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.TextBox textBox_BookID;
        private System.Windows.Forms.Button button_borrowBook;
        private System.Windows.Forms.Button button_listAllBook;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBox_deleteBook;
        private System.Windows.Forms.Button button_deleteBook;
    }
}

