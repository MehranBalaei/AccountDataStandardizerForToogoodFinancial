using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDataStandardizer
{
    class MockStandardFormatDataReader: IDataReader
    {
        public DataTable Table { get; }

        //Providing sample data rows for demonstration/testing purposes.
        public MockStandardFormatDataReader()
        {
            Table = new StandardDataTable();

            //Adding the mock data rows.
            Table.Rows.Add("AbcCode",       "My Account",       "RRSP",     "2018-01-01", "CAD");
            Table.Rows.Add("85db6b",        "Roger Federer",    "RESP",     "2011-11-21", "USD");
            Table.Rows.Add("aa37",          "Rafa Nadal",       "Trading",  "2013-01-01", "USD");
            Table.Rows.Add("8a7b20",        "Sasha Zverev",     "Fund",     "2014-09-05", "USD");
            Table.Rows.Add("a3c5",          "Milos Raonic",     "Fund",     "2017-12-29", "CAD");
            Table.Rows.Add("d2b97d836a2c",  "Stan Wawrinka",    "RRSP",     "2016-04-07", "CAD");
            Table.Rows.Add("d397",          "John Isner",       "Fund",     "2010-05-13", "USD");
        }

        public DataTable GetDataTable()
        {
            return Table;
        }
    }
}
