using System;
using FireboardImportAuftrag.Model.Csv;
using FireboardImportAuftrag.Model.Fireboard;

namespace FireboardImportAuftrag
{
    public class FireboardMapper
    {
        public FireboardOperation BuildOperation(CsvAlarm alarm)
        {
            return new FireboardOperation
            {
                UniqueId = BuildUniqueId("Import", alarm.ExternalNumber),
                BasicData = new BasicData
                {
                    ExternalNumber = alarm.ExternalNumber,
                    Announcement = alarm.Announcement,
                    Keyword = alarm.Keyword,
                    Location = alarm.Location,
                    GeoLocation = new GeoLocation
                    {
                        Latitude = alarm.Latitude,
                        Longitude = alarm.Longitude
                    },
                    TimestampStarted = new FireboardTimestamp {FbTimestamp = alarm.TimestampStarted.HasValue ? alarm.TimestampStarted.ToString() : string.Empty},
                    Situation = alarm.Situation
                }
            };
        }

        private string BuildUniqueId(string prefix, string suffix)
        {
            return $"{prefix}_{DateTime.Now:s}_{suffix}";
        }
    }
}