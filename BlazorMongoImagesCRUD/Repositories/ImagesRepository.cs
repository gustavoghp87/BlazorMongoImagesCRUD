using BlazorMongoImagesCRUD.Data;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMongoImagesCRUD.Repositories
{
    public class ImagesRepository : IImageService
    {
        internal MongoDBRepository _repo = new();
        public IMongoCollection<StorableImage> Collection;
        internal IGridFSBucket bucket;

        public ImagesRepository()
        {
            _repo = new MongoDBRepository();
            Collection = _repo.db.GetCollection<StorableImage>("fs.files");  //fs.chunks
            bucket = new GridFSBucket(_repo.db);
        }

        public async Task<bool> SaveImage(StorableImage image)
        {
            await bucket.UploadFromBytesAsync(image.Name, image.Content);
            return true;
        }

        public async Task<List<StorableImage>> GetAllImages()
        {
            var query = await Collection.Find(new BsonDocument()).ToListAsync();
            return query;
        }

        public async Task<byte[]> GetImageContent(ObjectId id)
        {
            return await bucket.DownloadAsBytesAsync(id);
        }

        public async Task DeleteImage(ObjectId id)
        {
            await bucket.DeleteAsync(id);
        }
    }
}
