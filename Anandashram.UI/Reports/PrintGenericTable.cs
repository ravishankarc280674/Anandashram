using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Anandashram.Reports
{
    public class PrintGenericTable : IDocument
    {
        public Company Company { get; }
        public string Title { get; }
        public List<GenericItemDTO> Items { get; }

        public PrintGenericTable(Company company, string title, List<GenericItemDTO> items)
        {
            Company = company ?? new Company();
            Title = title;
            Items = items ?? new List<GenericItemDTO>();
        }

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(20);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Arial Narrow"));

                // Header with company info
                page.Header().Element(Header);

                // Content: table
                page.Content().Padding(10).Border(2).BorderColor(Colors.Green.Darken2)
                    .CornerRadius(8)
                    .Element(Content);

                // Footer with page number
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
                if (!string.IsNullOrEmpty(Company.Website))
                    col.Item().AlignCenter().Hyperlink($"https://{Company.Website}")
                        .Text($"{Company.Website}").FontSize(9).Underline().FontColor(Colors.Blue.Medium);

                col.Item().PaddingVertical(6)
                    .BorderTop(1).BorderBottom(2)
                    .BorderColor(Colors.Green.Darken2)
                    .AlignCenter()
                    .Text(Title).FontSize(12).Bold().FontColor(Colors.Green.Darken3);
            });
        }

        void Content(QuestPDF.Infrastructure.IContainer container)
        {
            container.Table(table =>
            {
                // Define columns
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });

                // Table header
                table.Header(header =>
                {
                    header.Cell().Background(Colors.Green.Darken2).Padding(5).Text("Name").Bold().FontColor(Colors.White);
                    header.Cell().Background(Colors.Green.Darken2).Padding(5).Text("Description").Bold().FontColor(Colors.White);
                });

                // Table rows
                bool isEven = true;
                foreach (var item in Items)
                {
                    table.Cell().Background(isEven ? Colors.Grey.Lighten3 : Colors.White).Padding(5).Text(item.Name);
                    table.Cell().Background(isEven ? Colors.Grey.Lighten3 : Colors.White).Padding(5).Text(item.Description);
                    isEven = !isEven;
                }
            });
        }
    }
}
