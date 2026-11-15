using KooliProjekt.Application.Infrastructure.Results;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace KooliProjekt.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiControllerBase : Controller
    {
        private static JsonSerializerSettings _serializerSettings =
            new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
#if(DEBUG)
                Formatting = Formatting.Indented,
#endif
                NullValueHandling = NullValueHandling.Ignore
            };

        protected IActionResult Result(OperationResult result)
        {
            var serialized = JsonConvert.SerializeObject(result, _serializerSettings);

            if (result.HasErrors)
            {
                return BadRequest(serialized);
            }

            return Ok(serialized);
        }

        protected IActionResult Result<T>(OperationResult<T> result)
        {
            var serialized = JsonConvert.SerializeObject(result, _serializerSettings);

            if (result.HasErrors)
            {
                return BadRequest(serialized);
            }

            if (result.Value == null)
            {
                return NotFound();
            }

            return Ok(serialized);
        }

        protected IActionResult Result(OperationResult<Stream> result)
        {
            if (result.HasErrors)
            {
                return BadRequest();
            }

            if (result.Value == null)
            {
                return NotFound();
            }

            return File(result.Value, "image/jpeg");
        }

        protected async Task<IActionResult> Result(OperationResult<List<Stream>> result)
        {
            if (result.HasErrors)
            {
                return BadRequest();
            }

            if (result.Value == null || result.Value.Count == 0)
            {
                return NotFound();
            }

            using var memoryStream = new MemoryStream();

            using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
            {
                for (int i = 0; i < result.Value.Count; i++)
                {
                    var entry = archive.CreateEntry($"photo{i + 1}.jpg");

                    using var entryStream = entry.Open();

                    await result.Value[i].CopyToAsync(entryStream);
                    await result.Value[i].DisposeAsync();
                }
            }

            memoryStream.Position = 0;

            return File(memoryStream.ToArray(), "application/zip", "photos.zip");
        }

    }
}