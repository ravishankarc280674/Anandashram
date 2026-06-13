using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Anandashram.Reports;

    public class CFormReport : IDocument
    {
        private readonly CFormDTO _dto;

        public CFormReport(CFormDTO dto)
        {
            _dto = dto;
        }

        public DocumentMetadata GetMetadata()
        {
            return DocumentMetadata.Default;
        }

    public void Compose(QuestPDF.Infrastructure.IDocumentContainer container)
    {

        container.Page(page =>
        {
            page.Margin(20);

            page.Header()
                .Text("ARRIVAL REPORT OF FOREIGNER")
                .Bold()
                .FontSize(18)
                .AlignCenter();

            page.Content()
                .Column(col =>
                {
                    Section(col, "Personnel Details", section =>
                    {
                        section.Item().Row(row =>
                        {
                            row.RelativeItem()
                                .Column(details =>
                                {
                                    AddField(details, "First Name", _dto.FirstName);
                                    AddField(details, "Last Name", _dto.LastName);
                                    AddField(details, "Sex", _dto.Sex);
                                    AddField(details, "Date of Birth as in Passport", _dto.DOB);
                                    AddField(details, "Special Category", _dto.SpecialCategory);
                                    AddField(details, "Nationality", _dto.Nationality);
                                    AddField(details, "Address in country where residing permanently", _dto.Address);
                                });

                            row.ConstantItem(160)
                            .Height(150)
                            .Border(1)
                            .Padding(2)
                            .Image(_dto.PhotoBytes, ImageScaling.FitArea);

                            // FIT THE FRAME
                           // row.ConstantItem(160)
                           //.Height(190)
                           //.Border(1)
                           //.Padding(2)
                           //.Image(_dto.PhotoBytes, ImageScaling.Resize);
                        });
                    });

                });
        });
    }

    private void Section(
    ColumnDescriptor col,
    string title,
    Action<ColumnDescriptor> content)
    {
        col.Item().PaddingTop(10);

        col.Item()
            .Text(title)
            .Bold()
            .FontSize(14);

        col.Item()
            .Border(1)
            .Padding(5)
            .Column(content);
    }

    private void AddField(
    ColumnDescriptor col,
    string label,
    string value)
    {
        col.Item().Row(row =>
        {
            row.ConstantItem(250)
                .Text(label);

            row.RelativeItem()
                .Text(value ?? "");
        });
    }
}
