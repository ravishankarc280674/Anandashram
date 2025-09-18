namespace Anandashram.Interfaces
{
    public interface IFileManagement
    {
        void Upload(AddFile uploadImage);
        byte[] GetProfilePic(string fileName);
    }
}
