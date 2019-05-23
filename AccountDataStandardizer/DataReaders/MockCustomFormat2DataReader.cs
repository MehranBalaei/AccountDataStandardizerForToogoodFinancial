using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDataStandardizer
{
    class MockCustomFormat2DataReader : IDataReader
    {
        public DataTable Table { get; }

        //Providing sample data rows for demonstration/testing purposes.
        public MockCustomFormat2DataReader()
        {
            Table = new DataTable();
            Table.Columns.Add("0", typeof(string));//Name
            Table.Columns.Add("1", typeof(string));//Type
            Table.Columns.Add("2", typeof(string));//Currency
            Table.Columns.Add("3", typeof(string));//Custodian Code

            //Adding the mock data rows.
            Table.Rows.Add("My Account",    "RRSP",     "C", "342");
            Table.Rows.Add("John Doe",      "RESP",     "C", "45");
            Table.Rows.Add("Dave Bowe",     "Fund",     "U", "8");
            Table.Rows.Add("Ali Carter",    "RRSP",     "U", "894");
            Table.Rows.Add("Joe Perry",     "Trading",  "C", "31");
        }

        public DataTable GetDataTable()
        {
            return Table;
        }
    }
}
