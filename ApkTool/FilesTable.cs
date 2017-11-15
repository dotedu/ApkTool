using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkTool
{
    class FilesTable
    {
        DataTable dt = new DataTable("cart");
        DataColumn dc1 = new DataColumn("prizename", Type.GetType("System.String"));
        DataColumn dc2 = new DataColumn("point", Type.GetType("System.Int16"));
        DataColumn dc3 = new DataColumn("number", Type.GetType("System.Int16"));
        DataColumn dc4 = new DataColumn("totalpoint", Type.GetType("System.Int64"));
        DataColumn dc5 = new DataColumn("prizeid", Type.GetType("System.String"));
        

    }
}
