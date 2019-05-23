using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDataStandardizer
{
    class CustomFormat2DataFormatter : IDataFormatter
    {

        //This method converts a row containing custom format 1 to a row containing standard format data.
        public DataRow FormatRow(DataTable standardTable, DataRow customRow)
        {
            DataRow resultRow = standardTable.NewRow();

            resultRow["AccountCode"] = customRow[3].ToString();
            resultRow["Name"] = customRow[0].ToString();
            resultRow["Type"] = customRow[1].ToString();

            string currency;
            switch (customRow[2].ToString().ToUpper())
            {
                case "C": currency = "CAD";
                    break;
                case "U":
                    currency = "USD";
                    break;
                default:
                    currency = "";
                    break;
            }
            resultRow["Currency"] = currency;

            return resultRow;
        }
    }
}
