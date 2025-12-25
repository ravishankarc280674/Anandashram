using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Anandashram.Reports;

public class RoomAllocationDateWiseReport : IDocument
{
    private readonly Company _company;
    private readonly List<ReservationReportDTO> _data;
    private readonly string _subject;
    private readonly DateTime _from;
    private readonly DateTime _to;

    public RoomAllocationDateWiseReport(
        Company company,
        List<ReservationReportDTO> data,
        string subject,
        DateTime from,
        DateTime to)
    {
        _company = company ?? new Company();
        _data = data;
        _subject = subject;
        _from = from;
        _to = to;
    }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Margin(20);
            page.Size(PageSizes.A4.Landscape());

            page.Header().Element(ComposeHeader);
            page.Content().Element(ComposeTable);
            page.Footer().AlignCenter().Text(x =>
            {
                x.Span("Page ");
                x.CurrentPageNumber();
                x.Span(" / ");
                x.TotalPages();
            });
        });
    }

    // ================= HEADER =================
    private void ComposeHeader(QuestPDF.Infrastructure.IContainer container)
    {
        container.Column(col =>
        {
            // Company Name
            col.Item().AlignCenter().Text(_company.Name)
                .FontSize(18)
                .Bold()
                .FontColor(Colors.Green.Darken3);

            // Address
            col.Item().AlignCenter().Text(_company.AddressLine1)
                .FontSize(10)
                .FontColor(Colors.Grey.Darken1);

            col.Item().PaddingVertical(5).LineHorizontal(1);

            // Subject
            col.Item().AlignCenter().Text(_subject)
                .FontSize(14)
                .Bold()
                .FontColor(Colors.Green.Darken2);

            // Date Range
            col.Item().AlignCenter().Text($"From {_from:dd/MM/yyyy} To {_to:dd/MM/yyyy}")
                .FontSize(11)
                .FontColor(Colors.Grey.Darken1);

            col.Item().PaddingTop(5).LineHorizontal(1);
        });
    }

    // ================= TABLE =================
    private void ComposeTable(QuestPDF.Infrastructure.IContainer container)
    {
        container.PaddingTop(10).Table(table =>
        {
            table.ColumnsDefinition(columns =>
            {
                columns.RelativeColumn(2); // Devotee
                columns.RelativeColumn(2); // Category
                columns.RelativeColumn(2); // Room
                columns.RelativeColumn(1); // From
                columns.RelativeColumn(1); // To
                columns.RelativeColumn(1); // Allocated
            });

            // Header Row
            table.Header(header =>
            {
                header.Cell().Element(HeaderCell).Text("Devotee");
                header.Cell().Element(HeaderCell).Text("Category");
                header.Cell().Element(HeaderCell).Text("Room");
                header.Cell().Element(HeaderCell).Text("From");
                header.Cell().Element(HeaderCell).Text("To");
                header.Cell().Element(HeaderCell).AlignRight().Text("Allocated");
            });

            bool even = true;

            foreach (var r in _data)
            {
                var bg = even ? Colors.Grey.Lighten4 : Colors.White;

                table.Cell().Background(bg).Padding(4)
                    .Text($"{r.DevoteeCode} - {r.DevoteeName}");

                table.Cell().Background(bg).Padding(4)
                    .Text(r.DevoteeCategoryName);

                table.Cell().Background(bg).Padding(4)
                    .Text(r.RoomName);

                table.Cell().Background(bg).Padding(4)
                    .Text(r.FromDate.ToString("dd/MM/yyyy"));

                table.Cell().Background(bg).Padding(4)
                    .Text(r.ToDate.ToString("dd/MM/yyyy"));

                table.Cell().Background(bg).Padding(4)
                    .AlignRight()
                    .Text(r.Allocated.ToString());

                even = !even;
            }
        });
    }

    // ================= STYLES =================
    private static QuestPDF.Infrastructure.IContainer HeaderCell(QuestPDF.Infrastructure.IContainer container)
    {
        return container
            .Padding(5)
            .Background(Colors.Green.Lighten4)
            .Border(1)
            .BorderColor(Colors.Green.Darken1)
            .DefaultTextStyle(x => x.Bold());
    }
}
