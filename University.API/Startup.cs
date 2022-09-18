using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using University.BL.Data;


namespace University.API
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            //Configura el DB context para ser usado como unica instancia por request
            app.CreatePerOwinContext(UniversityContext.Create);
        }
    }

}
