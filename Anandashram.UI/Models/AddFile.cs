namespace Anandashram.Models;
public partial class AddFile
{
    public int DevoteeId { get; set; }
    public string DevoteeCode { get; set; }

    public bool ProfilePic { get; set; } = true;
    public byte[] ImageBytes { get; set; }

    [DisplayName("File Name")]
    public string FileName { get; set; }

    public string ImageData { get; set; }

    [DisplayName("Upload File")]
    public IFormFile ImageFile { get; set; }
}
