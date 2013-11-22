using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace MusicSync
{
    class FTPManager
    {
        private FtpWebRequest request;

        public bool UpdateRequestPath(String relativePath)
        {
            UriBuilder builder = new UriBuilder(Config.ServerURL + relativePath);
            try
            {
                request = (FtpWebRequest)WebRequest.Create(builder.Uri);
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
            UpdateRequestPath("");
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Timeout = -1;
            
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            String dirStr = reader.ReadToEnd().Replace("\r","");
            String[] files = dirStr.Split('\n');

            reader.Close();
            response.Close();

            return files;
        }

        public bool UploadFile(String filePath, Form1 form)
        {
            UpdateRequestPath(System.Uri.EscapeDataString(Path.GetFileName(filePath)));
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.UseBinary = true;

            FileStream sourceStream = File.OpenRead(filePath);
            request.ContentLength = sourceStream.Length;

            Stream requestStream = request.GetRequestStream();
            var buffer = new byte[1024 * 1024];
            int totalReadBytesCount = 0;
            int readBytesCount;
            while ((readBytesCount = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                requestStream.Write(buffer, 0, readBytesCount);
                totalReadBytesCount += readBytesCount;
                var progress = totalReadBytesCount * 100.0 / sourceStream.Length;
                form.ftpTransferWorker.ReportProgress((int)progress, "File");
            }

            return false;
        }
    }
}