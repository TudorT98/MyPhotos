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

namespace MyPhotos
{
    public partial class WindowsForm : Form
    {
        public WindowsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                string[] dirs = Directory.GetDirectories(folderBrowserDialog.SelectedPath);

                foreach(string file in files )
                {
                    listBox1.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in dirs)
                {
                    listBox1.Items.Add(Path.GetFileName(dir));
                }
            }
        }
    }
}
