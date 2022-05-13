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
            var pdfPages = GetPdfContent(fileName);
        }
        public void PrintText(string fileName)
        {
            var pdfPages = GetPdfContent(fileName);
            var pageNumber = 1;
            foreach (var pageContent in pdfPages)
            {
                Console.WriteLine($"----- {pageNumber++} -----");
                Console.WriteLine(pageContent);
            }
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
