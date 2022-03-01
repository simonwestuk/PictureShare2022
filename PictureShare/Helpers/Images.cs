namespace PictureShare.Helpers
{
    public class Images
    {
        IWebHostEnvironment _env;
        public Images(IWebHostEnvironment env)
        {
            _env = env;
        }

        public string Upload(IFormFile file, string path)
        {
            string extension = Path.GetExtension(file.FileName);

            string root = _env.WebRootPath;

            string uploadPath = Path.Combine(root, path);

            string newFilename = $"{Guid.NewGuid()}{extension}".ToLower();

            string filePath = $"{uploadPath}{newFilename}";

            Directory.CreateDirectory(uploadPath);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyToAsync(fileStream);
            }

            return filePath;


        }
    }
}
