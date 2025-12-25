using DocumentFormat.OpenXml.Wordprocessing;
using Humanizer;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Anandashram.Reports;

public class RoomAllocationDateWiseReport : IDocument
{
    public Company Company { get; }
    public List<ReservationReportDTO> Reservations { get; }
    public string Subject { get; }
    private readonly DateTime From;
    private readonly DateTime To;
    public RoomAllocationDateWiseReport(Company company, List<ReservationReportDTO> reservations, string subject,DateTime fromDate,DateTime toDate)
    {
        Company = company ?? new Company();
        Reservations = reservations ?? new List<ReservationReportDTO>();
        Subject = subject;
        From = fromDate;
        To = toDate;
    }
    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
    public void Compose(IDocumentContainer container)
    { 
        container.Page(page =>
        {
            page.Size(PageSizes.A4);
            page.Margin(20);
            page.PageColor(Colors.White);

            // D) Arial Narrow for more room-name capacity
            page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Arial Narrow"));
            //page.Header().Element(Header);
            page.Header().Column(header =>
            {
                header.Item().ShowOnce().Element(Header);
            });
            var groupedRooms = Reservations
          .GroupBy(x => x.RoomName)
          .OrderBy(x => x.Key)
          .ToList();
            // A) Professional green border with rounded edges
            const float TableWidth = 555;
            page.Content().Column(col =>
            {
                foreach (var roomGroup in groupedRooms)
                {
                    col.Item().PaddingTop(10)
                    .Element(c => DrawGroup(
                        c,
                        roomGroup.Key
                    ));
                    col.Item().Element(c => RoomTable(c, roomGroup.ToList()));

                }
            });
            
            void DrawGroup(QuestPDF.Infrastructure.IContainer container, string Room)
            {
                container
                    .Width(TableWidth)
                    .PaddingVertical(6)
                    .Background(Colors.Grey.Lighten1)
                    .Border(1)
                    .BorderColor(Colors.Grey.Medium)
                    .Padding(4)
                    .Element(x =>
                    {
                        x.Row(row =>
                        {
                            row.RelativeItem().Text($"Room: {Room}").SemiBold().FontSize(12);
                        });
                    });
            }

            page.Footer().AlignRight().Text(text =>
            {
                text.Span("Page ").FontSize(9);
                text.CurrentPageNumber().FontSize(9).Bold();
                text.Span(" of ").FontSize(9);
                text.TotalPages().FontSize(9);
            });

        });
    }

    void Header(QuestPDF.Infrastructure.IContainer header)
    {
        header.PaddingBottom(6).Column(col =>
        {
            col.Item().AlignCenter().Text(Company.Name ?? "").FontSize(14).Bold();
            col.Item().AlignCenter().Text($"{Company.AddressLine1} {Company.AddressLine2}".Trim()).FontSize(9);
            col.Item().AlignCenter().Text($"{Company.State}, {Company.Country} - {Company.PinCode}".Trim()).FontSize(9);
            col.Item().AlignCenter().Text($"Mobile: {Company.Mobile} | Email: {Company.Email}").FontSize(9);
            col.Item().AlignCenter().Hyperlink($"https://{Company.Website}")
                .Text($"{Company.Website}").FontSize(9).Underline().FontColor(Colors.Blue.Medium);

            col.Item().PaddingVertical(6)
                .BorderTop(1).BorderBottom(2)
                .BorderColor(Colors.Green.Darken2)
                .AlignCenter()
                .Text(Subject).FontSize(12).Bold().FontColor(Colors.Green.Darken3);

            col.Item().AlignCenter()
                .Text($"From {From:dd/MM/yyyy} To {To:dd/MM/yyyy}")
                .FontSize(9)
                .FontColor(Colors.Grey.Darken1);
        });
    }
    // ================= TABLE =================
    void RoomTable(QuestPDF.Infrastructure.IContainer container, List<ReservationReportDTO> rows)
    {
        container.Border(1).Table(table =>
        {
            var headerBackground = Colors.Green.Darken2;

            table.ColumnsDefinition(cols =>
            {
                cols.RelativeColumn(2);  // Devotee Code & Name
                cols.ConstantColumn(70);   // From Date
                cols.ConstantColumn(70);   // To Date
                cols.ConstantColumn(60);  // Allocated
                cols.ConstantColumn(50);  // Closed
            });


            table.Header(header =>
            {
                header.Cell().Background(headerBackground).Padding(5).Text("Devotee").FontColor(Colors.White).Bold();
                header.Cell().Background(headerBackground).Padding(5).Text("From Date").FontColor(Colors.White).Bold();
                header.Cell().Background(headerBackground).Padding(5).Text("To Date").FontColor(Colors.White).Bold();
                header.Cell().Background(headerBackground).Padding(5).Text("Allocated").FontColor(Colors.White).Bold();
                header.Cell().Background(headerBackground).Padding(5).Text("Closed").FontColor(Colors.White).Bold();
            });

            // BODY
            bool even = true;
            foreach (var r in rows)
            {
                var bg = even ? Colors.Grey.Lighten3 : Colors.White;
                table.Cell().Background(bg).Padding(4).Text($"{r.DevoteeCode} - {r.DevoteeName}");
                table.Cell().Background(bg).Padding(4).Text(r.FromDate.ToString("dd/MM/yyyy"));
                table.Cell().Background(bg).Padding(4).Text(r.ToDate.ToString("dd/MM/yyyy"));
                table.Cell().Background(bg).Padding(4).AlignCenter().Text(r.Allocated.ToString());
                table.Cell().Background(bg).Padding(4).AlignCenter().Text(r.Closed ? "☑" : "☐");
                even = !even;
            }
        });
    }
}