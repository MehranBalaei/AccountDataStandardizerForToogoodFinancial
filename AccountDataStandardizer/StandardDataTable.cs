using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDataStandardizer
{
    public class StandardDataTable:DataTable
    {
        public StandardDataTable()
        {
            Columns.Add("AccountCode", typeof(string));
            Columns.Add("Name", typeof(string));
            Columns.Add("Type", typeof(string));
            Columns.Add("OpenDate", typeof(string));
            Columns.Add("Currency", typeof(string));
        }
    }
}
