using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
namespace Anandashram.Reports;

public class DevoteeCheckOutReport: IDocument
{
   
        public Company Company { get; }
        public List<DevoteeReportDTO> Items { get; }
        public string Subject { get; }

        public DevoteeCheckOutReport(Company company, List<DevoteeReportDTO> items, string subject)
        {
            Company = company ?? new Company();
            Items = items ?? new();
            Subject = subject;
        }

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(20);
                page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Arial Narrow"));
                page.PageColor(Colors.White);

                page.Header().Element(Header);

                page.Content().Padding(10).Border(2).BorderColor(Colors.Green.Darken2)
                    .CornerRadius(8)
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

        void Header(QuestPDF.Infrastructure.IContainer container)
        {


            container.PaddingBottom(6).Column(col =>
            {
                col.Item().AlignCenter().Text(Company.Name ?? "").FontSize(14).Bold();
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

    void Content(QuestPDF.Infrastructure.IContainer container)
    {
        container.Table(table =>
        {
            // Define column widths
            table.ColumnsDefinition(cols =>
            {
                cols.RelativeColumn(2); // Code
                cols.RelativeColumn(4); // Devotee Name
                cols.RelativeColumn(3); // Category
                cols.RelativeColumn(2); // Allocated
            });

            // Header row with background for entire row
            table.Header(header =>
            {
                header.Cell().Background(Colors.Green.Darken2).Padding(5)
                    .AlignCenter().Text("Code").SemiBold().FontColor(Colors.White);

                header.Cell().Background(Colors.Green.Darken2).Padding(5)
                    .AlignLeft().Text("Name").SemiBold().FontColor(Colors.White);

                header.Cell().Background(Colors.Green.Darken2).Padding(5)
                    .AlignCenter().Text("Category").SemiBold().FontColor(Colors.White);

                header.Cell().Background(Colors.Green.Darken2).Padding(5)
                    .AlignCenter().Text("Allocated").SemiBold().FontColor(Colors.White);
            });

            // Data rows
            bool isEven = true;
            foreach (var item in Items)
            {
                table.Cell().Background(isEven ? Colors.Grey.Lighten3 : Colors.White).Border(0.5f).BorderColor(Colors.Black)
                    .Padding(5).AlignCenter().Text(item.Code ?? "-");

                table.Cell().Background(isEven ? Colors.Grey.Lighten3 : Colors.White).Border(0.5f).BorderColor(Colors.Black)
                    .Padding(5).AlignLeft().Text(item.Name ?? "-");

                table.Cell().Background(isEven ? Colors.Grey.Lighten3 : Colors.White).Border(0.5f).BorderColor(Colors.Black)
                    .Padding(5).AlignCenter().Text(item.DevoteeCategoryName ?? "-");

                table.Cell().Background(isEven ? Colors.Grey.Lighten3 : Colors.White).Border(0.5f).BorderColor(Colors.Black)
                    .Padding(5).AlignCenter().Text(item.TotalAllocated.ToString());
                    isEven = !isEven;
            }

            // Totals row
            var totalAllocated = Items.Sum(x => x.TotalAllocated);

            table.Cell().Border(0.5f).BorderColor(Colors.Black)
                .Padding(5).Text("");

            table.Cell().Border(0.5f).BorderColor(Colors.Black)
                .Padding(5).Text("");

            table.Cell().Border(0.5f).BorderColor(Colors.Black)
                .Padding(5).AlignRight().Text("Total Allocated:").Bold();

            table.Cell().Border(0.5f).BorderColor(Colors.Black)
                .Padding(5).AlignCenter().Text(totalAllocated.ToString()).Bold();
        });
    }

}

