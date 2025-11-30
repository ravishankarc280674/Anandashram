namespace Anandashram.DTO
{
    public class ReportResult<T>
    {
        public bool HasData => (Data != null && Data.Any()) || (DataStream !=null) || (DataArray !=null && DataArray.Length>0);
        public IEnumerable<T> Data { get; set; }
        public MemoryStream DataStream { get; set; }
        public byte[] DataArray{get;set;}
        public string Message { get; set; }
    }
}
