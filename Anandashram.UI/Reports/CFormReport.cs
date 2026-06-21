using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Presentation;
using Humanizer;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Diagnostics.Metrics;
using static QuestPDF.Helpers.Colors;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            page.MarginTop(30);
            page.MarginBottom(25);
            page.DefaultTextStyle(x => x
                .FontSize(10)
                .FontFamily("Arial Narrow"));
            page.PageColor(Colors.White);

            page.Header()
                .ShowOnce()
                .Element(container =>
                {
                    container
                        .Border(1)
                        .Background(Colors.Blue.Lighten4)
                        .CornerRadius(8)
                        .Padding(10)
                        .Column(col =>
                        {
                            col.Item()
                                .Text("FORM 'C'")
                                .Bold()
                                .FontSize(16)
                                .AlignCenter();

                            col.Item()
                                .PaddingTop(2)
                                .Text("ARRIVAL REPORT OF FOREIGNER IN ANANDASHRAM")
                                .SemiBold()
                                .FontSize(14)
                                .AlignCenter();
                        });
                });

            page.Content()
                .Column(col =>
                {
                    //1.PERSONAL DETAILS(+Photo)
                    Section(col, "PERSONEL DETAILS", section =>
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
                                    AddField(details, "Address in permanently residing Country", _dto.Address);
                                    AddField(details, "City", _dto.City);
                                    AddField(details, "Country", _dto.Country);
                                });

                            row.ConstantItem(160)
                            .Height(120)
                            .Border(1)
                            .Padding(2)
                            .Image(_dto.PhotoBytes, ImageScaling.FitArea);

                        });
                    });

                    //2.REFERENCE DETAILS IN INDIA
                    Section(col, "ADDRESS / REFERENCE DETAILS IN INDIA", section =>
                    {
                        section.Item().Row(row =>
                        {
                            row.RelativeItem()
                                .Column(details =>
                                {
                                    AddField(details, "Reference Address(If Any)", _dto.ReferenceAddress);
                                    AddField(details, "Reference State", _dto.ReferenceState);
                                    AddField(details, "Reference City/District", _dto.ReferenceCity);
                                    AddField(details, "Reference Pincode", _dto.ReferencePincode);
                                });
                        });
                    });
                    
                    //3.PASSPORT DETAILS
                    Section(col, "PASSPORT DETAILS", section =>
                    {
                        section.Item().Row(row =>
                        {
                            row.RelativeItem()
                                .Column(details =>
                                {
                                    AddField(details, "Passport Number", _dto.PassportNo);
                                    AddField(details, "Passport Issue City", _dto.PassportIssueCity);
                                    AddField(details, "Passport Issue Country", _dto.PassportIssueCountry);
                                    AddField(details, "Passport Date of Issue", _dto.PassportDateOfIssue);
                                    AddField(details, "Passport Date of Expiry", _dto.PassportDateOfExpiry);
                                });

                        });
                    });

                    
                    //4.VISA DETAILS
                    Section(col, "VISA DETAILS", section =>
                    {
                        section.Item().Row(row =>
                        {
                            row.RelativeItem()
                                .Column(details =>
                                {
                                    AddField(details, "Visa Number", _dto.VisaNumber);
                                    AddField(details, "Place Of Issue", $"{_dto.VisaCity}, {_dto.VisaCountry}");
                                    AddField(details, "Visa Date of Issue", _dto.VisaDateOfIssue);
                                    AddField(details, "Visa Date of Expiry", _dto.VisaDateOfExpiry);
                                    AddField(details, "Visa Type", _dto.VisaType);
                                    AddField(details, "Visa Sub Type", _dto.VisaSubType);
                                    AddField(details, "Arrived from Country", _dto.ArrivedFromCountry);
                                    AddField(details, "Arrived from City", _dto.ArrivedFromCity);
                                    AddField(details, "Date of Arrival in India", _dto.DateOfArrivalInIndia);
                                    AddField(details, "Arrived from Place in India", _dto.ArrivedFromPlaceInIndia);
                                    AddField(details, "Date of Arrival in Anandashram", _dto.DateOfArrivalInAnandAshram);
                                    AddField(details, "Time of Arrival in Anandashram", _dto.TimeOfArrivalInAnandAshram);
                                });
                        });
                    });

                    col.Item().PageBreak();

                    //5.ARRIVAL DETAILS
                    Section(col, "ARRIVAL DETAILS", section =>
                    {
                        section.Item().Row(row =>
                        {
                            row.RelativeItem()
                                .Column(details =>
                                {
                                    AddField(details, "Arrived from Country", _dto.ArrivedFromCountry);
                                    AddField(details, "Arrived from City", _dto.ArrivedFromCity);
                                    AddField(details, "Date of Arrival in India", _dto.DateOfArrivalInIndia);
                                    AddField(details, "Arrived from Place in India", _dto.ArrivedFromPlaceInIndia);
                                    AddField(details, "Date of Arrival in Anandashram", _dto.DateOfArrivalInAnandAshram);
                                    AddField(details, "Time of Arrival in Anandashram", _dto.TimeOfArrivalInAnandAshram);
                                    AddField(details, "Duration Of Stay", _dto.DurationOfStay.ToString());
                                });
                        });
                    });

                    //6.EMPLOYMENT & VISIT DETAILS
                    Section(col, "EMPLOYMENT & VISIT DETAILS", section =>
                    {
                        section.Item().Row(row =>
                        {
                            row.RelativeItem()
                                .Column(details =>
                                {
                                    AddField(details, "Is Employed In India", _dto.IsEmployedInIndia);
                                    AddField(details, "Purpose Of Visit", _dto.PurposeOfVisit);
                                });
                        });

                    });

                    //7.DESTINATION DETAILS
                    Section(col, "DESTINATION DETAILS", section =>
                    {
                        section.Item().Row(row =>
                        {
                            row.RelativeItem()
                                .Column(details =>
                                {
                                    AddField(details, "Next Destination", _dto.NextDestination);
                                    AddField(details, "Destination Country", _dto.DestinationCountry);
                                    AddField(details, "Destination State", _dto.DestinationState);
                                    AddField(details, "Destination City", _dto.DestinationCity);
                                    AddField(details, "Destination Place", _dto.Place);
                                });
                        });

                    });

                    //8.CONTACT DETAILS
                    Section(col, "CONTACT DETAILS", section =>
                    {
                        section.Item().Row(row =>
                        {
                            row.RelativeItem()
                                .Column(details =>
                                {
                                    AddField(details, "Contact Phone Number", _dto.ContactPhoneNumber);
                                    AddField(details, "Mobile Number", _dto.MobileNumber);
                                    AddField(details, "Permanent Country Phone Number", _dto.PermanentCountryPhone);
                                    AddField(details, "Permanent Country Mobile Number", _dto.PermanentCountryMobile);
                                });
                        });

                    });

                    //9.REMARKS
                    Section(col, "REMARKS", section =>
                    {
                        section.Item().Row(row =>
                        {
                            row.RelativeItem()
                                .Column(details =>
                                {
                                    AddField(details, "Remarks(If any)", _dto.Remarks);
                                });
                        });

                    });
                });
            page.Footer()
    .Column(col =>
    {
        col.Item()
            .AlignCenter()
            .Text(text =>
            {
                text.Span("Page ");
                text.CurrentPageNumber();
                text.Span(" of ");
                text.TotalPages();
            });

        col.Item()
            .AlignRight()
            .Text($"Ref: {_dto.DevoteeId}")
            .FontSize(8);
    });
        });
    }

    private static void Section(
    ColumnDescriptor col,
    string title,
    Action<ColumnDescriptor> content)
    {
        col.Item().PaddingTop(10);

        col.Item()
            .Border(1)
            .Background(Colors.Grey.Lighten2)
            .PaddingVertical(3)
            .Text(title)
            .Bold()
            .FontSize(14)
            .AlignCenter();

        col.Item()
            .Border(1)
            .Padding(10)
            .Column(content);
    }

    private static void AddField(
    ColumnDescriptor col,
    string label,
    string value)
    {
        col.Item().Row(row =>
        {
            row.ConstantItem(200)
               .Text(label)
               .SemiBold();

            row.RelativeItem()
                .Text(value ?? "");
        });
    }

}
