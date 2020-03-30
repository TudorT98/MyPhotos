using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        List<string> eventsName;
        List<string> locationsName;
        List<string> peopleName;
        List<string> landScapesName;

        public GetPicture()
        {
            InitializeComponent();
            eventsName = EventAPI.GetEventsName();
            ComboBox eventComboBox = EventComb;
            foreach (string photoEvent in eventsName)
            {
                eventComboBox.Items.Add(photoEvent);
            }
            //Populate locations Combobox
            locationsName = locationAPI.GetLocationsName();
            ComboBox locationComboBox = LocationComb;
            foreach (string location in locationsName)
            {
                locationComboBox.Items.Add(location);
            }
            //Populate people Combobox
            peopleName = PersonAPI.GetPeopleName();
            ComboBox peopleComboBox = PersonComb;
            foreach (string person in peopleName)
            {
                peopleComboBox.Items.Add(person);
            }
            //Populate people Combobox
            landScapesName = LandScapeAPI.GetLandScapeName();
            ComboBox landScapeComboBox = LandScapeComb;
            foreach (string landscape in landScapesName)
            {
                landScapeComboBox.Items.Add(landscape);
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
            string LocationName = LocationComb.Text;
            string LandScapeName = LandScapeComb.Text;
            string PersonName = PersonComb.Text;
            string EventName = EventComb.Text;
            int LocationId = locationAPI.GetIdByName(LocationName);
            int LandScapeId = LandScapeAPI.GetIdByName(LandScapeName);
            int PersonId = PersonAPI.GetIdByName(PersonName.Substring(0, PersonName.IndexOf(" ")));
            int EventId = EventAPI.GetIdByName(EventName);

           photos = photsAPI.GetPhoto(LocationId, LandScapeId, PersonId, EventId);
            if(photos.Count > 0)
            {
                foreach(Photo photo in photos)
                {
                    PictureList.Items.Add(photo.FullPath);
                }
            }

        }

       
    }
}
