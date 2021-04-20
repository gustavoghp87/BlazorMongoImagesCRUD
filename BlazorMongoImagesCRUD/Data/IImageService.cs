using MongoDB.Bson;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMongoImagesCRUD.Data
{
    public interface IImageService
    {
        Task<bool> SaveImage(StorableImage image);
        Task<List<StorableImage>> GetAllImages();
        Task<byte[]> GetImageContent(ObjectId id);
        Task DeleteImage(ObjectId id);
    }
}
