using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MusicSync
{
    class FTPManager
    {
        private FtpWebRequest request;

        public FTPManager()
        {
            UpdateRequestPath();
        }

        public bool UpdateRequestPath()
        {
            try
            {
                request = (FtpWebRequest)WebRequest.Create(new Uri(Config.ServerURL, UriKind.Absolute));
                request.Credentials = new NetworkCredential(Config.Username, Config.Password);
                return true;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return false;
            }
        }

        public String[] GetFileList()
        {
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            String dirStr = reader.ReadToEnd().Replace("\r","");
            String[] files = dirStr.Split('\n');

            reader.Close();
            response.Close();

            return files;
        }
    }
}
