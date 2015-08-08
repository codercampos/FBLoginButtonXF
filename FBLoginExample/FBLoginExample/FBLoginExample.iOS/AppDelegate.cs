using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Facebook.CoreKit;

namespace FBLoginExample.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            //Initialize the Facebook SDK parameters
            Settings.AppID = "<YOUR FACEBOOK APP ID>";
            Settings.DisplayName = "<YOUR APP DISPLAY NAME>";

            //If you are planning to use Parse to authenticate via Facebook Login, use this to configure Parse
            //Parse.ParseClient.Initialize("<YOUR .NET KEY>", "<YOUR PROJECT ID>");


            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

        public override bool OpenUrl(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
        {
            // We need to handle URLs by passing them to their own OpenUrl in order to make the SSO authentication works.
            return ApplicationDelegate.SharedInstance.OpenUrl(application, url, sourceApplication, annotation);
        }
    }
}
