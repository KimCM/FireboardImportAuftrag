using System.Xml.Serialization;

namespace FireboardImportAuftrag.Model.Fireboard
{
    public class BasicData
    {
        [XmlElement(ElementName = "externalNumber")]
        public string ExternalNumber { get; set; }

        [XmlElement(ElementName = "keyword")]
        public string Keyword { get; set; }

        [XmlElement(ElementName = "announcement")]
        public string Announcement { get; set; }

        [XmlElement(ElementName = "location")]
        public string Location { get; set; }

        [XmlElement(ElementName = "geo_location")]
        public GeoLocation GeoLocation { get; set; }

        [XmlElement(ElementName = "timestampStarted")]
        public FireboardTimestamp TimestampStarted { get; set; }

        [XmlElement(ElementName = "situation")]
        public string Situation { get; set; }
    }
}