using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Infrastructure.Files
{
    public interface IFileClient
    {
        Task Save(int id, string fileName, string fileStore, Stream inputStream);
        Task Delete(int id, string fileName);
        Task<Stream> Get(int id, string fileName);
        Task<List<Stream>> List(int id);
    }
}
