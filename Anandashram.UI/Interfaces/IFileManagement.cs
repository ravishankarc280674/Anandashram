namespace Anandashram.Interfaces;
public interface IFileManagement
{
    Task Upload(AddFile uploadImage); // to upload the webcam image
    Task<byte[]> GetProfilePic(string fileName); // the reterive the image uploaded by the webcam
    Task UploadDocument(AddFile addFile); // to upload a document by selecting the browse button
    List<UploadedFile> GetUploadedFiles(int Id, string code); // all the files related to document uploaded 
    Task<byte[]> GetDocument(string filePath); // to get the image by document type
    Task DeleteDocument(string filePath);
    Task CopyProfilePic(string oldDevoteeCode, string newDevoteeCode);
    Task CopyDocuments(string oldDevoteeCode, string newDevoteeCode);
}
