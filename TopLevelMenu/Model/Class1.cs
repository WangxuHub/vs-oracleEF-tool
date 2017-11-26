using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopLevelMenu.Model
{
    public class ProjectEdmxItem
    {
        public List<EdmxItem> EdmxPath = new List<EdmxItem>();

        public List<ConnectionStringItem> ConnectionString = new List<ConnectionStringItem>();
    }

    public class ConnectionStringItem
    {
        public string Name;
        public string ConnectionString;
        public string Datasource;
        public string DatabaseUserName;
    }

    public class EdmxItem
    {
        public string ShortFileName;

        public string FullFileName;
    }
}
