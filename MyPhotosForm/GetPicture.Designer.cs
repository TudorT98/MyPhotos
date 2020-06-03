namespace MyPhotosForm
{
    partial class GetPicture
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
            this.Location = new System.Windows.Forms.TextBox();
            this.LandScape = new System.Windows.Forms.TextBox();
            this.Event = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LocationComb = new System.Windows.Forms.ComboBox();
            this.LandScapeComb = new System.Windows.Forms.ComboBox();
            this.EventComb = new System.Windows.Forms.ComboBox();
            this.PersonComb = new System.Windows.Forms.ComboBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.PictureList = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LocationUpdateText = new System.Windows.Forms.TextBox();
            this.LandScapeUpdateText = new System.Windows.Forms.TextBox();
            this.EventUpdateText = new System.Windows.Forms.TextBox();
            this.LocationUpdateComb = new System.Windows.Forms.ComboBox();
            this.LandScapeUpdateComb = new System.Windows.Forms.ComboBox();
            this.EventUpdateComb = new System.Windows.Forms.ComboBox();
            this.PersonUpdateText = new System.Windows.Forms.TextBox();
            this.PersonUpdateComb = new System.Windows.Forms.ComboBox();
            this.UpdateTitle = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(12, 27);
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Size = new System.Drawing.Size(100, 20);
            this.Location.TabIndex = 0;
            this.Location.Text = "Location";
            // 
            // LandScape
            // 
            this.LandScape.Location = new System.Drawing.Point(12, 53);
            this.LandScape.Name = "LandScape";
            this.LandScape.ReadOnly = true;
            this.LandScape.Size = new System.Drawing.Size(100, 20);
            this.LandScape.TabIndex = 1;
            this.LandScape.Text = "LandScape";
            // 
            // Event
            // 
            this.Event.Location = new System.Drawing.Point(12, 79);
            this.Event.Name = "Event";
            this.Event.ReadOnly = true;
            this.Event.Size = new System.Drawing.Size(100, 20);
            this.Event.TabIndex = 2;
            this.Event.Text = "Event";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Person";
            // 
            // LocationComb
            // 
            this.LocationComb.FormattingEnabled = true;
            this.LocationComb.Location = new System.Drawing.Point(118, 26);
            this.LocationComb.Name = "LocationComb";
            this.LocationComb.Size = new System.Drawing.Size(121, 21);
            this.LocationComb.TabIndex = 4;
            // 
            // LandScapeComb
            // 
            this.LandScapeComb.FormattingEnabled = true;
            this.LandScapeComb.Location = new System.Drawing.Point(118, 53);
            this.LandScapeComb.Name = "LandScapeComb";
            this.LandScapeComb.Size = new System.Drawing.Size(121, 21);
            this.LandScapeComb.TabIndex = 5;
            // 
            // EventComb
            // 
            this.EventComb.FormattingEnabled = true;
            this.EventComb.Location = new System.Drawing.Point(118, 78);
            this.EventComb.Name = "EventComb";
            this.EventComb.Size = new System.Drawing.Size(121, 21);
            this.EventComb.TabIndex = 6;
            // 
            // PersonComb
            // 
            this.PersonComb.FormattingEnabled = true;
            this.PersonComb.Location = new System.Drawing.Point(118, 104);
            this.PersonComb.Name = "PersonComb";
            this.PersonComb.Size = new System.Drawing.Size(121, 21);
            this.PersonComb.TabIndex = 7;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(12, 131);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(227, 46);
            this.FindButton.TabIndex = 8;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // PictureList
            // 
            this.PictureList.HideSelection = false;
            this.PictureList.Location = new System.Drawing.Point(264, 26);
            this.PictureList.Name = "PictureList";
            this.PictureList.Size = new System.Drawing.Size(512, 151);
            this.PictureList.TabIndex = 9;
            this.PictureList.UseCompatibleStateImageBehavior = false;
            this.PictureList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 255);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // LocationUpdateText
            // 
            this.LocationUpdateText.Location = new System.Drawing.Point(505, 243);
            this.LocationUpdateText.Name = "LocationUpdateText";
            this.LocationUpdateText.ReadOnly = true;
            this.LocationUpdateText.Size = new System.Drawing.Size(100, 20);
            this.LocationUpdateText.TabIndex = 11;
            this.LocationUpdateText.Text = "Location";
            // 
            // LandScapeUpdateText
            // 
            this.LandScapeUpdateText.Location = new System.Drawing.Point(505, 269);
            this.LandScapeUpdateText.Name = "LandScapeUpdateText";
            this.LandScapeUpdateText.ReadOnly = true;
            this.LandScapeUpdateText.Size = new System.Drawing.Size(100, 20);
            this.LandScapeUpdateText.TabIndex = 12;
            this.LandScapeUpdateText.Text = "LandScape";
            // 
            // EventUpdateText
            // 
            this.EventUpdateText.Location = new System.Drawing.Point(505, 295);
            this.EventUpdateText.Name = "EventUpdateText";
            this.EventUpdateText.ReadOnly = true;
            this.EventUpdateText.Size = new System.Drawing.Size(100, 20);
            this.EventUpdateText.TabIndex = 13;
            this.EventUpdateText.Text = "Event";
            // 
            // LocationUpdateComb
            // 
            this.LocationUpdateComb.FormattingEnabled = true;
            this.LocationUpdateComb.Location = new System.Drawing.Point(611, 242);
            this.LocationUpdateComb.Name = "LocationUpdateComb";
            this.LocationUpdateComb.Size = new System.Drawing.Size(121, 21);
            this.LocationUpdateComb.TabIndex = 15;
            this.LocationUpdateComb.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // LandScapeUpdateComb
            // 
            this.LandScapeUpdateComb.FormattingEnabled = true;
            this.LandScapeUpdateComb.Location = new System.Drawing.Point(611, 269);
            this.LandScapeUpdateComb.Name = "LandScapeUpdateComb";
            this.LandScapeUpdateComb.Size = new System.Drawing.Size(121, 21);
            this.LandScapeUpdateComb.TabIndex = 16;
            this.LandScapeUpdateComb.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // EventUpdateComb
            // 
            this.EventUpdateComb.FormattingEnabled = true;
            this.EventUpdateComb.Location = new System.Drawing.Point(611, 294);
            this.EventUpdateComb.Name = "EventUpdateComb";
            this.EventUpdateComb.Size = new System.Drawing.Size(121, 21);
            this.EventUpdateComb.TabIndex = 17;
            this.EventUpdateComb.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // PersonUpdateText
            // 
            this.PersonUpdateText.Location = new System.Drawing.Point(505, 321);
            this.PersonUpdateText.Name = "PersonUpdateText";
            this.PersonUpdateText.ReadOnly = true;
            this.PersonUpdateText.Size = new System.Drawing.Size(100, 20);
            this.PersonUpdateText.TabIndex = 18;
            this.PersonUpdateText.Text = "Person";
            // 
            // PersonUpdateComb
            // 
            this.PersonUpdateComb.FormattingEnabled = true;
            this.PersonUpdateComb.Location = new System.Drawing.Point(611, 321);
            this.PersonUpdateComb.Name = "PersonUpdateComb";
            this.PersonUpdateComb.Size = new System.Drawing.Size(121, 21);
            this.PersonUpdateComb.TabIndex = 19;
            // 
            // UpdateTitle
            // 
            this.UpdateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateTitle.Location = new System.Drawing.Point(505, 207);
            this.UpdateTitle.Name = "UpdateTitle";
            this.UpdateTitle.ReadOnly = true;
            this.UpdateTitle.Size = new System.Drawing.Size(227, 29);
            this.UpdateTitle.TabIndex = 20;
            this.UpdateTitle.Text = "UpdatePicture";
            this.UpdateTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateTitle.TextChanged += new System.EventHandler(this.UpdateTitle_TextChanged);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(505, 347);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(227, 29);
            this.UpdateButton.TabIndex = 21;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // GetPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UpdateTitle);
            this.Controls.Add(this.PersonUpdateComb);
            this.Controls.Add(this.PersonUpdateText);
            this.Controls.Add(this.EventUpdateComb);
            this.Controls.Add(this.LandScapeUpdateComb);
            this.Controls.Add(this.LocationUpdateComb);
            this.Controls.Add(this.EventUpdateText);
            this.Controls.Add(this.LandScapeUpdateText);
            this.Controls.Add(this.LocationUpdateText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PictureList);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.PersonComb);
            this.Controls.Add(this.EventComb);
            this.Controls.Add(this.LandScapeComb);
            this.Controls.Add(this.LocationComb);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Event);
            this.Controls.Add(this.LandScape);
            this.Controls.Add(this.Location);
            this.Name = "GetPicture";
            this.Text = "GetPicture";
            this.Load += new System.EventHandler(this.GetPicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.TextBox LandScape;
        private System.Windows.Forms.TextBox Event;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox LocationComb;
        private System.Windows.Forms.ComboBox LandScapeComb;
        private System.Windows.Forms.ComboBox EventComb;
        private System.Windows.Forms.ComboBox PersonComb;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.ListView PictureList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LocationUpdateText;
        private System.Windows.Forms.TextBox LandScapeUpdateText;
        private System.Windows.Forms.TextBox EventUpdateText;
        private System.Windows.Forms.ComboBox LocationUpdateComb;
        private System.Windows.Forms.ComboBox LandScapeUpdateComb;
        private System.Windows.Forms.ComboBox EventUpdateComb;
        private System.Windows.Forms.TextBox PersonUpdateText;
        private System.Windows.Forms.ComboBox PersonUpdateComb;
        private System.Windows.Forms.TextBox UpdateTitle;
        private System.Windows.Forms.Button UpdateButton;
    }
}