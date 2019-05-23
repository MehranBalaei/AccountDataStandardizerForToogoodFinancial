using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDataStandardizer
{
    // This class provides a method that converts source data to standard data.
    // This class does not have any field, so I made it a static class which has a static method.
    static class  DataConverter
    {
        //This method takes an IDataReader and an IDataFormatter and uses them to convert source rows to standard data rows.
        public static DataTable Convert(IDataReader dataReader, IDataFormatter dataFormatter)
        {
            var sourceDataTable = dataReader.GetDataTable();

            var destDataTable = new StandardDataTable();

            foreach (DataRow row in sourceDataTable.Rows)
            {
                var formattedRow = dataFormatter.FormatRow(destDataTable, row);
                destDataTable.Rows.Add(formattedRow.ItemArray);
            }

            return destDataTable;
        }
    }
}
