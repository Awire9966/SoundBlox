
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundBlox
{
    public partial class MainForm : Form
    {
        // MainForm: The form you see when first launching the program.
        public MainForm()
        {
            InitializeComponent();
        }
        public static string RobloxSoundDir;
        
        
        


        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(vars.SoundBloxDir_Sounds))
            { 
                Directory.CreateDirectory(vars.SoundBloxDir_Sounds);
                Sounds.recreate(vars.SoundBloxDir_Sounds);
            }
            if(!File.Exists(vars.SoundBlox_FFMPEG))
            {
                var response = MessageBox.Show("FFmpeg is not found! You MUST have ffmpeg to use files other than ogg files (Not much is saved in ogg files!) Would you like to download it now? (If you do, it might take a few seconds to a few minutes before the form shows up)", "oops", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(response == DialogResult.Yes)
                {
                    Get_FFMPEG.DownloadFFmpeg();
                }
            }
            if(File.Exists(vars.SoundBlox_FFMPEG))
            {
                
            }
      
            
             WebClient wc = new WebClient();
            RobloxSoundDir = wc.DownloadString(@"https://raw.githubusercontent.com/Awire9966/SoundBlox/main/roblox").Replace("{APPDATA}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).Replace("{LOCALAPPDATA}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            vars.RobloxSoundDir = RobloxSoundDir;
            BUILTINSOUNDS.Url = new Uri(vars.SoundBloxDir_Sounds);
            FEXSOUNDS.Url = new Uri(RobloxSoundDir);
           
        
        
        }

        private void transfersounds_Click(object sender, EventArgs e)
        {
            TransferSounds tfs = new TransferSounds();
            tfs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Converter cv = new Converter();
            cv.Show();
        }
    }
}
