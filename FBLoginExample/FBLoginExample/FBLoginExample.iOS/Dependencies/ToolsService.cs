using System;
using FBLoginExample.Dependencies.iOS;
using Xamarin.Forms;
using Facebook.LoginKit;

[assembly:Dependency(typeof(ToolsService))]
namespace FBLoginExample.Dependencies.iOS
{
    public class ToolsService : ITools
    {
        public void LogoutFromFacebook()
        {
            var fbSession = new LoginManager();
            fbSession.LogOut();
        }
    }
}