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
    public partial class EventForm : Form
    {
        Event myEvent;
        EventAPI eventAPI = new EventAPI();
        
        public EventForm()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
             myEvent = new MyPhotosV2.Event(EventNameValue.Text,EventDescriptionValue.Text);
            // eventAPI.AddEvent(myEvent);
            MyPhotosClient myPhotoClient = new MyPhotosClient();
            myPhotoClient.AddEvent(myEvent);
            Clear();
        }
        void Clear()
        {
            EventNameValue.Text = "";
            EventDescriptionValue.Text = "";
        }


    }
}
