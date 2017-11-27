using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var json = "[{\"EdmxPath\":[{\"ShortFileName\":\"EFOpenPlatform.edmx\",\"FullFileName\":\"I:\\\\第四版框架\\\\后台服务\\\\开放平台\\\\Dysoft.OpenPlatform.DB\\\\EFOpenPlatform.edmx\"}],\"ConnectionString\":[{\"Name\":\"EFOpenPlatformEntities\",\"ConnectionString\":\"DATA SOURCE=ORCL240;PASSWORD=zysoft;PERSIST SECURITY INFO=True;USER ID=DYKJ_OPENPLATFORM\",\"Datasource\":\"ORCL240\",\"DatabaseUserName\":\"DYKJ_OPENPLATFORM\"}]},{\"EdmxPath\":[{\"ShortFileName\":\"EFDySystem.edmx\",\"FullFileName\":\"I:\\\\第四版框架\\\\后台服务\\\\系统服务\\\\Dysoft.DySystem.DB\\\\EFDySystem.edmx\"}],\"ConnectionString\":[{\"Name\":\"EFDySystemEntities\",\"ConnectionString\":\"DATA SOURCE=ORCL240;PASSWORD=zysoft;PERSIST SECURITY INFO=True;USER ID=DYKJ_SYSTEMMANAGE\",\"Datasource\":\"ORCL240\",\"DatabaseUserName\":\"DYKJ_SYSTEMMANAGE\"}]},{\"EdmxPath\":[{\"ShortFileName\":\"EFBasicManage.edmx\",\"FullFileName\":\"I:\\\\第四版框架\\\\后台服务\\\\基础管理服务\\\\DySoft.BasicManage.DB\\\\EFBasicManage.edmx\"}],\"ConnectionString\":[{\"Name\":\"EFBasicManageEntities\",\"ConnectionString\":\"DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=192.168.1.240)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));PASSWORD=zysoft;USER ID=DYKJ_BASICPLATFORM\",\"Datasource\":\"(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=192.168.1.240)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)))\",\"DatabaseUserName\":\"DYKJ_BASICPLATFORM\"}]},{\"EdmxPath\":[{\"ShortFileName\":\"EFPowerManage.edmx\",\"FullFileName\":\"I:\\\\第四版框架\\\\后台服务\\\\权限管理服务\\\\DySoft.PowerManage.DB\\\\EFPowerManage.edmx\"}],\"ConnectionString\":[{\"Name\":\"EFPowerManageEntities\",\"ConnectionString\":\"DATA SOURCE=ORCL240;PASSWORD=zysoft;PERSIST SECURITY INFO=True;USER ID=DYKJ_POWERMANAGE\",\"Datasource\":\"ORCL240\",\"DatabaseUserName\":\"DYKJ_POWERMANAGE\"}]}]";

            var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TopLevelMenu.Model.ProjectEdmxItem>>(json);
            var f = new TopLevelMenu.Form1(list);
            f.Show();
        }
    }
}
