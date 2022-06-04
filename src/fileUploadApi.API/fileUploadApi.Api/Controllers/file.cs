using System.Net;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using fileUploadApi.Core.DTO;
namespace fileUploadApi.Api.Controllers
{
    [ApiController]
    public class file : ControllerBase
    {
        [HttpPost]
        [Route("uploadFile")]
        public IActionResult uploadFile(List<IFormFile> files)
        {
            var size = files.Sum(f => f.Length);

            foreach (var formFile in files)
            {
                var p = formFile;
                if (formFile.Length > 0)
                {
                }
            }
            var res = new uploadFileDTOResponse();
            return Ok(res);
        }
    }
}