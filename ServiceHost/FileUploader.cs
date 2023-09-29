using _0_Framework.Application;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ServiceHost
{
    public class FileUploader : IFileUploader
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUploader(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public string Upload(IFormFile file)
        {
            if (file == null)
                return "";
            var path =$"{_webHostEnvironment.WebRootPath}//ProductPictures//{file.FileName}";
            using var output = System.IO.File.Create(path);
            file.CopyToAsync(output);
            return file.FileName;
        }
    }
}