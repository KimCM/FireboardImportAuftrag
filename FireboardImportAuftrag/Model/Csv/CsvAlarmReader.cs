using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using LINQtoCSV;

namespace FireboardImportAuftrag.Model.Csv
{
    public class CsvAlarmReader
    {
        public static IEnumerable<CsvAlarm> ReadAlarms(string filename)
        {
            var inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ',',
                TextEncoding = Encoding.UTF8,
                FileCultureInfo = new CultureInfo("en-US"),
                FirstLineHasColumnNames = true
            };

            var cc = new CsvContext();
            var alarms = cc.Read<CsvAlarm>(filename, inputFileDescription).ToList();
            return alarms;
        }
    }
}