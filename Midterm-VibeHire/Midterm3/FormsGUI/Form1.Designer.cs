namespace FormsGUI
{
    partial class Form1
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
            music_button = new Button();
            album_button = new Button();
            playlist_button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // music_button
            // 
            music_button.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            music_button.Location = new Point(151, 473);
            music_button.Margin = new Padding(6);
            music_button.Name = "music_button";
            music_button.Size = new Size(357, 149);
            music_button.TabIndex = 0;
            music_button.Text = "Music Rental";
            music_button.UseVisualStyleBackColor = true;
            music_button.Click += music_button_Click;
            // 
            // album_button
            // 
            album_button.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            album_button.Location = new Point(937, 474);
            album_button.Margin = new Padding(6);
            album_button.Name = "album_button";
            album_button.Size = new Size(357, 142);
            album_button.TabIndex = 1;
            album_button.Text = "Album";
            album_button.UseVisualStyleBackColor = true;
            album_button.Click += album_button_Click;
            // 
            // playlist_button
            // 
            playlist_button.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playlist_button.Location = new Point(544, 473);
            playlist_button.Margin = new Padding(6);
            playlist_button.Name = "playlist_button";
            playlist_button.Size = new Size(357, 143);
            playlist_button.TabIndex = 2;
            playlist_button.Text = "Playlist";
            playlist_button.UseVisualStyleBackColor = true;
            playlist_button.Click += playlist_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(574, 72);
            label1.Name = "label1";
            label1.Size = new Size(309, 86);
            label1.TabIndex = 3;
            label1.Text = "VibeHive";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(2734, 1120);
            label2.Name = "label2";
            label2.Size = new Size(437, 50);
            label2.TabIndex = 4;
            label2.Text = "Integrated Music Rental";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(641, 204);
            label3.Name = "label3";
            label3.Size = new Size(447, 50);
            label3.TabIndex = 5;
            label3.Text = "Integrated Music Rental,";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(854, 269);
            label4.Name = "label4";
            label4.Size = new Size(291, 50);
            label4.TabIndex = 6;
            label4.Text = "Playlist Builder,";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(819, 338);
            label5.Name = "label5";
            label5.Size = new Size(475, 50);
            label5.TabIndex = 7;
            label5.Text = "and Album Inventory Hub";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.music;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1467, 831);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(playlist_button);
            Controls.Add(album_button);
            Controls.Add(music_button);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button music_button;
        private Button album_button;
        private Button playlist_button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
