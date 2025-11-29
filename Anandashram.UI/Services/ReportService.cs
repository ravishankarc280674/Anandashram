using Anandashram.DTO;
using Anandashram.Interfaces.Services;

namespace Anandashram.Services;

public class ReportService : IReportService
{
    private readonly IRoom _roomRepo;
    private readonly IReservation _reservationrepo;
    private readonly IDevotee _devoteerepo;
    private readonly IDevoteeCategory _devotecategoryrepo;
    private readonly ICompany _companyrepo;
    private readonly IFloor _floorrepo;
    private readonly IBuilding _buildingrepo;
    private readonly IBlock _blockrepo;

    public ReportService(IRoom roomRepo, IReservation reservationrepo, IDevotee devoteerepo,
                         IDevoteeCategory devotecategoryrepo, ICompany companyrepo,
                         IFloor floorrepo, IBuilding buildingrepo, IBlock blockrepo)
    {
        _roomRepo = roomRepo;
        _reservationrepo = reservationrepo;
        _devoteerepo = devoteerepo;
        _devotecategoryrepo = devotecategoryrepo;
        _companyrepo = companyrepo;
        _floorrepo = floorrepo;
        _buildingrepo = buildingrepo;
        _blockrepo = blockrepo;
    }

    
    public async Task<byte[]> PrintGenericReport(string type)
    {
        var items =await LoadGenericTableData(type); // List<GenericItemDTO>
        var company = _companyrepo.CompanyDetails(); // company details
        type = type == "DevoteeCategory" ? "Devotee Category" : type;
        var pdfBytes = new PrintGenericTable(company, type + " List", items).GeneratePdf();
        return pdfBytes;
    }
    public async Task<ReportResult<byte[]>> DevoteeCheckInReportList(DateTime dateValue, string typeofreport)
    {
        string Subject = "Devotee Check-In List On: " + dateValue.Date.ToString("dd - MMM - yyyy");
        var data = await _roomRepo.GetCheckInDetailsReportAsync(dateValue);
        if (data == null || !data.Any())
        {
            return new ReportResult<byte[]>
            {
                DataArray = null,
                Message = "No data available for report."
            };
           
        }
        var company = _companyrepo.CompanyDetails();
        var document = new DevoteeCheckInReport(company, data, Subject);
        return new ReportResult<byte[]>
        {
            DataArray = document.GeneratePdf(),
            Message = "Success"
        };
    }

    public async Task<List<GenericItemDTO>> LoadGenericTableData(string type)
    {
        return type switch
        {
            "DevoteeCategory" =>(await _devotecategoryrepo.GetDevoteeCategories())
                                .Select(x => new GenericItemDTO { Id = x.Id, Name = x.Name, Description = x.Description })
                                .ToList(),

            "Building" => (await _buildingrepo.GetBuildings())
                                .Select(x => new GenericItemDTO { Id = x.Id, Name = x.Name, Description = x.Description })
                                .ToList(),

            "Block" => (await _blockrepo.GetBlocks())
                                .Select(x => new GenericItemDTO { Id = x.Id, Name = x.Name, Description = x.Description })
                                .ToList(),

            "Floor" => (await _floorrepo.GetFloors())
                                .Select(x => new GenericItemDTO { Id = x.Id, Name = x.Name, Description = x.Description })
                                .ToList(),
            _ => new(),
        };
    }

    public async Task<MemoryStream> ExportRoomAllocationDateWiseToExcel(DateTime dateValue, string subject)
    {
        Company company = _companyrepo.CompanyDetails();
        var rooms = await _roomRepo.GetRoomsUpToDateAsync(dateValue);

        using var workbook = new XLWorkbook();
        var ws = workbook.Worksheets.Add("Room Allocation");

        int currentRow = 1;
        int totalColumns = 4; // RoomName, Capacity, Allocated, Remaining

        // ===== COMPANY HEADER =====
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = company.Name;

        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold().Font.SetFontSize(14)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"{company.AddressLine1} {company.AddressLine2}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"{company.State}, {company.Country} - {company.PinCode}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"Mobile: {company.Mobile} | Email: {company.Email}";
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        if (!string.IsNullOrWhiteSpace(company.Website))
        {
            ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = company.Website;
            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetUnderline()
                .Font.SetFontColor(XLColor.Blue)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            currentRow++;
        }

        currentRow++;

        // ===== SUBJECT =====
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = subject;
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold().Font.SetFontSize(12)
            .Fill.SetBackgroundColor(XLColor.FromArgb(34, 139, 34))
            .Font.SetFontColor(XLColor.White)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;
        currentRow++;

        var grouped = rooms
            .OrderBy(r => r.BuildingName)
            .ThenBy(r => r.BlockName)
            .ThenBy(r => r.FloorName)
            .GroupBy(g => new { g.BuildingName, g.BlockName, g.FloorName });

        int headerRow = 0;

        foreach (var group in grouped)
        {
            // Group Header
            ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
                .Value = $"Building: {group.Key.BuildingName} | Block: {group.Key.BlockName} | Floor: {group.Key.FloorName}";
            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetBold()
                .Fill.SetBackgroundColor(XLColor.LightGray)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
            currentRow++;

            // ===== TABLE HEADER =====
            ws.Cell(currentRow, 1).Value = "Room Name";
            ws.Cell(currentRow, 2).Value = "Capacity";
            ws.Cell(currentRow, 3).Value = "Allocated";
            ws.Cell(currentRow, 4).Value = "Remaining";

            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetBold()
                .Fill.SetBackgroundColor(XLColor.DarkGreen)
                .Font.SetFontColor(XLColor.White)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                .Alignment.SetVertical(XLAlignmentVerticalValues.Center)
                .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

            if (headerRow == 0)
                headerRow = currentRow;

            currentRow++;

            // ===== DATA ROWS =====
            bool isEven = true;
            foreach (var room in group)
            {
                var bg = isEven ? XLColor.White : XLColor.LightGray;
                isEven = !isEven;

                ws.Cell(currentRow, 1).Value = room.RoomName;
                ws.Cell(currentRow, 2).Value = room.Capacity;
                ws.Cell(currentRow, 3).Value = room.TotalAllocated;
                ws.Cell(currentRow, 4).Value = room.TotalRemaining;

                ws.Range(currentRow, 1, currentRow, totalColumns).Style
                    .Fill.SetBackgroundColor(bg)
                    .Border.SetOutsideBorder(XLBorderStyleValues.Thin)
                    .Alignment.SetWrapText(true);

                currentRow++;
            }

            // ===== SUBTOTAL =====
            ws.Cell(currentRow, 1).Value = "Subtotal :";
            ws.Cell(currentRow, 1).Style.Font.SetBold();

            ws.Cell(currentRow, 2).Value = group.Sum(r => r.Capacity);
            ws.Cell(currentRow, 3).Value = group.Sum(r => r.TotalAllocated);
            ws.Cell(currentRow, 4).Value = group.Sum(r => r.TotalRemaining);

            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Fill.SetBackgroundColor(XLColor.LightGreen)
                .Border.SetOutsideBorder(XLBorderStyleValues.Thin);
            currentRow += 2;
        }

        // ===== GRAND TOTAL =====
        ws.Cell(currentRow, 1).Value = "Grand Total :";
        ws.Cell(currentRow, 1).Style.Font.SetBold();

        ws.Cell(currentRow, 2).Value = rooms.Sum(r => r.Capacity);
        ws.Cell(currentRow, 3).Value = rooms.Sum(r => r.TotalAllocated);
        ws.Cell(currentRow, 4).Value = rooms.Sum(r => r.TotalRemaining);

        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Fill.SetBackgroundColor(XLColor.LightBlue)
            .Border.SetOutsideBorder(XLBorderStyleValues.Thin);
        currentRow++;

        // ===== FOOTER =====
        currentRow++;
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"Printed On: {DateTime.Now:dd-MMM-yyyy hh:mm tt}";
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetItalic()
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);

        // ===== FORMATTING =====
        ws.Range(headerRow, 1, currentRow, totalColumns).SetAutoFilter();
        ws.SheetView.FreezeRows(headerRow);
        ws.Columns().AdjustToContents();

        var stream = new MemoryStream();
        workbook.SaveAs(stream);
        stream.Position = 0;
        // Formatting
        ws.Range(headerRow, 1, currentRow, totalColumns).SetAutoFilter();
        ws.SheetView.FreezeRows(headerRow);

        // Increase width of all defined columns
        ws.Columns(1, totalColumns).Width = 40; // Adjust as per your requirement

        // Optional: Auto adjust row heights if wrapping is enabled
        ws.Rows().AdjustToContents();
        return stream;
    }
    public async Task<byte[]> RoomsAllocationPdfPreview(DateTime dateValue)
    {
        string Subject = string.Empty;
        var roomList =await _roomRepo.GetRoomsUpToDateAsync(dateValue);
        var company = _companyrepo.CompanyDetails();
        if (dateValue == DateTime.MinValue)
            Subject = "Rooms Allocation List Report (All Dates)";
        else
            Subject = $"Rooms Allocation List Report (Up to {dateValue:dd - MMM - yyyy})";
        var doc = new RoomAllocationDateWise(company, roomList, Subject);

        // Render to byte[]
        var pdfBytes = doc.GeneratePdf();
        return pdfBytes;
    }
    
    public async Task<byte[]> RoomsAllocationDetailPdfPreview(DateTime dateValue)
    {
        string Subject = string.Empty;
        Company company = _companyrepo.CompanyDetails();
        var roomList = await _roomRepo.GetRoomsUpToDateAsync(dateValue);
        if (dateValue == DateTime.MinValue)
            Subject = "Rooms Allocation Detail Report (All Dates)";
        else
            Subject = $"Rooms Allocation Detail Report (Up to {dateValue:dd - MMM - yyyy})";
        var doc = new RoomAllocationDetailDateWise(company, roomList, Subject);

        var pdfBytes = doc.GeneratePdf();
        return pdfBytes;
    }
    public async Task<ReportResult<byte[]>> DevoteeCheckOutReportList(DateTime dateValue, string typeofreport)
    {
        string Subject = "Devotee Check-Out List as On: " + dateValue.Date.ToString("dd - MMM - yyyy");
        var company = _companyrepo.CompanyDetails();
        var devoteeList = await _devoteerepo.GetDevoteeSummaryByDateAsync(dateValue);
        if (devoteeList == null || !devoteeList.Any())
        {
            return new ReportResult<byte[]>
            {
                DataArray = null,
                Message = "No data available for report."
            };

        }
       
        var document = new DevoteeCheckOutReport(company, devoteeList, Subject);
        return new ReportResult<byte[]>
        {
            DataArray = document.GeneratePdf(),
            Message = "Success"
        };
    }

    public async Task<byte[]> DevoteeDetailToPdf(int Id)
    {
        var DevoteeDetail = await _devoteerepo.GetDevoteeWithReservations(Id);
        var company = _companyrepo.CompanyDetails();
        var detail = new DevoteeDetailReport(company, DevoteeDetail, "Devotee Detail");
        var pbytes = detail.GeneratePdf();
        return pbytes;
    }
    public async Task<MemoryStream> ExportDevoteeListReportToExcel(List<DevoteeReportDTO> devotees)
    {
        // Export to Excel
        using var workbook = new ClosedXML.Excel.XLWorkbook();
        var ws = workbook.Worksheets.Add("Devotee List");

        // Header row
        ws.Cell(1, 1).Value = "Code";
        ws.Cell(1, 2).Value = "Name";
        ws.Cell(1, 3).Value = "Category";
        ws.Cell(1, 4).Value = "StartDate";
        ws.Cell(1, 5).Value = "No. of People";
        ws.Cell(1, 6).Value = "Mobile";
        ws.Cell(1, 7).Value = "Document";
        ws.Cell(1, 8).Value = "Address";

        var headerRange = ws.Range(1, 1, 1, 8);
        headerRange.Style.Font.Bold = true;
        headerRange.Style.Fill.BackgroundColor = XLColor.FromArgb(34, 139, 34); // DarkGreen
        headerRange.Style.Font.FontColor = XLColor.White;
        headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
        headerRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
        headerRange.Style.Alignment.WrapText = true;
        // Fill data
        for (int i = 0; i < devotees.Count; i++)
        {
            var item = devotees[i];
            int row = i + 2;
            ws.Cell(row, 1).Value = item.Code;
            ws.Cell(row, 2).Value = item.Name;
            ws.Cell(row, 3).Value = item.DevoteeCategoryName;
            ws.Cell(row, 4).Value = item.StartDate.ToString("dd/MM/yyyy");
            ws.Cell(row, 5).Value = item.NoOfPeople;
            ws.Cell(row, 6).Value = item.Mobile;
            ws.Cell(row, 7).Value = item.Document;
            ws.Cell(row, 8).Value = $"{item.AddressLine1} {item.AddressLine2} {item.State} {item.Country} {item.PinCode}".Trim();
            ws.Range(row, 2, row, 8).Style.Alignment.WrapText = true;
        }

        // fit columns
        ws.Column(1).Width = 12;  // Code
        ws.Column(2).Width = 25;  // Name
        ws.Column(3).Width = 20;  // Category
        ws.Column(4).Width = 12;  // Start Date
        ws.Column(5).Width = 15;  // No. of Devotees
        ws.Column(6).Width = 25;  // Mobile
        ws.Column(7).Width = 25;  // Document
        ws.Column(8).Width = 40;  // Address

        var stream = new MemoryStream();
        workbook.SaveAs(stream);
        stream.Position = 0;
        return stream;
    }
    public async Task<MemoryStream> ExportGenericItemsToExcel(string itemType)
    {
        List<GenericItemDTO> items;
        items = await LoadGenericTableData(itemType);

        using var workbook = new XLWorkbook();
        var ws = workbook.Worksheets.Add("Items List");

        // Header row
        ws.Cell(1, 1).Value = "Name";
        ws.Cell(1, 2).Value = "Description";

        // Style header
        var headerRange = ws.Range(1, 1, 1, 2);
        headerRange.Style.Font.Bold = true;
        headerRange.Style.Fill.BackgroundColor = XLColor.FromArgb(34, 139, 34); // DarkGreen
        headerRange.Style.Font.FontColor = XLColor.White;
        headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
        headerRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
        headerRange.Style.Alignment.WrapText = true;

        // Fill data
        for (int i = 0; i < items.Count; i++)
        {
            var item = items[i];
            int row = i + 2;

            ws.Cell(row, 1).Value = item.Name;
            ws.Cell(row, 2).Value = item.Description;

            ws.Range(row, 1, row, 2).Style.Alignment.WrapText = true;
        }

        // Set column widths
        ws.Column(1).Width = 50; // Name
        ws.Column(2).Width = 50; // Description
        //ws.Columns().AdjustToContents(); // Optional auto-fit

        // Save to memory stream
        var stream = new MemoryStream();
        workbook.SaveAs(stream);
        stream.Position = 0;
        return stream;
    }
    public async Task<byte[]> DevoteeListtoPdf(List<DevoteeReportDTO> devotees)
    {
        var company = _companyrepo.CompanyDetails();
        var doc = new DevoteeListReport(company, devotees, "Devotee List - Filtered");
        return doc.GeneratePdf();
    }

    public async Task<MemoryStream> ExportRoomAllocationDetailDateWiseToExcel(DateTime dateValue, string subject)
    {
        Company company = _companyrepo.CompanyDetails();
        var rooms = await _roomRepo.GetRoomsUpToDateAsync(dateValue);

        using var workbook = new XLWorkbook();
        var ws = workbook.Worksheets.Add("Room Allocation");

        int currentRow = 1;
        int totalColumns = 4;

        ws.Column(1).Width = 25;
        ws.Column(2).Width = 15;
        ws.Column(3).Width = 15;
        ws.Column(4).Width = 15;

        // ===== COMPANY HEADER =====
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = company.Name;
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold().Font.SetFontSize(14)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"{company.AddressLine1} {company.AddressLine2}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"{company.State}, {company.Country} - {company.PinCode}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"Mobile: {company.Mobile} | Email: {company.Email}";
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        if (!string.IsNullOrWhiteSpace(company.Website))
        {
            ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = company.Website;
            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetUnderline()
                .Font.SetFontColor(XLColor.Blue)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            currentRow++;
        }

        currentRow++;

        // ===== SUBJECT =====
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = subject;
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold().Font.SetFontSize(12)
            .Fill.SetBackgroundColor(XLColor.FromArgb(34, 139, 34))
            .Font.SetFontColor(XLColor.White)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;
        currentRow++;

        var grouped = rooms
            .OrderBy(r => r.BuildingName)
            .ThenBy(r => r.BlockName)
            .ThenBy(r => r.FloorName)
            .GroupBy(g => new { g.BuildingName, g.BlockName, g.FloorName });

        int headerRow = 0;

        foreach (var group in grouped)
        {
            // GROUP HEADER
            ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
                .Value = $"Building: {group.Key.BuildingName} | Block: {group.Key.BlockName} | Floor: {group.Key.FloorName}";
            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetBold()
                .Fill.SetBackgroundColor(XLColor.LightGray)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
            currentRow++;

            foreach (var room in group)
            {
                // ===== ROOM DETAILS =====
                ws.Cell(currentRow, 1).Value = room.RoomName;
                ws.Cell(currentRow, 2).Value = room.Capacity;
                ws.Cell(currentRow, 3).Value = room.TotalAllocated;
                ws.Cell(currentRow, 4).Value = room.TotalRemaining;

                ws.Range(currentRow, 1, currentRow, totalColumns).Style
                    .Font.SetBold()
                    .Fill.SetBackgroundColor(XLColor.LightGreen)
                    .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

                currentRow++;

                // ⭐ NEW: Reservations header row
                ws.Cell(currentRow, 1).Value = "Devotee Code";
                ws.Cell(currentRow, 2).Value = "Devotee Name";
                ws.Cell(currentRow, 3).Value = "From Date";
                ws.Cell(currentRow, 4).Value = "Allocated";

                ws.Range(currentRow, 1, currentRow, totalColumns).Style
                    .Font.SetBold()
                    .Fill.SetBackgroundColor(XLColor.DarkGreen)
                    .Font.SetFontColor(XLColor.White)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                    .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

                if (headerRow == 0)
                    headerRow = currentRow;

                currentRow++;

                // ⭐ NEW: Reservation data rows
                if (room.Reservations.Any())
                {
                    bool isEven = true;
                    foreach (var res in room.Reservations)
                    {
                        var bg = isEven ? XLColor.White : XLColor.FromHtml("#e9f7ef");
                        isEven = !isEven;

                        ws.Cell(currentRow, 1).Value = res.DevoteeCode;
                        ws.Cell(currentRow, 2).Value = res.DevoteeName;
                        ws.Cell(currentRow, 3).Value = res.FromDate.ToString("dd-MMM-yyyy");
                        ws.Cell(currentRow, 4).Value = res.Allocated;

                        ws.Range(currentRow, 1, currentRow, totalColumns).Style
                            .Fill.SetBackgroundColor(bg)
                            .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

                        currentRow++;
                    }
                }
                else
                {
                    ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
                        .Value = "No active reservations";
                    ws.Range(currentRow, 1, currentRow, totalColumns).Style
                        .Font.SetItalic()
                        .Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                    currentRow++;
                }

                currentRow++;
            }

            // SUBTOTAL
            ws.Cell(currentRow, 1).Value = "Subtotal :";
            ws.Cell(currentRow, 1).Style.Font.SetBold();

            ws.Cell(currentRow, 2).Value = group.Sum(r => r.Capacity);
            ws.Cell(currentRow, 3).Value = group.Sum(r => r.TotalAllocated);
            ws.Cell(currentRow, 4).Value = group.Sum(r => r.TotalRemaining);

            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Fill.SetBackgroundColor(XLColor.LightYellow)
                .Border.SetOutsideBorder(XLBorderStyleValues.Thin);
            currentRow += 2;
        }

        // GRAND TOTAL
        ws.Cell(currentRow, 1).Value = "Grand Total :";
        ws.Cell(currentRow, 1).Style.Font.SetBold();

        ws.Cell(currentRow, 2).Value = rooms.Sum(r => r.Capacity);
        ws.Cell(currentRow, 3).Value = rooms.Sum(r => r.TotalAllocated);
        ws.Cell(currentRow, 4).Value = rooms.Sum(r => r.TotalRemaining);

        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Fill.SetBackgroundColor(XLColor.LightBlue)
            .Border.SetOutsideBorder(XLBorderStyleValues.Thin);
        currentRow++;

        currentRow++;
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"Printed On: {DateTime.Now:dd-MMM-yyyy hh:mm tt}";
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetItalic()
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);

        // Formatting
        ws.Range(headerRow, 1, currentRow, totalColumns).SetAutoFilter();
        ws.SheetView.FreezeRows(headerRow);
        ws.Columns().AdjustToContents();

        var stream = new MemoryStream();
        workbook.SaveAs(stream);
        stream.Position = 0;
        return stream;
    }

    public async Task<byte[]> RoomsListToPdf(string subject)
    {
        var roomList =await _roomRepo.GetRooms();
        Company company = _companyrepo.CompanyDetails();
        var roomsReport = new RoomsReportDocument(company, roomList);
        return roomsReport.GeneratePdf();
    }
    public async Task<MemoryStream> ExportRoomsListToExcel(string subject)
    {
        Company company = _companyrepo.CompanyDetails();
        var rooms = await _roomRepo.GetRooms();
        using var workbook = new XLWorkbook();
        var ws = workbook.Worksheets.Add("Rooms List");

        int currentRow = 1;
        int totalColumns = 2;

        // ===== COMPANY HEADER =====
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = company.Name;
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold().Font.SetFontSize(14)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"{company.AddressLine1} {company.AddressLine2}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"{company.State}, {company.Country} - {company.PinCode}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"Mobile: {company.Mobile} | Email: {company.Email}";
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        if (!string.IsNullOrWhiteSpace(company.Website))
        {
            ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = company.Website;
            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetUnderline()
                .Font.SetFontColor(XLColor.Blue)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            currentRow++;
        }

        currentRow++;

        // ===== SUBJECT =====
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = subject;
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold().Font.SetFontSize(12)
            .Fill.SetBackgroundColor(XLColor.FromArgb(34, 139, 34))
            .Font.SetFontColor(XLColor.White)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow += 2;

        // ===== GROUPING =====
        var grouped = rooms
            .OrderBy(r => r.BuildingName)
            .ThenBy(r => r.BlockName)
            .ThenBy(r => r.FloorName)
            .GroupBy(g => new { g.BuildingName, g.BlockName, g.FloorName });

        int headerRow = 0;

        foreach (var group in grouped)
        {
            // GROUP HEADER
            ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
                .Value = $"Building:  {group.Key.BuildingName}    |   Block:  {group.Key.BlockName}    |    Floor:  {group.Key.FloorName}";
            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetBold()
                .Fill.SetBackgroundColor(XLColor.LightGray)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
            currentRow++;

            // TABLE HEADER
            ws.Cell(currentRow, 1).Value = "Room Name";
            ws.Cell(currentRow, 2).Value = "Capacity";

            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetBold()
                .Fill.SetBackgroundColor(XLColor.DarkGreen)
                .Font.SetFontColor(XLColor.White)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

            if (headerRow == 0)
                headerRow = currentRow;

            currentRow++;

            // DATA ROWS
            bool isEven = true;
            foreach (var room in group)
            {
                var bg = isEven ? XLColor.White : XLColor.LightGray;
                isEven = !isEven;

                ws.Cell(currentRow, 1).Value = room.RoomName;
                ws.Cell(currentRow, 2).Value = room.Capacity;

                ws.Range(currentRow, 1, currentRow, totalColumns).Style
                    .Fill.SetBackgroundColor(bg)
                    .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

                currentRow++;
            }

            // SUBTOTAL
            ws.Cell(currentRow, 1).Value = "Subtotal :";
            ws.Cell(currentRow, 1).Style.Font.SetBold();

            ws.Cell(currentRow, 2).Value = group.Sum(r => r.Capacity);

            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Fill.SetBackgroundColor(XLColor.LightYellow)
                .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

            currentRow += 2;
        }

        // ===== GRAND TOTAL =====
        ws.Cell(currentRow, 1).Value = "Grand Total :";
        ws.Cell(currentRow, 1).Style.Font.SetBold();
        ws.Cell(currentRow, 2).Value = rooms.Sum(r => r.Capacity);

        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Fill.SetBackgroundColor(XLColor.LightBlue)
            .Border.SetOutsideBorder(XLBorderStyleValues.Thin);
        currentRow++;

        currentRow++;
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"Printed On: {DateTime.Now:dd-MMM-yyyy hh:mm tt}";
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetItalic()
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);

        // Formatting
        ws.Range(headerRow, 1, currentRow, totalColumns).SetAutoFilter();
        ws.SheetView.FreezeRows(headerRow);

        // Increase width of all defined columns
        ws.Columns(1, totalColumns).Width = 35; // Adjust as per your requirement

        // Optional: Auto adjust row heights if wrapping is enabled
        ws.Rows().AdjustToContents();

        var stream = new MemoryStream();
        workbook.SaveAs(stream);
        stream.Position = 0;
        return stream;
    }
    public async Task<MemoryStream> ExportDevoteeDetailToExcel(int Id, string subject)
    {
        var devotee = await _devoteerepo.GetDevoteeWithReservations(Id);
        var company = _companyrepo.CompanyDetails();
        using var workbook = new XLWorkbook();
        var ws = workbook.Worksheets.Add("Devotee Detail");

        int currentRow = 1;
        int totalColumns = 8;

        ws.Column(1).Width = 20; // Room
        ws.Column(2).Width = 20; // Building
        ws.Column(3).Width = 20; // Block
        ws.Column(4).Width = 20; // Floor
        ws.Column(5).Width = 15; // From Date
        ws.Column(6).Width = 15; // To Date
        ws.Column(7).Width = 12; // Allocated
        ws.Column(8).Width = 10; // Closed

        // ===== COMPANY HEADER =====
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = company.Name;
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold().Font.SetFontSize(14)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"{company.AddressLine1} {company.AddressLine2}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"{company.State}, {company.Country} - {company.PinCode}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"Mobile: {company.Mobile} | Email: {company.Email}";
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        if (!string.IsNullOrWhiteSpace(company.Website))
        {
            ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = company.Website;
            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetUnderline()
                .Font.SetFontColor(XLColor.Blue)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            currentRow++;
        }

        currentRow++;

        // ===== SUBJECT =====
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = subject;
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold().Font.SetFontSize(12)
            .Fill.SetBackgroundColor(XLColor.FromArgb(34, 139, 34))
            .Font.SetFontColor(XLColor.White)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow += 2;

        // ===== DEVOTEE INFO =====
        ws.Cell(currentRow, 1).Value = "Devotee Name";
        ws.Cell(currentRow, 2).Value = $"{devotee.Name} ({devotee.Code})";
        currentRow++;

        ws.Cell(currentRow, 1).Value = "Category";
        ws.Cell(currentRow, 2).Value = devotee.DevoteeCategoryName;
        currentRow++;

        ws.Cell(currentRow, 1).Value = "Mobile";
        ws.Cell(currentRow, 2).Value = devotee.Mobile;
        currentRow++;

        ws.Cell(currentRow, 1).Value = "Document";
        ws.Cell(currentRow, 2).Value = devotee.Document;
        currentRow++;

        ws.Cell(currentRow, 1).Value = "No. of People";
        ws.Cell(currentRow, 2).Value = devotee.NoOfPeople;
        currentRow++;

        ws.Cell(currentRow, 1).Value = "Address";
        ws.Cell(currentRow, 2).Value =
            $"{devotee.AddressLine1} {devotee.AddressLine2} {devotee.State} {devotee.Country} {devotee.PinCode}".Trim();
        currentRow += 2;
        // ===== RESERVATION TABLE HEADER =====
        string[] headers = { "Room", "Building", "Block", "Floor", "From Date", "To Date", "Allocated", "Closed" };

        for (int col = 1; col <= headers.Length; col++)
        {
            ws.Cell(currentRow, col).Value = headers[col - 1];
        }
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold()
            .Fill.SetBackgroundColor(XLColor.DarkGreen)
            .Font.SetFontColor(XLColor.White)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
            .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

        int headerRow = currentRow;
        currentRow++;
        // ===== RESERVATIONS DATA =====
        if (devotee.Reservations != null && devotee.Reservations.Count > 0)
        {
            bool isEven = true;
            foreach (var r in devotee.Reservations)
            {
                var bg = isEven ? XLColor.White : XLColor.LightGray;
                isEven = !isEven;
                ws.Cell(currentRow, 1).Value = r.RoomName;
                ws.Cell(currentRow, 2).Value = r.BuildingName;
                ws.Cell(currentRow, 3).Value = r.BlockName;
                ws.Cell(currentRow, 4).Value = r.FloorName;
                ws.Cell(currentRow, 5).Value = r.FromDate.ToString("dd/MM/yyyy");
                ws.Cell(currentRow, 6).Value = r.ToDate.ToString("dd/MM/yyyy");
                ws.Cell(currentRow, 7).Value = r.Allocated;
                ws.Cell(currentRow, 8).Value = r.Closed ? "Yes" : "No";

                ws.Range(currentRow, 1, currentRow, totalColumns).Style
                    .Fill.SetBackgroundColor(bg)
                    .Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                currentRow++;
            }
        }
        else
        {
            ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = "No Reservation Found";
            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetItalic().Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            currentRow++;
        }
        currentRow++;
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = $"Printed On: {DateTime.Now:dd-MMM-yyyy hh:mm tt}";
        ws.Range(currentRow, 1, currentRow, totalColumns).Style.Font.SetItalic()
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);

        // Freeze Header + Auto Filter
        ws.Range(headerRow, 1, currentRow, totalColumns).SetAutoFilter();
        ws.SheetView.FreezeRows(headerRow);

        ws.Columns().AdjustToContents();

        var stream = new MemoryStream();
        workbook.SaveAs(stream);
        stream.Position = 0;
        return stream;
    }
    public async Task<MemoryStream> ExportDevoteeCheckOutToExcel(DateTime dateValue, string subject)
    {
        var company = _companyrepo.CompanyDetails(); // your company details
        var items =await _devoteerepo.GetDevoteeSummaryByDateAsync(dateValue);
        using var workbook = new XLWorkbook();
        var ws = workbook.Worksheets.Add("Check-Out Report");

        int currentRow = 1;
        int totalColumns = 4;

        // ===== COMPANY HEADER =====
        ws.Range(currentRow, 1, currentRow, totalColumns)
            .Merge()
            .Value = company.Name;
        ws.Range(currentRow, 1, currentRow, totalColumns)
            .Style.Font.SetBold().Font.SetFontSize(14)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns)
            .Merge()
            .Value = $"{company.AddressLine1} {company.AddressLine2}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns)
            .Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns)
            .Merge()
            .Value = $"{company.State}, {company.Country} - {company.PinCode}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns)
            .Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns)
            .Merge()
            .Value = $"Mobile: {company.Mobile} | Email: {company.Email}";
        ws.Range(currentRow, 1, currentRow, totalColumns)
            .Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        if (!string.IsNullOrWhiteSpace(company.Website))
        {
            ws.Range(currentRow, 1, currentRow, totalColumns)
                .Merge()
                .Value = company.Website;
            ws.Range(currentRow, 1, currentRow, totalColumns)
                .Style.Font.SetUnderline()
                .Font.SetFontColor(XLColor.Blue)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            currentRow++;
        }

        currentRow++; // blank line

        // ===== SUBJECT =====
        ws.Range(currentRow, 1, currentRow, totalColumns)
            .Merge()
            .Value = subject;
        ws.Range(currentRow, 1, currentRow, totalColumns)
            .Style.Font.SetBold().Font.SetFontSize(12)
            .Fill.SetBackgroundColor(XLColor.FromArgb(34, 139, 34))
            .Font.SetFontColor(XLColor.White)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        currentRow++; // blank line

        // ===== TABLE HEADER (filter only here) =====
        ws.Cell(currentRow, 1).Value = "Code";
        ws.Cell(currentRow, 2).Value = "Name";
        ws.Cell(currentRow, 3).Value = "Category";
        ws.Cell(currentRow, 4).Value = "Allocated";

        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold()
            .Fill.SetBackgroundColor(XLColor.DarkGreen)
            .Font.SetFontColor(XLColor.White)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
            .Alignment.SetVertical(XLAlignmentVerticalValues.Center)
            .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

        int headerRowNumber = currentRow;
        currentRow++;

        // ===== DATA ROWS =====
        bool isEven = true;
        foreach (var item in items)
        {
            var bgColor = isEven ? XLColor.White : XLColor.LightGray;
            isEven = !isEven;

            ws.Cell(currentRow, 1).Value = item.Code;
            ws.Cell(currentRow, 2).Value = item.Name;
            ws.Cell(currentRow, 3).Value = item.DevoteeCategoryName;
            ws.Cell(currentRow, 4).Value = item.TotalAllocated;

            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Fill.SetBackgroundColor(bgColor)
                .Border.SetOutsideBorder(XLBorderStyleValues.Thin)
                .Alignment.SetWrapText(true);

            currentRow++;
        }

        // ===== TOTAL ROW =====
        ws.Cell(currentRow, 3).Value = "Total Allocated:";
        ws.Cell(currentRow, 3).Style.Font.SetBold();
        ws.Cell(currentRow, 4).Value = items.Sum(x => x.TotalAllocated);
        ws.Cell(currentRow, 4).Style.Font.SetBold();

        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Fill.SetBackgroundColor(XLColor.LightGreen)
            .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

        currentRow++;

        // ===== FOOTER PRINT DATE =====
        currentRow++;
        ws.Range(currentRow, 1, currentRow, totalColumns)
            .Merge()
            .Value = $"Printed On: {DateTime.Now:dd-MMM-yyyy hh:mm tt}";
        ws.Range(currentRow, 1, currentRow, totalColumns)
            .Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left)
            .Font.SetItalic();

        // ===== FORMATTING =====
        ws.SheetView.FreezeRows(headerRowNumber); // freeze table header row only
        ws.Range(headerRowNumber, 1, currentRow, totalColumns).SetAutoFilter();
        ws.Columns().AdjustToContents();
        ws.Columns(2, 3).Width = 30; // Name & Category wider
        ws.Column(1).Width = 15; // Code

        var stream = new MemoryStream();
        workbook.SaveAs(stream);
        stream.Position = 0;

        return stream;
    }
    public async Task<ReportResult<MemoryStream>> ExportDevoteeCheckInToExcel(DateTime dateValue)
    {
        using var workbook = new XLWorkbook();
        var ws = workbook.Worksheets.Add("Check-In Report");
        string Subject = "Devotee Check-In List On: " + dateValue.Date.ToString("dd - MMM - yyyy");
        var items = await _roomRepo.GetCheckInDetailsReportAsync(dateValue);
        var company = _companyrepo.CompanyDetails();

        if (items == null || !items.Any())
        {
            return new ReportResult<MemoryStream>
            {
                DataStream = null,
                Message = "No data available for report."
            };
        }
        int currentRow = 1;
        int totalColumns = 5;

        // ===== COMPANY HEADER =====
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = company.Name;
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold().Font.SetFontSize(14)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"{company.AddressLine1} {company.AddressLine2}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"{company.State}, {company.Country} - {company.PinCode}".Trim();
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"Mobile: {company.Mobile} | Email: {company.Email}";
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        if (!string.IsNullOrWhiteSpace(company.Website))
        {
            ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = company.Website;
            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Font.SetUnderline()
                .Font.SetFontColor(XLColor.Blue)
                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            currentRow++;
        }

        currentRow++;

        // ===== SUBJECT =====
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge().Value = Subject;
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold().Font.SetFontSize(12)
            .Fill.SetBackgroundColor(XLColor.FromArgb(34, 139, 34))
            .Font.SetFontColor(XLColor.White)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        currentRow++;

        currentRow++;

        // ===== TABLE HEADER =====
        ws.Cell(currentRow, 1).Value = "Code";
        ws.Cell(currentRow, 2).Value = "Name";
        ws.Cell(currentRow, 3).Value = "Room";
        ws.Cell(currentRow, 4).Value = "Check-Out";
        ws.Cell(currentRow, 5).Value = "Allocated";

        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetBold()
            .Fill.SetBackgroundColor(XLColor.DarkGreen)
            .Font.SetFontColor(XLColor.White)
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
            .Alignment.SetVertical(XLAlignmentVerticalValues.Center)
            .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

        int headerRow = currentRow;
        currentRow++;

        // ===== DATA ROWS =====
        bool isEven = true;
        foreach (var item in items)
        {
            var bg = isEven ? XLColor.White : XLColor.LightGray;
            isEven = !isEven;

            ws.Cell(currentRow, 1).Value = item.DevoteeCode;
            ws.Cell(currentRow, 2).Value = item.DevoteeName;
            ws.Cell(currentRow, 3).Value = item.RoomName;
            ws.Cell(currentRow, 4).Value = item.ToDate.ToString("dd-MMM-yyyy");
            ws.Cell(currentRow, 5).Value = item.Allocated;

            ws.Range(currentRow, 1, currentRow, totalColumns).Style
                .Fill.SetBackgroundColor(bg)
                .Border.SetOutsideBorder(XLBorderStyleValues.Thin)
                .Alignment.SetWrapText(true);

            currentRow++;
        }

        // ===== TOTAL ROW =====
        ws.Cell(currentRow, 4).Value = "Total :";
        ws.Cell(currentRow, 4).Style.Font.SetBold();
        ws.Cell(currentRow, 5).Value = items.Sum(x => x.Allocated);
        ws.Cell(currentRow, 5).Style.Font.SetBold();

        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Fill.SetBackgroundColor(XLColor.LightGreen)
            .Border.SetOutsideBorder(XLBorderStyleValues.Thin);

        currentRow++;

        // ===== FOOTER (Print Date) =====
        currentRow++;
        ws.Range(currentRow, 1, currentRow, totalColumns).Merge()
            .Value = $"Printed On: {DateTime.Now:dd-MMM-yyyy hh:mm tt}";
        ws.Range(currentRow, 1, currentRow, totalColumns).Style
            .Font.SetItalic()
            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);

        // ===== FORMATTING =====
        ws.SheetView.FreezeRows(headerRow);
        ws.Range(headerRow, 1, currentRow, totalColumns).SetAutoFilter();
        ws.Columns().AdjustToContents();
        ws.Column(1).Width = 15;
        ws.Column(2).Width = 30;
        ws.Column(3).Width = 20;
        ws.Column(4).Width = 15;

        // ===== RETURN EXCEL =====
        var stream = new MemoryStream();
        workbook.SaveAs(stream);
        stream.Position = 0;

        return new ReportResult<MemoryStream>
        {
            DataStream  = stream,
            Message = "Success"
        };
    }

}

