using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDataStandardizer
{
    interface IDataFormatter
    {
        DataRow FormatRow(DataTable standardTable, DataRow customRow);
    }
}
