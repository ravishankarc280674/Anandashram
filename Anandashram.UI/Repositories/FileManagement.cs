using Anandashram.Models;

namespace Anandashram
{
    public class FileManagement : IFileManagement
    {
        private readonly IConfiguration _configuration;
        private string _imageStoragePath;
        public FileManagement(IConfiguration configuration)
        {
            _configuration = configuration;
            _imageStoragePath = _configuration.GetValue<string>("DocumentStoragePath").ToString();

        }
        public async Task Upload(AddFile uploadImage)
        {
            var imageStoragePath = _imageStoragePath + @"\Images";
            CreateFolder(imageStoragePath);
            string FullPath = Path.Combine(imageStoragePath, uploadImage.DevoteeCode + ".jpeg");
            if (File.Exists(FullPath))
            {
                // Delete the file
                System.IO.File.Delete(FullPath);
            }
           await File.WriteAllBytesAsync(FullPath, uploadImage.ImageBytes);
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

        public async Task UploadDocument(AddFile addFile)
        {
            var imageStoragePath = Path.Combine(_imageStoragePath, addFile.DevoteeCode);
            CreateFolder(imageStoragePath);
            string FullPath = Path.Combine(imageStoragePath, addFile.FileName);
            if (File.Exists(FullPath))
            {
                // Delete the file
                System.IO.File.Delete(FullPath);
            }
            using (var fileStream = new FileStream(FullPath, FileMode.Create))
            {
                await addFile.ImageFile.CopyToAsync(fileStream);
            }
        }
        
        public async Task<byte[]> GetProfilePic(string fileName)
        {
            var filePath = Path.Combine(_imageStoragePath, "Images", fileName + ".jpeg");

            if (!System.IO.File.Exists(filePath))
            {
                return System.IO.File.ReadAllBytes("wwwroot/images/NoFound.jpeg");
            }
             return await System.IO.File.ReadAllBytesAsync(filePath);
        }

        public async Task<byte[]> GetDocument(string filePath)
        {
            return await File.ReadAllBytesAsync(filePath);
        }
        public List<UploadedFile> GetUploadedFiles(int Id,string code)
        {
            List<UploadedFile> fileList = new List<UploadedFile>();
            var folderPath = Path.Combine(_imageStoragePath, code);
            if (!System.IO.Directory.Exists(folderPath))
            {
                return fileList;
            }
            foreach (string filePath in Directory.GetFiles(folderPath))
            {
                fileList.Add(new UploadedFile()
                {
                    DevoteeId = Id,
                    FileName = Path.GetFileName(filePath),
                    FilePath = filePath
                });

            }
            return fileList;

        }
        public async Task DeleteDocument(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
               File.Delete(filePath);
            }
        }

        public  async Task CopyProfilePic(string oldDevoteeCode, string newDevoteeCode)
        {
            var imageStoragePath = _imageStoragePath + @"\Images";
            string oldFullPath = Path.Combine(imageStoragePath, oldDevoteeCode + ".jpeg");
            string newFullPath = Path.Combine(imageStoragePath, newDevoteeCode + ".jpeg");
            if (File.Exists(oldFullPath))
            {
                // copy the file
                System.IO.File.Copy(oldFullPath, newFullPath);
            }
        }

        public async Task CopyDocuments(string oldDevoteeCode, string newDevoteeCode)
        {
            var imageOldPath = Path.Combine(_imageStoragePath, oldDevoteeCode);
            var imageNewPath = Path.Combine(_imageStoragePath, newDevoteeCode);
            if (Directory.Exists(imageOldPath))
            {
                if (!Directory.Exists(imageNewPath))
                {
                    // Create the folder if it doesn't exist
                    Directory.CreateDirectory(imageNewPath);
                    foreach (string file in Directory.GetFiles(imageOldPath))
                    {
                        string fileName = Path.GetFileName(file);
                        string destFile = Path.Combine(imageNewPath, fileName);
                        File.Copy(file, destFile, true); // The 'true' parameter overwrites if the file already exists
                    }
                }
            }
        }
       
    }
}
