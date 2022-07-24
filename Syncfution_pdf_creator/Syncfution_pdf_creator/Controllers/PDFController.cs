using Microsoft.AspNetCore.Mvc;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;

namespace Syncfution_pdf_creator.Controllers
{
    public class PDFController : Controller
    {
        public IActionResult Index()
        {
            //Initialize HTML to PDF converter 
            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter();

            WebKitConverterSettings settings = new WebKitConverterSettings();

            //Set WebKit path
            settings.WebKitPath = @"\QtBinariesDotNetCore\";

            //Assign WebKit settings to HTML converter
            htmlConverter.ConverterSettings = settings;

            //Convert URL to PDF
            PdfDocument document = htmlConverter.Convert("https://www.google.com");

            FileStream fileStream = new FileStream("Sample.pdf", FileMode.CreateNew, FileAccess.ReadWrite);

            //Save and close the PDF document 
            document.Save(fileStream);
            document.Close(true);
            return View();
        }
    }
}
