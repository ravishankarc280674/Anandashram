using FastReport;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Anandashram.Reports;

public class RoomAllocationDateWise : IDocument
{
    public Company Company { get; }
    public List<RoomReportDTO> Rooms { get; }
    public DateTime SelectedDateTime { get; }
    public RoomAllocationDateWise(Company company, List<RoomReportDTO> rooms, DateTime selectedDateTime)
    {
        Company = company ?? new Company();
        Rooms = rooms ?? new List<RoomReportDTO>();
        SelectedDateTime = selectedDateTime;
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
                .Text("Rooms Alloted as of : " + SelectedDateTime.ToString("dd - MMM - yyyy")).FontSize(12).Bold().FontColor(Colors.Green.Darken3);
        });
    }
    // Constants for column widths
    const float TableWidth = 440; // reduce total width
    const float RoomColumnWidth = 200;
    const float CapacityColumnWidth = 80;
    void Content(QuestPDF.Infrastructure.IContainer content)
    {

        // Build grouped structure
        var grouped = Rooms
    .OrderBy(r => r.BuildingName)
    .ThenBy(r => r.BlockName)
    .ThenBy(r => r.FloorName)
    .GroupBy(g => new { g.BuildingName, g.BlockName, g.FloorName });

        content.Column(col =>
        {
            foreach (var group in grouped)
            {
                col.Item().PaddingTop(10)
                    .Element(c => DrawGroup(
                        c,
                        group.Key.BuildingName,
                        group.Key.BlockName,
                        group.Key.FloorName
                    ));
                col.Item().Element(TableHeader);
                // room rows
                foreach (var room in group)
                    col.Item().Element(c => DrawRoomRow(c, room));

                // Inline floor total
                var floorTotal = group.Sum(r => r.Capacity);
                var floorAllocatedTotal = group.Sum(r => r.TotalAllocated);
                var floorremainingTotal = group.Sum(r => r.TotalRemaining);
                col.Item()
                .Width(TableWidth)
                .PaddingVertical(5)
                .Background("#d5e8d4") // soft highlight (optional)
                .Element(x =>
                {
                    x.Row(row =>
                    {
                        row.ConstantItem(RoomColumnWidth)
                            .AlignLeft().PaddingLeft(6)
                            .Text("Subtotal:")
                            .Bold();

                        row.ConstantItem(CapacityColumnWidth)
                            .AlignRight().PaddingRight(6)
                            .Text(floorTotal.ToString())
                            .Bold();

                        row.ConstantItem(CapacityColumnWidth)
                            .AlignRight().PaddingRight(6)
                            .Text(floorAllocatedTotal.ToString())
                            .Bold();

                        row.ConstantItem(CapacityColumnWidth)
                            .AlignRight().PaddingRight(6)
                            .Text(floorremainingTotal.ToString())
                            .Bold();
                    });
                });
                col.Item()
               .Width(TableWidth)
               .PaddingVertical(3)
               .BorderBottom(1)
               .BorderColor(Colors.Grey.Lighten2);
            }

            // Final Total
            var grandCapacity = Rooms.Sum(r => r.Capacity);
            var grandAllocated = Rooms.Sum(r => r.TotalAllocated);
            var grandRemaining = Rooms.Sum(r => r.TotalRemaining);

            col.Item()
                .Width(TableWidth)
                .PaddingVertical(6)
                .Background("#cfe2f3")  // highlight (soft-blue)
                .Element(x =>
                {
                    x.Row(row =>
                    {
                        row.ConstantItem(RoomColumnWidth)
                            .AlignLeft().PaddingLeft(6)
                            .Text("Grand Total:")
                            .Bold().FontSize(11);

                        row.ConstantItem(CapacityColumnWidth)
                            .AlignRight().PaddingRight(6)
                            .Text(grandCapacity.ToString())
                            .Bold().FontSize(11);

                        row.ConstantItem(CapacityColumnWidth)
                            .AlignRight().PaddingRight(6)
                            .Text(grandAllocated.ToString())
                            .Bold().FontSize(11);

                        row.ConstantItem(CapacityColumnWidth)
                            .AlignRight().PaddingRight(6)
                            .Text(grandRemaining.ToString())
                            .Bold().FontSize(11);
                    });
                });
            // line under grand total
            col.Item()
                .Width(TableWidth)
                .PaddingBottom(8)
                .BorderBottom(1)
                .BorderColor(Colors.Grey.Darken1);
        });
    }

   

    void TableHeader(QuestPDF.Infrastructure.IContainer container)
    {
        container
            .Width(TableWidth)
            .Background("#d1e7dd") // Bootstrap success-light
            .Border(1).BorderColor("#0f5132")
            .PaddingVertical(6)
            .Element(x =>
            {
                x.Row(row =>
                {
                    row.ConstantItem(RoomColumnWidth)
                        .AlignLeft().PaddingLeft(6)
                        .Text("Room Name").Bold().FontSize(10).FontColor("#0f5132");

                    row.ConstantItem(CapacityColumnWidth)
                        .AlignRight().PaddingRight(6)
                        .Text("Capacity").Bold().FontSize(10).FontColor("#0f5132");
                    row.ConstantItem(CapacityColumnWidth)
                       .AlignRight().PaddingRight(6)
                       .Text("Allocated").Bold().FontSize(10).FontColor("#0f5132");
                    row.ConstantItem(CapacityColumnWidth)
                       .AlignRight().PaddingRight(6)
                       .Text("Remaining").Bold().FontSize(10).FontColor("#0f5132");
                });
            });
    }

    void DrawRoomRow(QuestPDF.Infrastructure.IContainer container, RoomReportDTO room)
    {
        bool isEvenRow = (Rooms.IndexOf(room) % 2 == 0);

        container
            .Width(TableWidth)
            .Background(isEvenRow ? Colors.White : "#e9f7ef") // success-very-light
            .BorderBottom(1)
            .BorderColor(Colors.Grey.Lighten3)
            .PaddingVertical(4)
            .Element(x =>
            {
                x.Row(row =>
                {
                    row.ConstantItem(RoomColumnWidth)
                        .AlignLeft().PaddingLeft(6)
                        .Text(room.RoomName);
                    row.ConstantItem(CapacityColumnWidth)
                        .AlignRight().PaddingRight(6)
                        .Text(room.Capacity.ToString());
                    row.ConstantItem(CapacityColumnWidth)
                      .AlignRight().PaddingRight(6)
                      .Text(room.TotalAllocated.ToString());
                    row.ConstantItem(CapacityColumnWidth)
                      .AlignRight().PaddingRight(6)
                      .Text(room.TotalRemaining.ToString());
                });
            });

    }

    void DrawGroup(QuestPDF.Infrastructure.IContainer container, string building, string block, string floor)
    {
        container
            .Width(TableWidth)
            .PaddingVertical(6)
            .Background(Colors.Grey.Lighten4)
            .Border(1)
            .BorderColor(Colors.Grey.Lighten2)
            .Padding(4)
            .Element(x =>
            {
                x.Row(row =>
                {
                    row.RelativeItem().Text($"Building: {building}").SemiBold().FontSize(10);
                    row.RelativeItem().Text($"Block: {block}").SemiBold().FontSize(10).AlignCenter();
                    row.RelativeItem().Text($"Floor: {floor}").SemiBold().FontSize(10).AlignRight();
                });
            });
    }
}