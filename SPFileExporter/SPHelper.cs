using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPFileExporter
{
    public class SPHelper
    {
        public static bool DownloadFile(string psURL, string psFile, string psSavePath)
        {
            bool returnValue = false;

            try
            {
                Uri filename = new Uri(psURL + psFile);
                string server = filename.AbsoluteUri.Replace(filename.AbsolutePath, "");
                string serverrelative = filename.AbsolutePath;

                Microsoft.SharePoint.Client.ClientContext clientContext = new Microsoft.SharePoint.Client.ClientContext(server);
                Microsoft.SharePoint.Client.FileInformation f = Microsoft.SharePoint.Client.File.OpenBinaryDirect(clientContext, serverrelative);

                string fileName = psFile.Substring(psFile.LastIndexOf('/') + 1);

                using (var fileStream = new FileStream(psSavePath + fileName, FileMode.Create))
                {
                    f.Stream.CopyTo(fileStream);
                }

                returnValue = true;
            }
            catch
            {
                returnValue = false;
            }

            return returnValue;
        }

    }
}
