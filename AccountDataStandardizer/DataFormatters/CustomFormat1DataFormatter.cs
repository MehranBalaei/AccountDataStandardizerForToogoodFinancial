using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDataStandardizer
{
    class CustomFormat1DataFormatter : IDataFormatter
    {

        //This method converts a row containing custom format 1 to a row containing standard format data.
        public DataRow FormatRow(DataTable standardTable, DataRow customRow)
        {
            DataRow resultRow = standardTable.NewRow();

            string identifier = customRow["Identifier"].ToString();
            resultRow["AccountCode"] = identifier.Substring(identifier.IndexOf('|') + 1);

            resultRow["Name"] = customRow["Name"];

            string type;
            switch ( customRow["Type"])
            {
                case "1": type = "Trading";
                    break;
                case "2": type = "RRSP";
                    break;
                case "3": type = "RESP";
                    break;
                case "4": type = "Fund";
                    break;
                default: type = "";
                    break;
            }
            resultRow["Type"] = type;

            DateTime dt = DateTime.ParseExact(customRow["Opened"].ToString(), "dd-mm-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            resultRow["OpenDate"] = dt.ToString("yyyy-mm-dd");

            string currency;
            switch ( customRow["Currency"])
            {
                case "CD" : currency = "CAD";
                    break;
                case "US":
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
