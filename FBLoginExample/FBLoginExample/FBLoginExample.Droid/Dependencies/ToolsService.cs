using FBLoginExample.Dependencies.Droid;
using Xamarin.Forms;
using Xamarin.Facebook.Login;

[assembly:Dependency(typeof(ToolsService))]
namespace FBLoginExample.Dependencies.Droid
{
    public class ToolsService : ITools
    {
        public void LogoutFromFacebook()
        {
            LoginManager.Instance.LogOut();
        }
    }
}