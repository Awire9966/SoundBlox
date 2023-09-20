using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CG.Web.MegaApiClient;
using System.IO;
using System.IO.Compression;

namespace SoundBlox
{
    public static class Get_FFMPEG
    {
        public static void DownloadFFmpeg()
        {
            MegaApiClient client = new MegaApiClient();
            client.LoginAnonymous();

            Uri fileLink = new Uri("https://mega.nz/file/akMCkZTC#6CzHs4YjU1zeS3BO2m5j1YdkiOLJYvtuoty7XKbdhN8");
            INode node = client.GetNodeFromLink(fileLink);

            
            client.DownloadFile(fileLink, node.Name);
            

            client.Logout();
        }
    }
}
