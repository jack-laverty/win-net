using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Globalization;

namespace FT3
{
    public class DatalogWriter
    {
        public static StreamWriter writer;
        public CsvWriter csv;

        public DatalogWriter()
        {
            writer = new StreamWriter("C:\\Uni\\Capstone\\source\\satellite-tracking\\datalogs\\test.csv");
            csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteHeader<Foo>();
            csv.NextRecord();
        }

        public void WriteData(DateTime dateTime)
        {
            var records = new List<Foo>
            {
                new Foo { Date = dateTime.Date.ToString("dd/MM/yyyy"), Time = dateTime.TimeOfDay, Azimuth = 0.0, Elevation = 0.0, Name = "test" }
            };

            foreach (var record in records)
            {
                csv.WriteRecord(record);
                csv.NextRecord();
            }

            writer.Flush();
        }

        public void CloseFileStream()
        {
            writer.Flush();
            writer.Close();
        }
    }
}
