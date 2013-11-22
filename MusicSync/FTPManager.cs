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

        public bool UpdateRequestPath(String path)
        {
            request = (FtpWebRequest)WebRequest.Create(path);
            request.Credentials = new NetworkCredential(Config.Username, Config.Password);
            return true;
        }

        public void UpdateCredentials(String user, String pass)
        {
            request.Credentials = new NetworkCredential(user, pass);
        }

        public String[] GetFileList()
        {
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            String[] files = reader.ReadToEnd().Split('\n');

            reader.Close();
            response.Close();

            return files;
        }
    }
}
