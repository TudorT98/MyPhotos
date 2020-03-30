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
    public partial class PersonForm : Form
    {
        Person person;
        PersonAPI personAPI = new PersonAPI();
        public PersonForm()
        {
            InitializeComponent();
        }
        private void SavePerson_Click(object sender, EventArgs e)
        {
            person = new Person(FirstNameValue.Text,LastNameValue.Text,AgeValue.Value.ToString());
            personAPI.AddPerson(person);
            Clear();
        }
        void Clear()
        {
            FirstNameValue.Text = "";
            LastNameValue.Text = "";
            AgeValue.Text = "";
        }
    }
}
