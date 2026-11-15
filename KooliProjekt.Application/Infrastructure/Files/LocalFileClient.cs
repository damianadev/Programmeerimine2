using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace KooliProjekt.Application.Infrastructure.Files
{
    public class LocalFileClient : IFileClient
    {
        private readonly string _filesRoot;

        public LocalFileClient(string filesRoot)
        {
            _filesRoot = filesRoot;
        }

        public async Task Save(int id, string fileName, string fileStore, Stream inputStream)
        {
            var folderPath = Path.Combine(_filesRoot, fileStore, id.ToString());
            var filePath = Path.Combine(folderPath, fileName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            using var fileStream = new FileStream(filePath, FileMode.Create);
            await inputStream.CopyToAsync(fileStream);
        }

        public async Task Delete(int id, string fileName)
        {
            var folderPath = Path.Combine(_filesRoot, FileStore.Photos, id.ToString());
            var filePath = Path.Combine(folderPath, fileName);

            if (File.Exists(filePath))
            {
                await Task.Run(() => File.Delete(filePath));
            }
            else
            {
                throw new FileNotFoundException("File not found");
            }
        }

        public Task<Stream> Get(int id, string fileName)
        {
            var folderPath = Path.Combine(_filesRoot, FileStore.Photos, id.ToString());
            var filePath = Path.Combine(folderPath, fileName);

            if (File.Exists(filePath))
            {
                return Task.FromResult<Stream>(File.OpenRead(filePath));
            }
            else
            {
                throw new FileNotFoundException("File not found");
            }

        }
        
        public Task<List<Stream>> List(int id)
        {
            var folderPath = Path.Combine(_filesRoot, FileStore.Photos, id.ToString());
            var files = new List<Stream>();

            if (!Directory.Exists(folderPath))
            {
                return Task.FromResult(files);
            }

            foreach (var file in Directory.GetFiles(folderPath))
            {
                files.Add(File.OpenRead(file));
            }

            return Task.FromResult(files);
        }
    }
}
