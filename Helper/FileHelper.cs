using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.BL.Helper
{
    public static class FileHelper
    {
        public static string SaveFile(string FolderPath, IFormFile File)
        {
            try
            {
                // 1 ) Merge PhysicalPath and FolderPath
                string PhysicalPath = Path.Combine(Directory.GetCurrentDirectory() + "/wwwroot", FolderPath);

                // 2 ) Get File Name
                string FileName = Guid.NewGuid() + Path.GetFileName(File.FileName);

                // 3 ) Merge Path with File Name
                string FinalPath = Path.Combine(PhysicalPath, FileName);

                // 4 ) Save File As Streams "Data Overtime"
                using (var Stream = new FileStream(FinalPath, FileMode.Create))
                {
                    File.CopyTo(Stream);
                }

                return FileName;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string FileRemove(string FolderPath, string FileName)
        {
            try
            {

                if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", FolderPath, FileName)))
                {
                    File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", FolderPath, FileName));
                }

                return "Removed";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
