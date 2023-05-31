using System.Text;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using parsefile;

AsposeLicense license = new AsposeLicense();

Console.WriteLine("start app v 22.6!");
Document pdfDocument = new Document(@"inputfiles\imageinvoice.pdf");
var pageCount = pdfDocument.Pages.Count;
var fulltext = new StringBuilder();
for (var pageIndex = 1; pageIndex <= pageCount; pageIndex++)
{
    var box = pdfDocument.Pages[pageIndex].GetPageRect(true);

    Console.WriteLine("get page number " + pageIndex);
    var textFragmentAbsorber = new TextFragmentAbsorber()
    {
        TextSearchOptions = new TextSearchOptions(false)
    };
    pdfDocument.Pages[pageIndex].Accept(textFragmentAbsorber);
    var textFragmentCollection = textFragmentAbsorber.TextFragments;

    var segments = new List<string>();
    foreach (var textFragment in textFragmentCollection)
    {
        segments.Add(textFragment.Text);
        fulltext.Append(textFragment.Text).Append(" ");
    }
}

// Create a writer and open the file
TextWriter tw = new StreamWriter(@"inputfiles\parsed-text.txt");
tw.WriteLine(fulltext);
// Close the stream
tw.Close();
Console.WriteLine("finish the app");
Console.ReadLine();
