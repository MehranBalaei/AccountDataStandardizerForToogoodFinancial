using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDataStandardizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a test project for Toogood Financial that converts custom data format to a sntandard type");
            Console.WriteLine("Author: Mehran Balaei (balaei@gmail.com)");
            Console.WriteLine("");


            Console.Write("Press a key to convert \"Custom Format 1\" data table:");
            Console.ReadLine();
            IDataReader dataReader = new MockCustomFormat1DataReader();
            IDataFormatter dataFormatter = new CustomFormat1DataFormatter();

            Console.WriteLine("_______________________________________________________________________________________");
            Console.WriteLine("Raw data:");
            DrawDataTableOnConsole(dataReader.GetDataTable());
            Console.WriteLine("_______________________________________________________________________________________");
            Console.WriteLine("Formatted data:");
            DataTable dataTable = DataConverter.Convert(dataReader, dataFormatter);
            DrawDataTableOnConsole(dataTable);


            Console.WriteLine("_______________________________________________________________________________________");
            Console.WriteLine();
            Console.Write("Press a key to convert \"Custom Format 2\" data table:");
            Console.ReadLine();
            dataReader = new MockCustomFormat2DataReader();
            dataFormatter = new CustomFormat2DataFormatter();
            Console.WriteLine("_______________________________________________________________________________________");
            Console.WriteLine("Raw data:");
            DrawDataTableOnConsole(dataReader.GetDataTable());
            Console.WriteLine("_______________________________________________________________________________________");
            Console.WriteLine("Formatted data:");
            dataTable = DataConverter.Convert(dataReader, dataFormatter);
            DrawDataTableOnConsole(dataTable);


            Console.WriteLine("_______________________________________________________________________________________");
            Console.WriteLine();
            Console.Write("Press a key to convert \"Standard Format\" data table (Result will be same as source data):");
            Console.ReadLine();
            dataReader = new MockStandardFormatDataReader();
            dataFormatter = new StandardDataFormatter();
            Console.WriteLine("_______________________________________________________________________________________");
            Console.WriteLine("Raw data:");
            DrawDataTableOnConsole(dataReader.GetDataTable());
            Console.WriteLine("_______________________________________________________________________________________");
            Console.WriteLine("Formatted data:");
            dataTable = DataConverter.Convert(dataReader, dataFormatter);
            DrawDataTableOnConsole(dataTable);

            Console.WriteLine("Press a key to exit.");
            Console.ReadLine();
        }

        private static void DrawDataTableOnConsole(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                Console.Write("|");
                for (int i=0;i<dataTable.Columns.Count;i++)
                {
                    Console.Write(string.Format("{0,15}|", row[i]));
                }
                Console.WriteLine();
            }
        }
    }
}
