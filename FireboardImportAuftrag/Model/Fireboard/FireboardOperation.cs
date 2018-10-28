using System.Xml.Serialization;
using FireboardImportAuftrag.Model;

namespace FireboardImportAuftrag.Model.Fireboard
{
    [XmlRoot(ElementName = "fireboardOperation", Namespace = "")]
    public class FireboardOperation
    {
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; } = "1.0";

        [XmlElement(ElementName = "uniqueId")]
        public string UniqueId { get; set; }

        [XmlElement(ElementName = "basicData")]
        public BasicData BasicData { get; set; }
    }
}