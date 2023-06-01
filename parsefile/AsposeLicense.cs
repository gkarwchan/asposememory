
using System.Text;
using Aspose.Pdf;

namespace parsefile;

public class AsposeLicense
{
    private static readonly string LicenseString =
        @"";

    static AsposeLicense()
    {
        try
        {
            var license = new License();
            using var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(LicenseString));

            license.SetLicense(memoryStream);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
            
    }
}