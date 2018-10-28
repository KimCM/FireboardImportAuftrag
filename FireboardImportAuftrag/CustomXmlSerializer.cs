using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace FireboardImportAuftrag
{
    public class CustomXmlSerializer
    {
        public string Serialize<T>(T o)
            where T : new()
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            var ns = new XmlSerializerNamespaces();


            using (var stringWriter = new Utf8StringWriter())
            {
                var settings = new XmlWriterSettings {Encoding = Encoding.UTF8, Indent = true};
                using (var xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    
                    xmlSerializer.Serialize(xmlWriter, o, ns);
                    var serialized = stringWriter.ToString();
                    return serialized;
                }
            }
        }
    }

    public sealed class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}