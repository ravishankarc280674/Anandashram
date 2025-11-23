using System;
using System.Collections.Generic;
using System.Linq;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Anandashram.Reports
{
    public class DevoteeCheckInReport : IDocument
    {
        public Company Company { get; }
        public List<ReservationReportDTO> Items { get; }
        public string Subject { get; }

        public DevoteeCheckInReport(Company company, List<ReservationReportDTO> items, string subject)
        {
            Company = company ?? new Company();
            Items = items ?? new();
            Subject = subject;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

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
                col.Item().AlignCenter().Text(Company.Name).FontSize(14).Bold();
                col.Item().AlignCenter().Text($"{Company.AddressLine1} {Company.AddressLine2}".Trim()).FontSize(9);
                col.Item().AlignCenter().Text($"{Company.State}, {Company.Country} - {Company.PinCode}".Trim()).FontSize(9);
                col.Item().AlignCenter().Text($"Mobile: {Company.Mobile} | Email: {Company.Email}").FontSize(9);

                if (!string.IsNullOrWhiteSpace(Company.Website))
                {
                    col.Item().AlignCenter().Hyperlink($"https://{Company.Website}")
                        .Text(Company.Website).FontSize(9).Underline().FontColor(Colors.Blue.Medium);
                }

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
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(2); // Code
                    columns.RelativeColumn(4); // Name
                    columns.RelativeColumn(3); // Room
                    columns.RelativeColumn(3); // ToDate
                    columns.RelativeColumn(2); // Allocated
                });

                table.Header(header =>
                {
                    header.Cell().Background(Colors.Green.Darken2).Padding(5)
                        .AlignCenter().Text("Code").SemiBold().FontColor(Colors.White);

                    header.Cell().Background(Colors.Green.Darken2).Padding(5)
                        .AlignLeft().Text("Name").SemiBold().FontColor(Colors.White);

                    header.Cell().Background(Colors.Green.Darken2).Padding(5)
                        .AlignCenter().Text("Room").SemiBold().FontColor(Colors.White);

                    header.Cell().Background(Colors.Green.Darken2).Padding(5)
                        .AlignCenter().Text("Check-Out").SemiBold().FontColor(Colors.White);

                    header.Cell().Background(Colors.Green.Darken2).Padding(5)
                        .AlignCenter().Text("Allocated").SemiBold().FontColor(Colors.White);
                });

                bool isEven = true;
                foreach (var item in Items)
                {
                    var bg = isEven ? Colors.Grey.Lighten3 : Colors.White;
                    isEven = !isEven;

                    table.Cell().Background(bg).Border(0.5f).BorderColor(Colors.Black)
                        .Padding(5).AlignCenter().Text(item.DevoteeCode ?? "-");

                    table.Cell().Background(bg).Border(0.5f).BorderColor(Colors.Black)
                        .Padding(5).AlignLeft().Text(item.DevoteeName ?? "-");

                    table.Cell().Background(bg).Border(0.5f).BorderColor(Colors.Black)
                        .Padding(5).AlignCenter().Text(item.RoomName ?? "-");

                    table.Cell().Background(bg).Border(0.5f).BorderColor(Colors.Black)
                        .Padding(5).AlignCenter().Text(item.ToDate.ToString("dd-MMM-yyyy"));

                    table.Cell().Background(bg).Border(0.5f).BorderColor(Colors.Black)
                        .Padding(5).AlignCenter().Text(item.Allocated.ToString());
                }

                var totalAllocated = Items.Sum(x => x.Allocated);

                table.Cell().Border(0.5f).BorderColor(Colors.Black)
                    .Padding(5).Text("");

                table.Cell().Border(0.5f).BorderColor(Colors.Black)
                    .Padding(5).Text("");

                table.Cell().Border(0.5f).BorderColor(Colors.Black)
                    .Padding(5).Text("");

                table.Cell().Border(0.5f).BorderColor(Colors.Black)
                    .Padding(5).AlignRight().Text("Total :").Bold();

                table.Cell().Border(0.5f).BorderColor(Colors.Black)
                    .Padding(5).AlignCenter().Text(totalAllocated.ToString()).Bold();
            });
        }
    }
}
