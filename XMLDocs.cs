using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace APJPaletteSet
{
    internal class XMLDocs
    {
        internal static string XMLFile()
        {
            string xmlFile = @"C:\Users\Public\Documents\Autodesk\AutoCAD Architecture\Library\DetailsList\apjList.xml";
            return xmlFile;
        }
        internal static XDocument GetXMLDoc()
        {
            try
            {
                var xml = XDocument.Load(XMLFile());
                return xml;
            }
            catch (FileNotFoundException)
            {
                new XDocument(new XElement("Lista")).Save(XMLFile());

                var xml = XDocument.Load(XMLFile());
                return xml;
            }
        }
        internal static void AddXMLDoc(string _group, string _value)
        {
            XDocument xml = GetXMLDoc();
            XElement root = xml.Root;
            root.Add(new XElement(_group, new XAttribute("nome", _value)));
            xml.Save(XMLDocs.XMLFile());

            XDocument loadXML = XDocument.Load(XMLFile());
            var attOrder = loadXML.Element("Lista").Elements().OrderBy(tag => (string)tag.Attribute("nome"));
            XDocument tempXML = new XDocument(new XElement("Lista", attOrder));
            var tagOrder = tempXML.Element("Lista").Elements().OrderBy(tag => (tag.Name).ToString());
            XDocument saveXML = new XDocument(new XElement("Lista", tagOrder));
            saveXML.Save(XMLFile());
        }
        internal static void DelXMLDoc(string _group, string _value)
        {
            XDocument xml = GetXMLDoc();
            var att = xml.Descendants(_group)
                          .Where(x => (string)x.Attribute("nome") == _value);
            att.Remove();
            xml.Save(XMLDocs.XMLFile());

            XDocument loadXML = XDocument.Load(XMLFile());
            var attOrder = loadXML.Element("Lista").Elements().OrderBy(tag => (string)tag.Attribute("nome"));
            XDocument tempXML = new XDocument(new XElement("Lista", attOrder));
            var tagOrder = tempXML.Element("Lista").Elements().OrderBy(tag => (tag.Name).ToString());
            XDocument saveXML = new XDocument(new XElement("Lista", tagOrder));
            saveXML.Save(XMLFile());
        }
        internal static string ViewXMLDoc(string _group, string _value)
        {
            XDocument xml = GetXMLDoc();
            var att = xml.Descendants(_group)
                         .Where(x => (string)x.Attribute("nome") == _value);
            int count = att.Count();
            return count != 0 ? "Existe" : "!Existe";
        }
    }
}
