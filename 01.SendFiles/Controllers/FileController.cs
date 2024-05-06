using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _01.SendFiles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(IFormFile file)
        {
            var filePath = "C:\\Temp\\" + file.FileName;
            using (var stream = System.IO.File.Create(filePath))
            {
                file.CopyTo(stream);
            }

            return Ok();
        }

        [HttpGet]
        public FileResult DownloadFile()
        {
            var fileBytes = System.IO.File.ReadAllBytes("forest.jpg");
            var fileName = $"{Guid.NewGuid().ToString("N")}.jpg";
            return File(fileBytes, "application/octet-stream", fileName);
        }
    }
}
