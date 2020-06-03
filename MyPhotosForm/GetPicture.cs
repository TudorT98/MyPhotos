using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPhotosV2;

namespace MyPhotosForm
{
    public partial class GetPicture : Form
    {

        LocationAPI locationAPI = new LocationAPI();
        LandScapeAPI LandScapeAPI = new LandScapeAPI();
        PersonAPI PersonAPI = new PersonAPI();
        EventAPI EventAPI = new EventAPI();
        PhotsAPI photsAPI = new PhotsAPI();
        MyPhotosClient myPhotoClient = new MyPhotosClient();
        Photo selectedPhoto;

        List<string> eventsName;
        List<string> locationsName;
        List<string> peopleName;
        List<string> landScapesName;

        public GetPicture()
        {
            InitializeComponent();

            //Populate events Combobox
            eventsName = myPhotoClient.GetEventsName();
            ComboBox eventComboBox = EventComb;
            ComboBox updateEvent = EventUpdateComb;
            foreach (string photoEvent in eventsName)
            {
                eventComboBox.Items.Add(photoEvent);
                updateEvent.Items.Add(photoEvent);
            }
            //Populate locations Combobox
            locationsName = myPhotoClient.GetLocationsName();
            ComboBox locationComboBox = LocationComb;
            ComboBox updateLocation = LocationUpdateComb;
            foreach (string location in locationsName)
            {
                locationComboBox.Items.Add(location);
                updateLocation.Items.Add(location);
            }
            //Populate people Combobox
            peopleName = myPhotoClient.GetPeopleName();
            ComboBox peopleComboBox = PersonComb;
            ComboBox updatePeople = PersonUpdateComb;
            foreach (string person in peopleName)
            {
                peopleComboBox.Items.Add(person);
                updatePeople.Items.Add(person);
            }
            //Populate landScape Combobox
            landScapesName = myPhotoClient.GetLandScapeName();
            ComboBox landScapeComboBox = LandScapeComb;
            ComboBox updateLandScape = LandScapeUpdateComb;
            foreach (string landscape in landScapesName)
            {
                landScapeComboBox.Items.Add(landscape);
                updateLandScape.Items.Add(landscape);
            }
       
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = PictureList.SelectedItems[0].Text.ToString();
            path = path.Replace(@"\\", @"\");
            pictureBox1.Image = Image.FromFile(path);

        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            List<Photo> photos;
            MyPhotosClient myPhotoClient = new MyPhotosClient();
            string LocationName = LocationComb.Text;
            string LandScapeName = LandScapeComb.Text;
            string PersonName = PersonComb.Text;
            string EventName = EventComb.Text;
            int LocationId = myPhotoClient.GetIdByName(LocationName);
            int LandScapeId = myPhotoClient.GetIdByName(LandScapeName);
            int PersonId = myPhotoClient.GetIdByName(PersonName.Substring(0, PersonName.IndexOf(" ")));
            int EventId = myPhotoClient.GetIdByName(EventName);

           
            photos = myPhotoClient.GetPhoto(LocationId, LandScapeId, PersonId, EventId);
            if(photos.Count > 0)
            {
                foreach(Photo photo in photos)
                {
                    if (File.Exists(photo.FullPath))
                    {
                        PictureList.Items.Add(photo.FullPath);
                        selectedPhoto = photo;
                    }
                    else
                    {
                        myPhotoClient.UpdateIsRemoved(photo);
                    }
                }
            }
            else
            {
                PictureList.Items.Clear();
                pictureBox1.Image = null;
            }

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void GetPicture_Load(object sender, EventArgs e){}
        

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e) { }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e) {}
       

        private void UpdateTitle_TextChanged(object sender, EventArgs e) {}
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            MyPhotosClient myPhotoClient = new MyPhotosClient();

            if (selectedPhoto != null)
            {
                string LocationName = LocationUpdateComb.Text;
                string LandScapeName = LandScapeUpdateComb.Text;
                string PersonName = PersonUpdateComb.Text;
                string EventName = EventUpdateComb.Text;
                int LocationId;
                int LandScapeId;
                int PersonId;
                int EventId;
                if (LocationName != "")
                {
                     LocationId = myPhotoClient.GetIdByName(LocationName);
                }
                else
                {
                    LocationId = selectedPhoto.LocationId; 
                }
                if (LandScapeName != "")
                {
                    LandScapeId = myPhotoClient.GetIdByName(LandScapeName);
                }
                else
                {
                    LandScapeId = selectedPhoto.LandScapeId;
                }
                if (PersonName != "")
                {
                    PersonId = myPhotoClient.GetIdByName(PersonName.Substring(0, PersonName.IndexOf(" ")));
                }
                else
                {
                    PersonId = selectedPhoto.PersonId;
                }
                if (EventName != "")
                {
                    EventId = myPhotoClient.GetIdByName(EventName);
                }
                else
                {
                    EventId = selectedPhoto.EventId;
                }

              //  myPhotoClient.UpdatePhoto(selectedPhoto, EventId, LandScapeId, PersonId, LocationId);

            }
            else
            {
                MessageBox.Show("No image selected");
            }



        }

    }
}
