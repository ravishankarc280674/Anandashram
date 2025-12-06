using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Anandashram.Reports;

public class RoomAllocationDetailDateWise : IDocument
{
    public Company Company { get; }
    public List<RoomReportDTO> Rooms { get; }
    public string Subject { get; }
    public RoomAllocationDetailDateWise(Company company, List<RoomReportDTO> rooms, string subject)
    {
        Company = company ?? new Company();
        Rooms = rooms ?? new List<RoomReportDTO>();
        Subject = subject;
    }

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Size(PageSizes.A4);
            page.Margin(20);
            page.PageColor(Colors.White);

            // D) Arial Narrow for more room-name capacity
            page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Arial Narrow"));

            page.Header().Column(header =>
            {
                header.Item().ShowOnce().Element(Header);
            });

            // A) Professional green border with rounded edges
            page.Content()
                .Padding(10)
                .Border(2)
                .BorderColor(Colors.Green.Darken2)
                .CornerRadius(8)
                .AlignCenter()
                .Element(Content);

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
        });
    }
    // Constants for column widths
    const float TableWidth = 440; // reduce total width
    const float RoomColumnWidth = 200;
    const float CapacityColumnWidth = 80;

    void Content(QuestPDF.Infrastructure.IContainer content)
    {
        var rooms = Rooms.OrderBy(r => r.BuildingName)
            .ThenBy(r => r.BlockName)
            .ThenBy(r => r.FloorName)
            .ThenBy(r => r.RoomName)
            .ToList();

        content.Column(col =>
        {
            foreach (var room in rooms)
            {
                // 🔹 Wrap entire room section in a card container
                col.Item().PaddingBottom(10) // spacing between cards
                    .Border(1)
                    .BorderColor(Colors.Green.Darken2)
                    .CornerRadius(6)
                    .Padding(6)
                    .Background(Colors.White)
                    .Column(roomCol =>
                    {
                        // Room Header Row
                        roomCol.Item()
                            .Background("#bcd8c1")
                            .Padding(4)
                            .Row(r =>
                            {
                                r.RelativeItem().PaddingLeft(6).Text("Room").Bold();
                                r.RelativeItem().AlignCenter().Text("Building").Bold();
                                r.RelativeItem().AlignCenter().Text("Block").Bold();
                                r.RelativeItem().AlignCenter().Text("Floor").Bold();
                            });

                        // Room Details Row
                        roomCol.Item()
                            .Background("#d1e7dd")
                            .Padding(6)
                            .Row(row =>
                            {
                                row.RelativeItem().AlignLeft().PaddingLeft(6).Text(room.RoomName).Bold();
                                row.RelativeItem().AlignCenter().Text(!string.IsNullOrWhiteSpace(room.BuildingName) ? room.BuildingName : "-");
                                row.RelativeItem().AlignCenter().Text(!string.IsNullOrWhiteSpace(room.BlockName) ? room.BlockName : "-");
                                row.RelativeItem().AlignCenter().Text(!string.IsNullOrWhiteSpace(room.FloorName) ? room.FloorName : "-");
                            });

                        // Room Stats
                        roomCol.Item().PaddingVertical(5)
                            .BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                            .Row(r =>
                            {
                                r.RelativeItem().AlignCenter().Text($"Capacity: {room.Capacity}").Bold();
                                r.RelativeItem().AlignCenter().Text($"Allocated: {room.TotalAllocated}").Bold();
                                r.RelativeItem().AlignCenter().Text($"Remaining: {room.TotalRemaining}").Bold();
                            });

                        // Reservations Header
                        roomCol.Item()
                            .Background("#bcd8c1")
                            .Padding(4)
                            .Row(r =>
                            {
                                r.RelativeItem().PaddingLeft(6).Text("Devotee Code").Bold();
                                r.RelativeItem().Text("Devotee Name").Bold();
                                r.RelativeItem().Text("Check-In Date").Bold();
                                r.RelativeItem().Text("Check-Out Date").Bold();
                                r.ConstantItem(60).AlignRight().Text("Alloc.").Bold();
                            });

                        // Reservations List
                        if (room.Reservations.Any())
                        {
                            foreach (var res in room.Reservations)
                            {
                                roomCol.Item().Padding(4)
                                    .Row(r =>
                                    {
                                        r.RelativeItem().PaddingLeft(6).Text(res.DevoteeCode);
                                        r.RelativeItem().Text(res.DevoteeName);
                                        r.RelativeItem().Text(res.FromDate.ToString("dd-MMM-yyyy"));
                                        r.RelativeItem().Text(res.ToDate.ToString("dd-MMM-yyyy"));
                                        r.ConstantItem(60).AlignRight().Text(res.Allocated.ToString());
                                    });
                            }
                        }
                        else
                        {
                            roomCol.Item().Padding(5)
                                .Text("No active reservations")
                                .Italic()
                                .FontColor(Colors.Grey.Darken1);
                        }
                    }); // End of room card
            }

            // Final Totals
            var totalCapacity = rooms.Sum(r => r.Capacity);
            var totalAllocated = rooms.Sum(r => r.TotalAllocated);
            var totalRemaining = rooms.Sum(r => r.TotalRemaining);

            col.Item().PaddingTop(10)
                .BorderTop(3).BorderColor(Colors.Green.Darken3)
                .Row(r =>
                {
                    r.RelativeItem().AlignCenter().Text($"Total Capacity: {totalCapacity}").Bold().FontSize(11);
                    r.RelativeItem().AlignCenter().Text($"Total Allocated: {totalAllocated}").Bold().FontSize(11);
                    r.RelativeItem().AlignCenter().Text($"Total Remaining: {totalRemaining}").Bold().FontSize(11);
                });
        });
    }
}