using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Anandashram.Reports;
public class RoomsReport : IDocument
{
    public IEnumerable<RoomDTO> Rooms { get; }

    public RoomsReport(IEnumerable<RoomDTO> rooms)
    {
        Rooms = rooms;
    }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Margin(20);
            page.Size(PageSizes.A4);

            page.Header()
                .Text("Rooms List")
                .SemiBold().FontSize(18).AlignCenter();

            page.Content().Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(130); // Building
                    columns.ConstantColumn(120); // Block
                    columns.ConstantColumn(120); // Floor
                    columns.RelativeColumn(80); // Room
                    columns.ConstantColumn(60); // Capacity
                });

                // Headings
                table.Header(header =>
                {
                    header.Cell().Text("Building").Bold();
                    header.Cell().Text("Block").Bold();
                    header.Cell().Text("Floor").Bold();
                    header.Cell().Text("Room").Bold();
                    header.Cell().Text("Capacity").Bold();
                });

                foreach (var room in Rooms)
                {
                    table.Cell().Text(room.BuildingName);
                    table.Cell().Text(room.BlockName);
                    table.Cell().Text(room.FloorName);
                    table.Cell().Text(room.RoomName);
                    table.Cell().Text(room.Capacity.ToString());
                }
            });

            page.Footer()
                .AlignRight()
                .Text(text =>
                {
                    text.Span("Generated: ").FontSize(9);
                    text.Span(DateTime.Now.ToString("dd-MMM-yyyy")).FontSize(9);
                });
        });
    }
}