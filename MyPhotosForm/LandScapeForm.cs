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

namespace MyPhotosV2
{
   
    public partial class LandScapeForm : Form
    {
        LandScape landscape;
        LandScapeAPI landScapeAPI = new LandScapeAPI();
        public LandScapeForm()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {

            landscape = new LandScape(LandScapeNameValue.Text, LandScapeDescriptionValue.Text);
            MyPhotosClient myPhotoClient = new MyPhotosClient();
            myPhotoClient.AddLandScape(landscape);
            Clear();
        }
        void Clear()
        {
            LandScapeNameValue.Text = "";
            LandScapeDescriptionValue.Text = "";
            LandScapeTypeValue.Text = "";
        }
    }
}
