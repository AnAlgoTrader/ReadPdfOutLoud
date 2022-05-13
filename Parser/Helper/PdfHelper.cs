using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Parser.Helper
{
    public class PdfHelper
    {
        public void ReadOutLoud(string fileName, int startFromPage)
        {
            var pdfContent = GetPdfContent(fileName);

        }

        private List<string> GetPdfContent(string fileName)
        {
            var pdfContent = new List<string>();
            using (var stream = File.OpenRead(fileName))
            using (UglyToad.PdfPig.PdfDocument document = UglyToad.PdfPig.PdfDocument.Open(stream))
            {
                for (int pageNumber = 1; pageNumber <= document.NumberOfPages; pageNumber++)
                {
                    var page = document.GetPage(pageNumber);
                    pdfContent.Add(string.Join(" ", page.GetWords()));
                }
            }
            return pdfContent;
        }
    }
}
