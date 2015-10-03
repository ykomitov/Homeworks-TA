namespace Processing.Xml
{
    using System.Xml;
    using System.Xml.XPath;
    using System.Xml.Xsl;

    public class ApplyStyleSheet
    {
        public static void Main()
        {
            string resultingFile = "result.html";

            // Load the xml document
            XPathDocument myXPathDoc = new XPathDocument("../../../01.CreateXml/catalogue.xml");

            // Load the xsl template
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            myXslTrans.Load("../../../01.CreateXml/catalogue.xsl");

            // Create the html output
            XmlTextWriter myWriter = new XmlTextWriter(resultingFile, null);
            myXslTrans.Transform(myXPathDoc, null, myWriter);

            System.Console.WriteLine("File {0} created in /bin/Debug!", resultingFile);

            // Automatically open the resulting html in the default browser
            System.Diagnostics.Process.Start("result.html");
        }
    }
}
