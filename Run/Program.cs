using System.IO;
using Parser.Helper;

namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {
            var pdfFile = $"{Directory.GetCurrentDirectory()}/TestFiles/TheBlackCat.pdf";
            var pdfHelper = new PdfHelper();
            pdfHelper.ReadOutLoud(pdfFile, 1);
        }
    }
}