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

namespace SoundBlox
{
    public partial class TransferSounds : Form
    {
        public TransferSounds()
        {
            InitializeComponent();
        }

        private void TransferSounds_Load(object sender, EventArgs e)
        {
            foreach (string file in Directory.GetFiles(vars.SoundBloxDir_Sounds))
            {
                string[] tobefiltered = file.Split(char.Parse(@"\"));
                comboBox1.Items.Add(tobefiltered[tobefiltered.Length - 1]);

            }
            foreach (string file in Directory.GetFiles(vars.RobloxSoundDir))
            {
                string[] tobefiltered = file.Split(char.Parse(@"\"));
                comboBox2.Items.Add(tobefiltered[tobefiltered.Length - 1]);

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
           File.Copy(vars.SoundBloxDir_Sounds + comboBox1.Text, vars.RobloxSoundDir + comboBox2.Text);
        }
    }
}
