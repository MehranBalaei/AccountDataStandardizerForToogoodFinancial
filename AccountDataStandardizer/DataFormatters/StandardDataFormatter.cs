using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDataStandardizer
{
    class StandardDataFormatter : IDataFormatter
    {
        //We don't have to have this class for standard format, since no standarization is required,
        // But I decided to add this for consistency.
        public DataRow FormatRow(DataTable standardTable, DataRow customRow)
        {
            return customRow;
        }
    }
}
