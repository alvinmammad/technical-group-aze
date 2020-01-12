using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace TechnicalGroup.Extensions
{
    public static class IFormFileExtensions
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }

        public static bool IsLessThan(this IFormFile file, int mb)
        {
            return file.Length / 1024 / 1024 < mb;
        }

        public async static Task<string> SaveAsync(this IFormFile file, string root, string folder)
        {
            string path = Path.Combine(root, "images");
            string fileName = Path.Combine(folder, Guid.NewGuid().ToString() + file.FileName);

            string resultPath = Path.Combine(path, fileName);

            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return fileName;
        }
    }
}
