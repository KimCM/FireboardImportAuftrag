using System.Xml.Serialization;

namespace FireboardImportAuftrag.Model.Fireboard
{
    public class GeoLocation
    {
        [XmlElement(ElementName = "latitude")]
        public decimal Latitude { get; set; }

        [XmlElement(ElementName = "longitude")]
        public decimal Longitude { get; set; }
    }
}