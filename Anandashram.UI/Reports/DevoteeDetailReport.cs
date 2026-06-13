using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Anandashram.Reports;

public class DevoteeDetailReport : IDocument
{
    public Company Company { get; }
    public Devotee Devotee { get; }
    public string Subject { get; }

    public DevoteeDetailReport(Company company, Devotee devotee, string subject)
    {
        Company = company ?? new Company();
        Devotee = devotee ?? throw new ArgumentNullException(nameof(devotee));
        Subject = subject ?? string.Empty;
    }

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Size(PageSizes.A4.Landscape());
            page.Margin(20);
            page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Arial Narrow"));
            page.PageColor(Colors.White);

            page.Header().Element(ComposeCompanyHeader);

            page.Content().Padding(10).Column(col =>
            {
                col.Item().Element(ComposeDevoteeHeader);
                col.Item().PaddingTop(10).Element(ComposeReservations);
            });

            page.Footer().AlignRight().Text(txt =>
            {
                txt.Span("Page ").FontSize(9);
                txt.CurrentPageNumber().FontSize(9).Bold();
                txt.Span(" of ").FontSize(9);
                txt.TotalPages().FontSize(9);
            });
        });
    }

    void ComposeCompanyHeader(QuestPDF.Infrastructure.IContainer container)
    {
        container.Column(col =>
        {
            col.Item().AlignCenter().Text(Company.Name).FontSize(14).Bold();
            col.Item().AlignCenter().Text($"{Company.AddressLine1} {Company.AddressLine2}".Trim()).FontSize(9);
            col.Item().AlignCenter().Text($"{Company.State}, {Company.Country} - {Company.PinCode}".Trim()).FontSize(9);
            col.Item().AlignCenter().Text($"Mobile: {Company.Mobile} | Email: {Company.Email}").FontSize(9);
            if (!string.IsNullOrWhiteSpace(Company.Website))
                col.Item().AlignCenter().Hyperlink($"https://{Company.Website}")
                    .Text(Company.Website).FontSize(9).Underline().FontColor(Colors.Blue.Medium);

            col.Item().PaddingVertical(6)
                .BorderTop(1).BorderBottom(2)
                .BorderColor(Colors.Green.Darken2)
                .AlignCenter()
                .Text(Subject)
                .FontSize(12).Bold().FontColor(Colors.Green.Darken3);
        });
    }

    void ComposeDevoteeHeader(QuestPDF.Infrastructure.IContainer container)
    {
        container.Column(col =>
        {
            // Name + Code Box, smaller height
            col.Item().Background(Colors.Green.Lighten4)
                .PaddingVertical(4)
                .PaddingHorizontal(6)
                .Text($"{Devotee.Name} ({Devotee.Code})")
                .FontSize(12)
                .SemiBold()
                .FontColor(Colors.Green.Darken3)
                .AlignCenter();

            // Other info with wrap
            col.Item().PaddingTop(2).Text(txt =>
            {
                txt.Span("Category: ").Bold().FontColor(Colors.Black);
                txt.Span(Devotee.DevoteeCategoryName ?? "").FontColor(Colors.Black);
            });

            col.Item().Text(txt =>
            {
                txt.Span("Mobile: ").Bold();
                txt.Span(Devotee.Mobile ?? "").FontColor(Colors.Black);
            });

            col.Item().Text(txt =>
            {
                txt.Span("Document: ").Bold();
                txt.Span(Devotee.Document ?? "").FontColor(Colors.Black);
            });

            col.Item().Text(txt =>
            {
                txt.Span("No. of People: ").Bold();
                txt.Span(Devotee.NoOfPeople.ToString()).FontColor(Colors.Black);
            });

            var address = $"{Devotee.AddressLine1} {Devotee.AddressLine2} {Devotee.State} {Devotee.Country} {Devotee.PinCode}".Trim();
            col.Item().Text(txt =>
            {
                txt.Span("Address: ").Bold();
                txt.Span(address).FontColor(Colors.Black);
            });

            // Reservations Heading
            col.Item().PaddingTop(8)
                .Text("Rooms Reservation List")
                .FontSize(12)
                .Bold()
                .FontColor(Colors.Green.Darken3)
                .AlignCenter();
        });
    }

    void ComposeReservations(QuestPDF.Infrastructure.IContainer container)
    {
        if (Devotee.Reservations == null || Devotee.Reservations.Count == 0)
        {
            container.AlignCenter().Text("No Reservation Found").Italic().FontColor(Colors.Grey.Darken2);
            return;
        }

        container.Table(table =>
        {
            var headerBackground = Colors.Green.Darken2;

            table.ColumnsDefinition(cols =>
            {
                cols.ConstantColumn(90);  // Room
                cols.RelativeColumn(2);  // Building
                cols.RelativeColumn(2);  // Block
                cols.RelativeColumn(2);  // Floor
                cols.ConstantColumn(70);   // From Date
                cols.ConstantColumn(70);   // To Date
                cols.ConstantColumn(60);  // Allocated
                cols.ConstantColumn(50);  // Closed
            });

            // Header row
            table.Header(header =>
            {
                header.Cell().Background(headerBackground).Padding(5).Text("Room").FontColor(Colors.White).Bold();
                header.Cell().Background(headerBackground).Padding(5).Text("Building").FontColor(Colors.White).Bold();
                header.Cell().Background(headerBackground).Padding(5).Text("Block").FontColor(Colors.White).Bold();
                header.Cell().Background(headerBackground).Padding(5).Text("Floor").FontColor(Colors.White).Bold();
                header.Cell().Background(headerBackground).Padding(5).Text("From Date").FontColor(Colors.White).Bold();
                header.Cell().Background(headerBackground).Padding(5).Text("To Date").FontColor(Colors.White).Bold();
                header.Cell().Background(headerBackground).Padding(5).Text("Allocated").FontColor(Colors.White).Bold();
                header.Cell().Background(headerBackground).Padding(5).Text("Closed").FontColor(Colors.White).Bold();
            });

            // Data Rows
            bool even = true;
            foreach (var r in Devotee.Reservations)
            {
                var bg = even ? Colors.Grey.Lighten3 : Colors.White;
                table.Cell().Background(bg).Padding(4).Text(r.RoomName);
                table.Cell().Background(bg).Padding(4).Text(r.BuildingName);
                table.Cell().Background(bg).Padding(4).Text(r.BlockName);
                table.Cell().Background(bg).Padding(4).Text(r.FloorName);
                table.Cell().Background(bg).Padding(4).Text(r.FromDate.ToString("dd/MM/yyyy"));
                table.Cell().Background(bg).Padding(4).Text(r.ToDate.ToString("dd/MM/yyyy"));
                table.Cell().Background(bg).Padding(4).AlignCenter().Text(r.Allocated.ToString());
                table.Cell().Background(bg).Padding(4).AlignCenter().Text(r.Closed ? "☑" : "☐");
                even = !even;
            }
        });
    }
}
