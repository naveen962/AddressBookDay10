using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace CSVFileDemo
{
    class CsvHandler
    {
        public static void csvImplementHandling()
        {
            string importFilePath = @"F:\JSON\Address.csv";
            string exportFilePath = @"F:\JSON\Export.csv";
           // string exportJsonFilePath = @"F:\JSON\Export.json";
            using (var reader = new StreamReader(importFilePath))

            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data successfully");

                foreach (AddressData addressData in records)
                {
                    Console.WriteLine(addressData.firstname);
                    Console.WriteLine(addressData.lastname);
                    Console.WriteLine(addressData.address);
                    Console.WriteLine(addressData.city);
                    Console.WriteLine(addressData.state);
                    Console.WriteLine(addressData.phno);
                    Console.WriteLine(addressData.zipcode);

                }


               
                Console.WriteLine("*******************************");

                using (var writer = new StreamWriter(exportFilePath))

                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }


                //JsonSerializer serializer = new JsonSerializer();

                //using (StreamWriter sw = new StreamWriter(exportJsonFilePath))

                //using (JsonWriter writer = new JsonTextWriter(sw)) 
                //{
                //    serializer.Serialize(writer, records);
                //}
            }
        }
    }
}

