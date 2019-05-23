using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDataStandardizer
{
    class XmlDataReader : IDataReader
    {
        public DataTable Table { get; }

        public XmlDataReader(string filePath)
        {
            // Here we should fill our data table using rows from XML file.
            throw new NotImplementedException("XmlDataReader class is not implemnted in this demo application.");
        }

        public DataTable GetDataTable()
        {
            return Table;
        }

    }
}
