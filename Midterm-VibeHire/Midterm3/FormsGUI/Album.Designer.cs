namespace FormsGUI
{
    partial class Album
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
            add_button = new Button();
            update_button = new Button();
            delete_button = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            id_label = new Label();
            title_label = new Label();
            genre_label = new Label();
            artist_label = new Label();
            year_label = new Label();
            list_button = new Button();
            album_list = new ListBox();
            SuspendLayout();
            // 
            // add_button
            // 
            add_button.Location = new Point(278, 320);
            add_button.Name = "add_button";
            add_button.Size = new Size(75, 23);
            add_button.TabIndex = 0;
            add_button.Text = "Add";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // update_button
            // 
            update_button.Location = new Point(359, 320);
            update_button.Name = "update_button";
            update_button.Size = new Size(75, 23);
            update_button.TabIndex = 2;
            update_button.Text = "Update";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(440, 320);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(75, 23);
            delete_button.TabIndex = 3;
            delete_button.Text = "Delete";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(222, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(222, 204);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(222, 262);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(222, 291);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 8;
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.Location = new Point(162, 175);
            id_label.Name = "id_label";
            id_label.Size = new Size(54, 15);
            id_label.TabIndex = 9;
            id_label.Text = "AlbumID";
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Location = new Point(162, 207);
            title_label.Name = "title_label";
            title_label.Size = new Size(29, 15);
            title_label.TabIndex = 10;
            title_label.Text = "Title";
            // 
            // genre_label
            // 
            genre_label.AutoSize = true;
            genre_label.Location = new Point(162, 265);
            genre_label.Name = "genre_label";
            genre_label.Size = new Size(38, 15);
            genre_label.TabIndex = 11;
            genre_label.Text = "Genre";
            // 
            // artist_label
            // 
            artist_label.AutoSize = true;
            artist_label.Location = new Point(162, 236);
            artist_label.Name = "artist_label";
            artist_label.Size = new Size(35, 15);
            artist_label.TabIndex = 12;
            artist_label.Text = "Artist";
            // 
            // year_label
            // 
            year_label.AutoSize = true;
            year_label.Location = new Point(162, 294);
            year_label.Name = "year_label";
            year_label.Size = new Size(29, 15);
            year_label.TabIndex = 13;
            year_label.Text = "Year";
            // 
            // list_button
            // 
            list_button.Location = new Point(521, 320);
            list_button.Name = "list_button";
            list_button.Size = new Size(75, 23);
            list_button.TabIndex = 14;
            list_button.Text = "List";
            list_button.UseVisualStyleBackColor = true;
            list_button.Click += list_button_Click;
            // 
            // album_list
            // 
            album_list.FormattingEnabled = true;
            album_list.ItemHeight = 15;
            album_list.Location = new Point(328, 175);
            album_list.Name = "album_list";
            album_list.Size = new Size(267, 139);
            album_list.TabIndex = 15;
            // 
            // Album
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(album_list);
            Controls.Add(list_button);
            Controls.Add(year_label);
            Controls.Add(artist_label);
            Controls.Add(genre_label);
            Controls.Add(title_label);
            Controls.Add(id_label);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Controls.Add(add_button);
            Name = "Album";
            Text = "Album";
            Load += Album_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_button;
        private Button update_button;
        private Button delete_button;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label id_label;
        private Label title_label;
        private Label genre_label;
        private Label artist_label;
        private Label year_label;
        private Button list_button;
        private ListBox album_list;
    }
}