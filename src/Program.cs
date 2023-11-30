
using System.Net;
using IronPdf;

// ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;

//IronPdf.License.LicenseKey = "";
IronPdf.Installation.ConnectToIronPdfHost(new IronPdf.GrpcLayer.IronPdfConnectionConfiguration()
{
    ConnectionType = IronPdf.GrpcLayer.IronPdfConnectionType.Docker,
    Host = "localhost",
    Port = 33350,
});
IronPdf.Installation.SkipShutdown = true;
IronPdf.Installation.SkipInitialization = true;
IronPdf.Installation.AutomaticallyDownloadNativeBinaries = false;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<span style=\"font-family: 'Courier'\">THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG<span>");
pdf.SaveAs("ironpdf.pdf");