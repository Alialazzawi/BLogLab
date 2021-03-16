using BlogLab.Models.Settings;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Services
{
    public class photoService : IPhotoService
    {

        private readonly Cloudinary _cloudinary;

        public photoService(IOptions<CloudinaryOption>  config)
        {
            var account = new Account(config.Value.CloudName, config.Value.ApiKey, config.Value.ApiSecrete);
            
            _cloudinary = new Cloudinary(account);
        }

        public async Task<ImageUploadResult> AddPhotoAsync(IFormFile file)
        {
            var uploadResult = new ImageUploadResult();

            if (file.Length > 0)
            {
                using (var stream = file.OpenReadStream())
                {
                    var uploadParams = new ImageUploadParams
                    {
                        File = new FileDescription(file.FileName, stream),
                        Transformation = new Transformation().Height(300).Width(500).Crop("fill")
                    };

                    uploadResult = await _cloudinary.UploadAsync(uploadParams);

                }
            }

          return uploadResult;
        }

        public async Task<DeletionResult> DeletePhotoAsync(string publidId)
        {
            var deletionParams = new DeletionParams(publidId);

            var result = await _cloudinary.DestroyAsync(deletionParams);

            return result;
        }
    }
}
