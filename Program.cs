using System;

namespace TestNamotion
{
    using Namotion.Reflection;

    /// <summary>
    /// This is a XML documentation
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The Main method
        /// </summary>
        public static void Main()
        {
            // Does not display anything, don't know why...
            Console.WriteLine(typeof(Program).GetXmlDocsSummary());

            //Displays the XML doc for the Main method
            Console.WriteLine(typeof(Program).GetMethod(nameof(Main)).GetXmlDocsSummary());

            // Should display the XML document for the method
            Console.WriteLine(typeof(XmlDocsExtensions).GetMethod(nameof(XmlDocsExtensions.ToXmlDocsContent)).GetXmlDocsSummary());
        }
    }
}
