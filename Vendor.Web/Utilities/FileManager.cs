using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Vendor.Utilities.Files
{
   public  class FileManager
    {
        private  readonly IWebHostEnvironment _environment;

        public FileManager(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public async Task<string> InsertFiles(IFormFile Filename, string FilePath)
        {
            string newFileName = string.Empty;


            newFileName = Guid.NewGuid().ToString() + Path.GetExtension(Filename.FileName);

            string ImagePath = Path.Combine(_environment.WebRootPath, FilePath) + $@"\{newFileName}";
            using (var Stream = new FileStream(ImagePath, FileMode.Create))
            {
                await Filename.CopyToAsync(Stream);
            }

            return newFileName;
        }
        public  void DeleteFiles(string Filename, string FilePath)
        {

            string DeletePath = Path.Combine(_environment.WebRootPath, FilePath) + $@"\{Filename}";
            if (System.IO.File.Exists(DeletePath))
            {
                {
                    System.IO.File.Delete(DeletePath);
                }
            }

        }
        public void EditFiles(string Filename, string FilePath)
        {
        }
        }
}
