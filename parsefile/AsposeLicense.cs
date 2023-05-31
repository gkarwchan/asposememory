
using System.Text;
using Aspose.Pdf;

namespace parsefile;

public class AsposeLicense
{
    private static readonly string LicenseString =
        @"<License>
              <Data>
                <LicensedTo>WolfePak Software, LLC</LicensedTo>
                <EmailTo>licenses@wolfepak.com</EmailTo>
                <LicenseType>Developer OEM</LicenseType>
                <LicenseNote>2 Developers And Unlimited Deployment Locations</LicenseNote>
                <OrderID>211027195925</OrderID>
                <UserID>826942</UserID>
                <OEM>This is a redistributable license</OEM>
                <Products>
                  <Product>Aspose.PDF for .NET</Product>
                </Products>
                <EditionType>Professional</EditionType>
                <SerialNumber>1566e4e6-d3de-4b92-9c45-928c36275b15</SerialNumber>
                <SubscriptionExpiry>20221104</SubscriptionExpiry>
                <LicenseVersion>3.0</LicenseVersion>
                <LicenseInstructions>https://purchase.aspose.com/policies/use-license</LicenseInstructions>
              </Data>
              <Signature>F5Hh6Dr6gkPQcDGrlOaPwIiqsN9z1Gu65PvO4eJx4Qu6Oscfxo/fGvw6kPhDUDuS/DIW9IrFUjRf7yki2erngqKfiaihPrhLKdekCzEc8OUL47BP4WtcHaUs6sPAgqml6/WkyG/F5qzr/3mj1Zg5W5UVdRY4W/4IP3XG0EaQyBM=</Signature>
            </License>";

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