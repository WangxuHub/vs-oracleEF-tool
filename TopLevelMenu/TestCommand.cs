//------------------------------------------------------------------------------
// <copyright file="TestCommand.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.Design;
using System.Globalization;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System.Collections;
using Microsoft.VisualStudio;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;

namespace TopLevelMenu
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class TestCommand
    {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 0x0100;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("93d42044-a860-4d51-9477-d86c98fa18bf");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly Package package;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCommand"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        private TestCommand(Package package)
        {
            if (package == null)
            {
                throw new ArgumentNullException("package");
            }

            this.package = package;

            OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (commandService != null)
            {
                var menuCommandID = new CommandID(CommandSet, CommandId);
                var menuItem = new MenuCommand(this.MenuItemCallback, menuCommandID);
                commandService.AddCommand(menuItem);
            }
        }

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static TestCommand Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private IServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static void Initialize(Package package)
        {
            Instance = new TestCommand(package);
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void MenuItemCallback(object sender, EventArgs e)
        {
            //string message = string.Format(CultureInfo.CurrentCulture, "Inside {0}.MenuItemCallback()", this.GetType().FullName);
            //string title = "TestCommand";

            //// Show a message box to prove we were here
            //VsShellUtilities.ShowMessageBox(
            //    this.ServiceProvider,
            //    message,
            //    title,
            //    OLEMSGICON.OLEMSGICON_INFO,
            //    OLEMSGBUTTON.OLEMSGBUTTON_OK,
            //    OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);

            var projectList = SolutionProjects.Projects();

            var res = new List<Model.ProjectEdmxItem>();
            projectList.ToList().ForEach(item=> {
                var projectEdmxItem = new Model.ProjectEdmxItem();

                var connstrList = new List<string>();
                
                var dir = Path.GetDirectoryName(item.FileName);

                var edmxFile = Directory.GetFiles(dir, "*.edmx", SearchOption.TopDirectoryOnly);
                if(edmxFile.Count()<=0)
                {
                    return;
                }

                projectEdmxItem.EdmxPath = edmxFile.Select(a=>new Model.EdmxItem {
                    ShortFileName = Path.GetFileName(a),
                    FullFileName = a
                }).ToList();

                var configFile = Path.Combine(dir,"App.config");

                if(File.Exists(configFile))
                {
                    var configObj = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap {
                        ExeConfigFilename = configFile
                    },ConfigurationUserLevel.None);

                    var connList = configObj.ConnectionStrings?.ConnectionStrings;

                    if(connList!=null && connList.Count>0)
                    {
                        foreach(ConnectionStringSettings connItem in connList)
                        {
                            if("System.Data.EntityClient".ToLower() != connItem.ProviderName?.ToLower())
                            {
                                continue;
                            }
                            if(connItem.ConnectionString.ToLower().IndexOf("Oracle.ManagedDataAccess.Client".ToLower())<0)
                            {
                                continue;
                            }

                            var connectionItem = new Model.ConnectionStringItem();

                            var regex = new Regex("provider connection string=\"(?<connStr>.*)\"",RegexOptions.IgnoreCase);
                          
                            connectionItem.Name = connItem.Name;
                            connectionItem.ConnectionString = regex.Match(connItem.ConnectionString).Groups["connStr"].Value;
                            
                            var conn = new Oracle.ManagedDataAccess.Client.OracleConnection(connectionItem.ConnectionString);

                            var regexUserID = new Regex("USER\\s+ID\\s*?=\\s*?(?<userID>\\S*)[;]?", RegexOptions.IgnoreCase);
                            connectionItem.DatabaseUserName = regexUserID.Match(connectionItem.ConnectionString).Groups["userID"].Value;

                            var regexDataSource = new Regex("Data\\s+Source\\s*?=\\s*(?<datasource>[^;]*)\\s*[;]?", RegexOptions.IgnoreCase);
                            connectionItem.Datasource = regexDataSource.Match(connectionItem.ConnectionString).Groups["datasource"].Value;

                            projectEdmxItem.ConnectionString.Add(connectionItem);
                        }
                    }
                }

                res.Add(projectEdmxItem);
            });


            var form = new Form1(res);
            form.Show();
        }
        

    }
}
