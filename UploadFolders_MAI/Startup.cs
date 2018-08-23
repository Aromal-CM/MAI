using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UploadFolders_MAI.Startup))]
namespace UploadFolders_MAI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
