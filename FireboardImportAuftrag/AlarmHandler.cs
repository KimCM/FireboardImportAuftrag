using System;
using System.Linq;
using System.Threading;
using FireboardImportAuftrag.Model.Csv;

namespace FireboardImportAuftrag
{
    public class AlarmHandler
    {
        public void ImportAlarms(string authKey, string filename, int waitMillisecondsBetweenAlarms = 10000)
        {
            var alarms = CsvAlarmReader.ReadAlarms(filename);

            var customSerializer = new CustomXmlSerializer();
            var fireboardConnector = new FireboardConnector(authKey);
            var fireboardMapper = new FireboardMapper();

            int i = 0;
            var alarmsCount = alarms.Count();
            foreach (var alarm in alarms)
            {
                i++;

                var fireboardOperation = fireboardMapper.BuildOperation(alarm);

                var xmlContent = customSerializer.Serialize(fireboardOperation);

                Console.WriteLine($"[{i:D5}]: Sende POST-Request mit ExternalId [{alarm.ExternalNumber}] an fireboard...");

                var task = fireboardConnector.PostFireboardOperation(xmlContent);

                Console.WriteLine($"Antwort von Fireboard: {task.Result}.");

                if (alarmsCount > i)
                {
                    Console.WriteLine($"Warte {waitMillisecondsBetweenAlarms}ms...");
                    Thread.Sleep(waitMillisecondsBetweenAlarms);
                }
            }
        }
    }
}