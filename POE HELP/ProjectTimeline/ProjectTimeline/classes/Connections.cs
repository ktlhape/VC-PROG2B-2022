using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ProjectTimeline.classes
{
   public static class Connections
    {
        public static SqlConnection GetConeection()
        {
            string fileName = "ProjectDB.mdf";
            string filePath = Path.GetFullPath(fileName).Replace(@"\bin\Debug", @"\Data");
            string strCon = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={filePath};Integrated Security=True";

            return new SqlConnection(strCon);
        }
    }
}
