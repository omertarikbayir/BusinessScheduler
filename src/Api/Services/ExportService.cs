using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml;

namespace BusinessScheduler.Api.Services;

public class ExportService
{
    public byte[] GeneratePdfAgenda(string title, string content)
    {
        var document = Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Content().Text($"{title}\n{content}");
            });
        });
        return document.GeneratePdf();
    }

    public byte[] GeneratePptxAgenda(string title, string content)
    {
        // Placeholder: Full OpenXML slide generation for production
        return System.Text.Encoding.UTF8.GetBytes($"PPTX: {title}\n{content}");
    }
}