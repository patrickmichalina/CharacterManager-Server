using System;
using System.Configuration;
using System.Data.Entity.Migrations;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using TrackerEnabledDbContext.Common.Configuration;

namespace CharacterManager
{
    /// <summary>
    /// ASP.NET entry point
    /// </summary>
    public class Global : HttpApplication
    {
        /// <summary>
        /// This is where our application begins in earnest
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_Start(object sender, EventArgs e)
        {
            WebApiConfig.Register(GlobalConfiguration.Configuration);

            // migrate to latest database schema and seed sample data (if both are set based on app settings)
            MigrateDatabase();

            // Enable CORS
            GlobalConfiguration.Configuration.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            // Track entities for audit logs
            GlobalTrackingConfig.Enabled = true;

            // JSON
            GlobalConfiguration.Configuration.Formatters.Clear();
            GlobalConfiguration.Configuration.Formatters.Add(new System.Net.Http.Formatting.JsonMediaTypeFormatter());
        }

        /// <summary>
        /// Migrates db to latest migration file. Checks the key "MigrateDatabaseToLatestVersion" for truthy
        /// </summary>
        private static void MigrateDatabase()
        {
            if (ConfigurationManager.AppSettings["MigrateDatabaseToLatestVersion"] != "true") return;
            var migrator = new DbMigrator(new Migrations.Configuration());
            migrator.Update();
        }
    }
}