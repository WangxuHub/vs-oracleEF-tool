using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopLevelMenu.Model
{
    public class ProjectEdmxItem
    {
        public List<EdmxItem> EdmxPath { get; set; } = new List<EdmxItem>();

        public List<ConnectionStringItem> ConnectionString { get; set; } = new List<ConnectionStringItem>();
    }

    public class ConnectionStringItem
    {
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        public string Datasource { get; set; }
        public string DatabaseUserName { get; set; }

        public string DisplayName { get; set; }
    }

    public class EdmxItem
    {
        public string ShortFileName { get; set; }

        public string FullFileName { get; set; }
    }
}
