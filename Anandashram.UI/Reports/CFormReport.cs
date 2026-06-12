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

    public void Compose(IDocumentContainer container)
    {
        throw new NotImplementedException();
    }
}