using System;
using System.Collections.Generic;
using System.Linq;
using Anandashram.DTO;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Anandashram.Reports
{
    public class DevoteeListReport : IDocument
    {
        public Company Company { get; }
        public List<DevoteeReportDTO> Items { get; }
        public string Subject { get; }

        public DevoteeListReport(Company company, List<DevoteeReportDTO> items, string subject = "Devotee List - Filter")
        {
            Company = company ?? new Company();
            Items = items ?? new List<DevoteeReportDTO>();
            Subject = string.IsNullOrWhiteSpace(subject) ? "Devotee List - Filter" : subject;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4.Landscape());
                page.Margin(18);
                page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Arial Narrow"));
                page.PageColor(Colors.White);

                page.Header().Element(Header);

                page.Content()
                    .Padding(8)
                    .Border(2)
                    .BorderColor(Colors.Green.Darken2)
                    .CornerRadius(6)
                    .Element(Content);

                page.Footer().AlignRight().Text(text =>
                {
                    text.Span("Page ").FontSize(9);
                    text.CurrentPageNumber().FontSize(9).Bold();
                    text.Span(" of ").FontSize(9);
                    text.TotalPages().FontSize(9);
                    text.Span("    Generated: ").FontSize(9);
                    text.Span(DateTime.Now.ToString("dd-MMM-yyyy HH:mm")).FontSize(9);
                });
            });
        }

        void Header(QuestPDF.Infrastructure.IContainer container)
        {
            container.PaddingBottom(6).Column(col =>
            {
                col.Item().AlignCenter().Text(Company?.Name ?? "").FontSize(14).Bold();
                col.Item().AlignCenter().Text($"{Company?.AddressLine1} {Company?.AddressLine2}".Trim()).FontSize(9);
                col.Item().AlignCenter().Text($"{Company?.State}, {Company?.Country} - {Company?.PinCode}".Trim()).FontSize(9);
                col.Item().AlignCenter().Text($"Mobile: {Company?.Mobile} | Email: {Company?.Email}").FontSize(9);

                if (!string.IsNullOrWhiteSpace(Company?.Website))
                    col.Item().AlignCenter().Hyperlink($"https://{Company.Website}")
                        .Text(Company.Website).FontSize(9).Underline().FontColor(Colors.Blue.Medium);

                col.Item().PaddingVertical(6)
                    .BorderTop(1).BorderBottom(2)
                    .BorderColor(Colors.Green.Darken2)
                    .AlignCenter()
                    .Text(Subject)
                    .FontSize(12).Bold().FontColor(Colors.Green.Darken3);

                // show run/date info below subject
                col.Item().AlignCenter().Text($"Report Date: {DateTime.Now:dd-MMM-yyyy}").FontSize(9);
            });
        }

        void Content(QuestPDF.Infrastructure.IContainer container)
        {
            container.Table(table =>
            {
                // Column widths (relative proportions tuned for landscape)
                table.ColumnsDefinition(cols =>
                {
                    cols.RelativeColumn(3);  // Code
                    cols.RelativeColumn(4);  // Name
                    cols.RelativeColumn(3);  // Category
                    cols.RelativeColumn(3);  // Start Date
                    cols.RelativeColumn(3);  // Mobile
                    cols.RelativeColumn(2);  // No. of Devotees
                    cols.RelativeColumn(4);  // Document
                    cols.RelativeColumn(6);  // Address
                });

                // Header row (paint each header cell so it looks like a full-row background)
                table.Header(header =>
                {
                    header.Cell().Background(Colors.Green.Darken2).Padding(6).AlignCenter().Text("Code").SemiBold().FontColor(Colors.White);
                    header.Cell().Background(Colors.Green.Darken2).Padding(6).AlignLeft().Text("Name").SemiBold().FontColor(Colors.White);
                    header.Cell().Background(Colors.Green.Darken2).Padding(6).AlignLeft().Text("Category").SemiBold().FontColor(Colors.White);
                    header.Cell().Background(Colors.Green.Darken2).Padding(6).AlignCenter().Text("Start Date").SemiBold().FontColor(Colors.White);
                    header.Cell().Background(Colors.Green.Darken2).Padding(6).AlignLeft().Text("Mobile").SemiBold().FontColor(Colors.White);
                    header.Cell().Background(Colors.Green.Darken2).Padding(6).AlignCenter().Text("No. of Devotees").SemiBold().FontColor(Colors.White);
                    header.Cell().Background(Colors.Green.Darken2).Padding(6).AlignLeft().Text("Document").SemiBold().FontColor(Colors.White);
                    header.Cell().Background(Colors.Green.Darken2).Padding(6).AlignLeft().Text("Address").SemiBold().FontColor(Colors.White);
                }); // repeat header on each page

                // Data rows with alternating backgrounds and wrapping
                var isEven = true;
                foreach (var item in Items)
                {
                    var bg = isEven ? Colors.Grey.Lighten3 : Colors.White;
                    isEven = !isEven;

                    // single-line combined address (Option A), but allow wrapping if long
                    var address = string.Join(", ",
                        new[]
                        {
                            item.AddressLine1,
                            item.AddressLine2,
                            item.State,
                            item.Country,
                            item.PinCode
                        }.Where(s => !string.IsNullOrWhiteSpace(s)));

                    // Code - center
                    table.Cell().Background(bg).Border(0.5f).BorderColor(Colors.Grey.Lighten2)
                        .Padding(6).AlignCenter()
                        .Text(item.Code ?? "-");

                    // Name - wrap
                    table.Cell().Background(bg).Border(0.5f).BorderColor(Colors.Grey.Lighten2)
                        .Padding(6).AlignLeft()
                         .Text(txt =>
                         {
                             txt.DefaultTextStyle(x => x.FontSize(10).LineHeight(1.1f));
                             txt.Span(item.Name ?? "-");
                         });

                    // Category - wrap
                    table.Cell().Background(bg).Border(0.5f).BorderColor(Colors.Grey.Lighten2)
                        .Padding(6).AlignLeft()
                        .Text(txt =>
                        {
                            txt.DefaultTextStyle(x => x.FontSize(10).LineHeight(1.1f));
                            txt.Span(item.DevoteeCategoryName ?? "-");
                        });

                    // Start Date - center
                    table.Cell().Background(bg).Border(0.5f).BorderColor(Colors.Grey.Lighten2)
                        .Padding(6).AlignCenter()
                        .Text(item.StartDate.ToString("dd/MM/yyyy"));

                    // Mobile - wrap (in case of long formats)
                    table.Cell()
                            .Background(bg)
                            .Border(0.5f)
                            .BorderColor(Colors.Grey.Lighten2)
                            .Padding(6)
                            .AlignLeft()
                          .Text(txt =>
                          {
                              txt.DefaultTextStyle(x => x.FontSize(10).LineHeight(1.1f));
                              txt.Span(item.Mobile ?? "-");
                          });
                    // No. of People - center
                    table.Cell().Background(bg).Border(0.5f).BorderColor(Colors.Grey.Lighten2)
                        .Padding(6).AlignCenter()
                        .Text(item.NoOfPeople.ToString());

                    // Document - wrap
                    table.Cell().Background(bg).Border(0.5f).BorderColor(Colors.Grey.Lighten2)
                        .Padding(6).AlignLeft()
                        .Text(txt =>
                        {
                            txt.DefaultTextStyle(x => x.FontSize(10).LineHeight(1.1f));
                            txt.Span(item.Document ?? "-");
                        });

                    // Address - wrap single line but allow wrap if long
                    table.Cell().Background(bg).Border(0.5f).BorderColor(Colors.Grey.Lighten2)
                        .Padding(6).AlignLeft()
                        .Text(txt =>
                        {
                            txt.DefaultTextStyle(x => x.FontSize(10).LineHeight(1.1f));
                            txt.Span(address ?? "-");
                        });
                }

                // Totals row - only Total People (sum of NoOfPeople)
                var totalPeople = Items.Sum(x => x.NoOfPeople);

                // Blank cells before total label
                table.Cell().Border(0.5f).BorderColor(Colors.Grey.Lighten2).Padding(6).Text("");
                table.Cell().Border(0.5f).BorderColor(Colors.Grey.Lighten2).Padding(6).Text("");
                table.Cell().Border(0.5f).BorderColor(Colors.Grey.Lighten2).Padding(6).Text("");
                // total label cell (right aligned)
                table.Cell().Border(0.5f).BorderColor(Colors.Grey.Lighten2)
                    .Padding(6).AlignRight().Text("Total Devotees:").Bold();
                // last two cells: document blank, address = total value
                table.Cell().Border(0.5f).BorderColor(Colors.Grey.Lighten2).Padding(6).Text("");
                table.Cell().Border(0.5f).BorderColor(Colors.Grey.Lighten2)
                    .Padding(6).AlignCenter().Text(totalPeople.ToString()).Bold();
                table.Cell().Border(0.5f).BorderColor(Colors.Grey.Lighten2).Padding(6).Text("");
                table.Cell().Border(0.5f).BorderColor(Colors.Grey.Lighten2).Padding(6).Text("");
            });
        }
    }
}
