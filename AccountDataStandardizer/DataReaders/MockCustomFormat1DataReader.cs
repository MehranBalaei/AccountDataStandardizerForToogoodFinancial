using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDataStandardizer
{
    class MockCustomFormat1DataReader : IDataReader
    {
        public DataTable Table { get; }

        //Providing sample data rows for demonstration/testing purposes.
        public MockCustomFormat1DataReader()
        {

            Table = new DataTable();
            Table.Columns.Add("Identifier", typeof(string));
            Table.Columns.Add("Name", typeof(string));
            Table.Columns.Add("Type", typeof(string));
            Table.Columns.Add("Opened", typeof(string));
            Table.Columns.Add("Currency", typeof(string));


            //Adding the mock data rows.
            Table.Rows.Add("123|ABC",       "My Account",       "2", "01-01-2018", "CD");
            Table.Rows.Add("1|4c69c176",    "Leo Messi",        "1", "22-11-2017", "US");
            Table.Rows.Add("17|90fb",       "Chris Ronaldo",    "3", "15-12-2015", "CD");
            Table.Rows.Add("4782|3c661e",   "Kylian Mbappe",    "1", "06-07-1999", "CD");
            Table.Rows.Add("5|bd",          "Paolo Dybala",     "4", "01-06-2018", "CD");
            Table.Rows.Add("99|acbc43",     "Antoin Griezman",  "2", "07-09-2011", "US");
            Table.Rows.Add("45786|a12f1d",  "Diego Godin",      "1", "30-04-2013", "US");
            Table.Rows.Add("0|b9b",         "Mario Gotze",      "3", "25-05-2016", "CD");
        }

        public DataTable GetDataTable()
        {
            return Table;
        }

    }
}
