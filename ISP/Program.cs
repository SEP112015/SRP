using ISP.Interfaces;
using ISP.PrintScaner;
using System.Reflection;

public class Document
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public Document(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Document doc1 = new Document("Usando impresora SimplePrinter", "Imprimiendo", "Sebastian Escaño");
        Document doc2 = new Document("Usando impresora MultiFunctionPrinter", "Escaneando", "Sebastian Escaño");
        Document doc3 = new Document("Usando impresora MultiFunctionPrinter", "Imprimiendo", "Sebastian Escaño");

        IPrint simplePrinter = new Print();
        simplePrinter.Print(doc1);

        Scan multiFunctionPrinter = new Scan();
        multiFunctionPrinter.Print(doc3);
        multiFunctionPrinter.PrintScan(doc2);
    }
}
