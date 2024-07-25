using ISP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.PrintScaner
{
    public class Print : IPrint
    {
        void IPrint.Print(Document document)
        {
            // Implementación del método de impresión
            Console.WriteLine($"Imprimiento docuemnto: {document.Title} by {document.Author}");
            Console.WriteLine(document.Content);
        }
    }
}
