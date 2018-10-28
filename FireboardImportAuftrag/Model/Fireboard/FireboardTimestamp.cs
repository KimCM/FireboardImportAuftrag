using System.Xml.Serialization;

namespace FireboardImportAuftrag.Model.Fireboard
{
    public class FireboardTimestamp
    {
        [XmlElement(ElementName = "long")]
        public string FbTimestamp { get; set; }
    }
}