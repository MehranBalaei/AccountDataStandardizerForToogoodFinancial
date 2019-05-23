using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDataStandardizer
{
    class CSVDataReader : IDataReader
    {
        public DataTable Table { get; }

        public CSVDataReader(string filePath)
        {
            // Here we should fill our data table using rows from CSV file.
            // The project details stated that I don't need to implement this part.
            throw new NotImplementedException("CSVDataReader class is not implemnted in this demo applicat");
        }

        public DataTable GetDataTable()
        {
            return Table;
        }

    }
}
