using BlazorMongoImagesCRUD.Repositories;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMongoImagesCRUD.Data
{
    public class ImageService : IImageService
    {
        internal ImagesRepository _repository;
        public ImageService()
        {
            _repository = new ImagesRepository();
        }

        public Task<bool> SaveImage(StorableImage image)
        {
            return _repository.SaveImage(image);
        }

        public async Task<List<StorableImage>> GetAllImages()
        {
            var images = await _repository.GetAllImages();
            var format = "image/png";
            foreach (var image in images)
            {
                image.Content = await GetImageContent(image.Id);
                image.Url = $"data:{format};base64,{Convert.ToBase64String(image.Content)}";
            }
            return images;
        }

        public async Task<byte[]> GetImageContent(ObjectId id)
        {
            return await _repository.GetImageContent(id);
        }
        
        public async Task DeleteImage(ObjectId id)
        {
            await _repository.DeleteImage(id);
        }
    }
}
