using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Infrastructure.Files
{
    public class LocalFileClient : IFileClient
    {
        private readonly string _filesRoot;

        public LocalFileClient(string filesRoot)
        {
            _filesRoot = filesRoot;
        }

        public async Task Save(string fileName, string fileStore, Stream inputStream)
        {
            var folderPath = Path.Combine(_filesRoot, fileStore);
            var filePath = Path.Combine(folderPath, fileName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            using var fileStream = new FileStream(filePath, FileMode.Create);
            await inputStream.CopyToAsync(fileStream);
        }

        public async Task Delete(string fileName)
        {
            var folderPath = Path.Combine(_filesRoot, FileStore.Photos);
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

        public Task<Stream> Get(string fileName)
        {
            var folderPath = Path.Combine(_filesRoot, FileStore.Photos);
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
    }
}
