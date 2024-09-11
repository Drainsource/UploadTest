using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace BlazorApp1.Contorllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            var filePath = Path.Combine("D:\\temp", file.FileName);

            using (var stream = new FileStream(filePath, FileMode.Append))
            {
                await file.CopyToAsync(stream);
            }

            return Ok();
        }
    }
}