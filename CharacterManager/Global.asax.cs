using System;
using System.Web;
using System.Web.Http;

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
        }
    }
}