
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundBlox
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Media Files|*.*";
            ofd.Multiselect = false;
            ofd.Title = "Open a file to be converted.";
            ofd.RestoreDirectory = true;
            if(ofd.ShowDialog() == DialogResult.OK) 
            { 
               textBox1.Text = ofd.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Media Files|*.*";
          
            sfd.Title = "Open a file to be converted.";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = sfd.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

                Process.Start(vars.SoundBlox_FFMPEG, "-i \"" + textBox1.Text + "\" \"" + textBox2.Text + "\"");
            
            }
    }
}
