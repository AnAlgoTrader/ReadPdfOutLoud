using System;
using Parser.Helper;

namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {
            var pdfHelper = new PdfHelper();
            pdfHelper.ReadOutLoud();
        }
    }
}
