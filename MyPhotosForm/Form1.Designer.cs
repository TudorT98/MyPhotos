namespace MyPhotosForm
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
            System.Windows.Forms.TextBox isMovie;
            System.Windows.Forms.TextBox Location;
            System.Windows.Forms.TextBox Landscape;
            System.Windows.Forms.TextBox Person;
            System.Windows.Forms.TextBox Event;
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.AddLocationButton = new System.Windows.Forms.Button();
            this.AddLandscapeButton = new System.Windows.Forms.Button();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DisplayImageButton = new System.Windows.Forms.Button();
            this.ImagePath = new System.Windows.Forms.TextBox();
            this.ImagePathValue = new System.Windows.Forms.TextBox();
            this.isMovieValue = new System.Windows.Forms.CheckBox();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.LandscapeComboBox = new System.Windows.Forms.ComboBox();
            this.PersonComboBox = new System.Windows.Forms.ComboBox();
            this.UploadButton = new System.Windows.Forms.Button();
            this.EventComboBox = new System.Windows.Forms.ComboBox();
            isMovie = new System.Windows.Forms.TextBox();
            Location = new System.Windows.Forms.TextBox();
            Landscape = new System.Windows.Forms.TextBox();
            Person = new System.Windows.Forms.TextBox();
            Event = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // isMovie
            // 
            isMovie.Location = new System.Drawing.Point(322, 75);
            isMovie.Name = "isMovie";
            isMovie.ReadOnly = true;
            isMovie.Size = new System.Drawing.Size(100, 20);
            isMovie.TabIndex = 10;
            isMovie.Text = "isMovie";
            // 
            // Location
            // 
            Location.Location = new System.Drawing.Point(322, 101);
            Location.Name = "Location";
            Location.ReadOnly = true;
            Location.Size = new System.Drawing.Size(100, 20);
            Location.TabIndex = 12;
            Location.Text = "Location";
            // 
            // Landscape
            // 
            Landscape.Location = new System.Drawing.Point(322, 134);
            Landscape.Name = "Landscape";
            Landscape.ReadOnly = true;
            Landscape.Size = new System.Drawing.Size(100, 20);
            Landscape.TabIndex = 14;
            Landscape.Text = "Landscape";
            Landscape.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Person
            // 
            Person.Location = new System.Drawing.Point(322, 170);
            Person.Name = "Person";
            Person.ReadOnly = true;
            Person.Size = new System.Drawing.Size(100, 20);
            Person.TabIndex = 16;
            Person.Text = "Person";
            Person.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add an image";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(267, 147);
            this.listBox1.TabIndex = 1;
            // 
            // AddEventButton
            // 
            this.AddEventButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.AddEventButton.Location = new System.Drawing.Point(676, 12);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(112, 31);
            this.AddEventButton.TabIndex = 2;
            this.AddEventButton.Text = "Add an event";
            this.AddEventButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.eventButton_Click);
            // 
            // AddLocationButton
            // 
            this.AddLocationButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.AddLocationButton.Location = new System.Drawing.Point(676, 49);
            this.AddLocationButton.Name = "AddLocationButton";
            this.AddLocationButton.Size = new System.Drawing.Size(112, 31);
            this.AddLocationButton.TabIndex = 3;
            this.AddLocationButton.Text = "Add a location";
            this.AddLocationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.AddLocationButton.UseVisualStyleBackColor = true;
            this.AddLocationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // AddLandscapeButton
            // 
            this.AddLandscapeButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddLandscapeButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.AddLandscapeButton.Location = new System.Drawing.Point(676, 86);
            this.AddLandscapeButton.Name = "AddLandscapeButton";
            this.AddLandscapeButton.Size = new System.Drawing.Size(112, 31);
            this.AddLandscapeButton.TabIndex = 4;
            this.AddLandscapeButton.Text = "Add a landscape";
            this.AddLandscapeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.AddLandscapeButton.UseVisualStyleBackColor = false;
            this.AddLandscapeButton.Click += new System.EventHandler(this.landscapeButton_Click);
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddPersonButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.AddPersonButton.Location = new System.Drawing.Point(676, 123);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(112, 31);
            this.AddPersonButton.TabIndex = 5;
            this.AddPersonButton.Text = "Add a person";
            this.AddPersonButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.personButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // DisplayImageButton
            // 
            this.DisplayImageButton.Location = new System.Drawing.Point(148, 12);
            this.DisplayImageButton.Name = "DisplayImageButton";
            this.DisplayImageButton.Size = new System.Drawing.Size(112, 31);
            this.DisplayImageButton.TabIndex = 7;
            this.DisplayImageButton.Text = "Select Image";
            this.DisplayImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.DisplayImageButton.UseVisualStyleBackColor = true;
            this.DisplayImageButton.Click += new System.EventHandler(this.displayImageButton_Click);
            // 
            // ImagePath
            // 
            this.ImagePath.Location = new System.Drawing.Point(322, 49);
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.ReadOnly = true;
            this.ImagePath.Size = new System.Drawing.Size(100, 20);
            this.ImagePath.TabIndex = 8;
            this.ImagePath.Text = "ImagePath";
            // 
            // ImagePathValue
            // 
            this.ImagePathValue.Location = new System.Drawing.Point(437, 49);
            this.ImagePathValue.Multiline = true;
            this.ImagePathValue.Name = "ImagePathValue";
            this.ImagePathValue.ReadOnly = true;
            this.ImagePathValue.Size = new System.Drawing.Size(192, 20);
            this.ImagePathValue.TabIndex = 9;
            // 
            // isMovieValue
            // 
            this.isMovieValue.AutoSize = true;
            this.isMovieValue.Enabled = false;
            this.isMovieValue.Location = new System.Drawing.Point(437, 78);
            this.isMovieValue.Name = "isMovieValue";
            this.isMovieValue.Size = new System.Drawing.Size(15, 14);
            this.isMovieValue.TabIndex = 11;
            this.isMovieValue.UseVisualStyleBackColor = true;
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Location = new System.Drawing.Point(437, 100);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(192, 21);
            this.LocationComboBox.TabIndex = 13;
            // 
            // LandscapeComboBox
            // 
            this.LandscapeComboBox.FormattingEnabled = true;
            this.LandscapeComboBox.Location = new System.Drawing.Point(437, 133);
            this.LandscapeComboBox.Name = "LandscapeComboBox";
            this.LandscapeComboBox.Size = new System.Drawing.Size(192, 21);
            this.LandscapeComboBox.TabIndex = 15;
            // 
            // PersonComboBox
            // 
            this.PersonComboBox.FormattingEnabled = true;
            this.PersonComboBox.Location = new System.Drawing.Point(437, 170);
            this.PersonComboBox.Name = "PersonComboBox";
            this.PersonComboBox.Size = new System.Drawing.Size(192, 21);
            this.PersonComboBox.TabIndex = 17;
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(346, 239);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UploadButton.Size = new System.Drawing.Size(269, 33);
            this.UploadButton.TabIndex = 18;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadImage_Click);
            // 
            // Event
            // 
            Event.Location = new System.Drawing.Point(322, 204);
            Event.Name = "Event";
            Event.ReadOnly = true;
            Event.Size = new System.Drawing.Size(100, 20);
            Event.TabIndex = 19;
            Event.Text = "Event";
            // 
            // EventComboBox
            // 
            this.EventComboBox.FormattingEnabled = true;
            this.EventComboBox.Location = new System.Drawing.Point(437, 203);
            this.EventComboBox.Name = "EventComboBox";
            this.EventComboBox.Size = new System.Drawing.Size(192, 21);
            this.EventComboBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EventComboBox);
            this.Controls.Add(Event);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.PersonComboBox);
            this.Controls.Add(Person);
            this.Controls.Add(this.LandscapeComboBox);
            this.Controls.Add(Landscape);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(Location);
            this.Controls.Add(this.isMovieValue);
            this.Controls.Add(isMovie);
            this.Controls.Add(this.ImagePathValue);
            this.Controls.Add(this.ImagePath);
            this.Controls.Add(this.DisplayImageButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.AddLandscapeButton);
            this.Controls.Add(this.AddLocationButton);
            this.Controls.Add(this.AddEventButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.Button AddLocationButton;
        private System.Windows.Forms.Button AddLandscapeButton;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DisplayImageButton;
        private System.Windows.Forms.TextBox ImagePath;
        private System.Windows.Forms.TextBox ImagePathValue;
        private System.Windows.Forms.CheckBox isMovieValue;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.ComboBox LandscapeComboBox;
        private System.Windows.Forms.ComboBox PersonComboBox;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.ComboBox EventComboBox;
    }


}

