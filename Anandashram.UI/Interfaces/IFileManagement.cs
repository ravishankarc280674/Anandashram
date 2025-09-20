namespace Anandashram.Interfaces
{
    public interface IFileManagement
    {
        Task Upload(AddFile uploadImage);
        Task<byte[]> GetProfilePic(string fileName);
        Task UploadDocument(AddFile addFile);
    }
}
