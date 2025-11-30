using Anandashram.Services;
using DocumentFormat.OpenXml;

namespace Anandashram.Interfaces.Services;

public interface IReportService
{
    Task<byte[]> PrintGenericReport(string type);
    //byte[] ExportGenericReportToPdf(string type);
    Task<ReportResult<byte[]>> DevoteeCheckOutReportList(DateTime dateValue, string typeofreport, string dataType);
    Task<ReportResult<byte[]>> DevoteeCheckInReportList(DateTime dateValue, string typeofreport);
    //IActionResult RoomsAllocationPdfDownload(Company company, List<RoomReportDTO> roomList, DateTime dateValue);
    Task<byte[]> RoomsAllocationPdfPreview(DateTime dateValue);
    // IActionResult RoomsAllocationDetailPdfDownload(Company company, List<RoomReportDTO> roomList, DateTime dateValue);
    Task<byte[]> RoomsAllocationDetailPdfPreview(DateTime dateValue);
    Task<MemoryStream> ExportRoomAllocationDateWiseToExcel(DateTime dateValue, string subject);
    Task<MemoryStream> ExportRoomAllocationDetailDateWiseToExcel(DateTime dateValue, string subject);
    Task<MemoryStream> ExportDevoteeCheckOutToExcel(DateTime dateValue, string Subject, string dataType);
    Task<ReportResult<MemoryStream>> ExportDevoteeCheckInToExcel(DateTime dateValue);
    Task<MemoryStream> ExportDevoteeListReportToExcel(List<DevoteeReportDTO> devotees);
    Task<MemoryStream> ExportDevoteeDetailToExcel(int Id, string subject);
    Task<MemoryStream> ExportGenericItemsToExcel(string type);
    Task<MemoryStream> ExportRoomsListToExcel(string subject);
    Task<byte[]> DevoteeDetailToPdf(int Id);
    Task<byte[]> DevoteeListtoPdf(List<DevoteeReportDTO> devotees);
    Task<byte[]> RoomsListToPdf(string subject);

}
