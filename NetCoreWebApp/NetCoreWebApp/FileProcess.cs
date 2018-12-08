using System;
using System.IO;


namespace NetCoreWebApp
{
    public class FileProcess
    {
        public bool File_exists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName");
            }

            return File.Exists(fileName);
        }
    }
}
