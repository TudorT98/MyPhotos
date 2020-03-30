using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyPhotosV2;

namespace MyPhotosForm
{
    public partial class Form1 : Form
    {
        EventAPI eventAPI = new EventAPI();
        LocationAPI locationAPI = new LocationAPI();
        PersonAPI personAPI = new PersonAPI();
        LandScapeAPI landScapeAPI = new LandScapeAPI();
        PhotsAPI photosAPI = new PhotsAPI();
        Photo photo;
       
        List<string> eventsName;
        List<string> locationsName;
        List<string> peopleName;
        List<string> landScapesName;
        public Form1()
        {
            InitializeComponent();
            //Populate event ComboBox
            eventsName = eventAPI.GetEventsName();
            ComboBox eventComboBox = EventComboBox;
            foreach(string photoEvent in eventsName)
            {
                eventComboBox.Items.Add(photoEvent);
            }
            //Populate locations Combobox
            locationsName = locationAPI.GetLocationsName();
            ComboBox locationComboBox = LocationComboBox;
            foreach (string location in locationsName)
            {
                locationComboBox.Items.Add(location);
            }
            //Populate people Combobox
            peopleName = personAPI.GetPeopleName();
            ComboBox peopleComboBox = PersonComboBox;
            foreach (string person in peopleName)
            {
                peopleComboBox.Items.Add(person);
            }
            //Populate people Combobox
            landScapesName = landScapeAPI.GetLandScapeName();
            ComboBox landScapeComboBox = LandscapeComboBox;
            foreach (string landscape in landScapesName)
            {
                landScapeComboBox.Items.Add(landscape);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                string[] dirs = Directory.GetDirectories(folderBrowserDialog.SelectedPath);

                foreach (string file in files)
                {
                    if(file.EndsWith(".png") || file.EndsWith(".jpg"))
                    listBox1.Items.Add(file);
                }
                foreach (string dir in dirs)
                {
                    listBox1.Items.Add(dir);
                }
            }
            Console.WriteLine("Button Clicked");
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
        }
        private void locationButton_Click(object sender, EventArgs e)
        {
            LocationForm locationForm = new LocationForm();
            locationForm.ShowDialog();

        }
        private void landscapeButton_Click(object sender, EventArgs e)
        {
            LandScapeForm landScapeForm = new LandScapeForm();
            landScapeForm.ShowDialog();
        }
        private void personButton_Click(object sender, EventArgs e)
        {
            PersonForm personForm = new PersonForm();
            personForm.ShowDialog();
        }
        private void displayImageButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string path = listBox1.GetItemText(listBox1.SelectedItem.ToString());
                ImagePathValue.Text = path;
                if(path.EndsWith(".png") || path.EndsWith(".jpg"))
                {
                    isMovieValue.Checked = true;
                }
                else
                {
                    isMovieValue.Checked = false;
                }
                path = path.Replace(@"\", @"\\");
                pictureBox1.Image = Image.FromFile(path);
                
            }
            else
            {
                MessageBox.Show("No image selected");
            }

        }
        private void UploadImage_Click(object sender, EventArgs e)
        {
            if(!(ImagePathValue.Text == ""))
            {
                int LandscapeId = landScapeAPI.GetIdByName(LandscapeComboBox.Text);
                int EventId = eventAPI.GetIdByName(EventComboBox.Text);
                int LocationId = locationAPI.GetIdByName(LocationComboBox.Text);

                LandScape landScape = landScapeAPI.GetLandScapeByName(LandscapeComboBox.Text);
                Event @event = eventAPI.GetEventByName(EventComboBox.Text);
                Location location = locationAPI.GetLocationByName(LocationComboBox.Text);
                Person person = personAPI.GetPersonByName(PersonComboBox.Text.Substring(0, PersonComboBox.Text.IndexOf(" ")));
                string isMovie = "false";
                if(isMovieValue.Checked == true)
                {
                    isMovie = "true";
                }
                //photo = new Photo(ImagePathValue.Text, isMovie, "false");
                //photo = new Photo(EventId, LocationId, LandscapeId, ImagePathValue.Text, isMovie, "false");
                // photo = new Photo(person,@event, location, landScape, ImagePathValue.Text, isMovie, "false");
                photo = new Photo(ImagePathValue.Text, isMovie, "false", location, landScape, @event, person);
               // photo.Location = location;
               // photo.LandScape = landScape;
               // photo.Event = @event;
               // photo.Person = null;

                photosAPI.AddPhoto(photo);
                
            }

        }
        private void GetPicture_Click(object sender, EventArgs e)
        {
            GetPicture getPicture = new GetPicture();
            getPicture.ShowDialog();
        }
            

            private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
