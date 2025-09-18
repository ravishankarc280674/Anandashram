namespace Anandashram
{
    public class FileManagement : IFileManagement
    {
        private readonly IConfiguration _configuration;
        private string ImageStoragePath;
        public FileManagement(IConfiguration configuration)
        {
            _configuration = configuration;
            ImageStoragePath = _configuration.GetValue<string>("DocumentStoragePath").ToString();

        }
        public void Upload(AddFile uploadImage)
        {
            var imageStoragePath = ImageStoragePath + @"\Images";
            CreateFolder(ImageStoragePath);
            string FullPath = Path.Combine(imageStoragePath, uploadImage.DevoteeCode + ".jpeg");
            if (File.Exists(FullPath))
            {
                // Delete the file
                System.IO.File.Delete(FullPath);
            }
            File.WriteAllBytes(FullPath, uploadImage.ImageBytes);
        }
        private static void CreateFolder(string folderPath)
        {
            // Check if the folder exists
            if (!Directory.Exists(folderPath))
            {
                // Create the folder if it doesn't exist
                Directory.CreateDirectory(folderPath);
            }
        }

        public byte[] GetProfilePic(string fileName)
        {
            var filePath = Path.Combine(ImageStoragePath, "Images", fileName + ".jpeg");

            if (!System.IO.File.Exists(filePath))
            {
                return System.IO.File.ReadAllBytes("wwwroot/images/NoFound.jpeg");
            }
            return System.IO.File.ReadAllBytes(filePath);
        }
    }
}
