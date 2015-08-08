/*
Code made by Nelson Chicas in Kadevjo Studio
Jun 2015
nelson.chicas@kadevjo.com
This is for sharing or education purposes. Use it on your projects by you own knowledge and risks.
Always perform testing before implementing on production layer.

Carlos Campos Aug. 2015
@codercampos
*/
using System;
using Xamarin.Forms;

namespace FBLoginExample.Renderers
{
    public class FacebookEventArgs : EventArgs
    {
        public string UserId { get; set; }
        public string AccessToken { get; set; }
        public DateTime TokenExpiration { get; set; }
    }

    public class FacebookButton : Button
    {
        public Action<object, FacebookEventArgs> OnLogin;
        public void Login (object sender, FacebookEventArgs args)
        {
            if (OnLogin != null)
                OnLogin(sender, args);
        }
    }
}
