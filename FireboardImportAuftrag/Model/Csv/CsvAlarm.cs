using LINQtoCSV;

namespace FireboardImportAuftrag.Model.Csv
{
    public class CsvAlarm
    {
        [CsvColumn(Name="ExternalNumber", FieldIndex = 1)]
        public string ExternalNumber { get; set; }

        [CsvColumn(Name = "Keyword", FieldIndex = 2)]
        public string Keyword { get; set; }

        [CsvColumn(Name = "Announcement", FieldIndex = 3)]
        public string Announcement { get; set; }

        [CsvColumn(Name = "Location", FieldIndex = 4)]
        public string Location { get; set; }

        [CsvColumn(Name = "Latitude", FieldIndex = 5)]
        public decimal Latitude { get; set; }

        [CsvColumn(Name = "Longitude", FieldIndex = 6)]
        public decimal Longitude { get; set; }

        [CsvColumn(Name = "Situation", FieldIndex = 7)]
        public string Situation { get; set; }

        [CsvColumn(Name = "TimestampStarted", FieldIndex = 8)]
        public long? TimestampStarted { get; set; }

    }
}
