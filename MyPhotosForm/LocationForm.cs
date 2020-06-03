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
    public partial class LocationForm : Form
    {
        MyPhotosV2.Location location;
        LocationAPI locationApi = new LocationAPI();
        public LocationForm()
        {
            InitializeComponent();
           
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            location = new Location(LocationNameValue.Text,LocationDescriptionValue.Text,LocationTypeValue.Text);
            MyPhotosClient myPhotoClient = new MyPhotosClient();
            myPhotoClient.AddLocation(location);
            Clear();
        }
        void Clear()
        {
            LocationNameValue.Text = "";
            LocationDescriptionValue.Text = "";
            LocationTypeValue.Text = "";
        }
    }
}
