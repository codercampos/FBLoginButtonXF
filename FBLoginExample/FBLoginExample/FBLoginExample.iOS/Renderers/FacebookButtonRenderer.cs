using CoreGraphics;
using Facebook.LoginKit;
using FBLoginExample.Renderers;
using FBLoginExample.Renderers.iOS;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(FacebookButton), typeof(FacebookButtonRenderer))]
namespace FBLoginExample.Renderers.iOS
{
    public class FacebookButtonRenderer : ButtonRenderer
    {
        private LoginButton loginButton;

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || this.Element == null)
            {
                return;
            }

            loginButton = new LoginButton()
            {
                LoginBehavior = LoginBehavior.Native,
            };

            loginButton.Completed += (sender, args) => {
                FacebookButton facebookButton = (FacebookButton)e.NewElement;
                FacebookEventArgs fbArgs = new FacebookEventArgs();

                if (args.Result.Token != null)
                {
                    fbArgs.UserId = args.Result.Token.UserID;
                    fbArgs.AccessToken = args.Result.Token.TokenString;
                    fbArgs.TokenExpiration = args.Result.Token.ExpirationDate.ToDateTime();
                }

                facebookButton.Login(facebookButton, fbArgs);
            };

            SetNativeControl(loginButton);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            // Facebook login button has its own look and feel, so the layout properties
            // are the only important properties to check
            if (e.PropertyName == Button.XProperty.PropertyName)
            {
                FacebookButton button = (FacebookButton)sender;
                CGRect frame = loginButton.Frame;
                frame.X = (nfloat)button.X;
                loginButton.Frame = frame;
            }
            else if (e.PropertyName == Button.YProperty.PropertyName)
            {
                FacebookButton button = (FacebookButton)sender;
                CGRect frame = loginButton.Frame;
                frame.Y = (nfloat)button.Y;
                loginButton.Frame = frame;
            }
            else if (e.PropertyName == Button.WidthProperty.PropertyName)
            {
                FacebookButton button = (FacebookButton)sender;
                CGRect frame = loginButton.Frame;
                frame.Width = (nfloat)button.Width;
                loginButton.Frame = frame;
            }
            else if (e.PropertyName == Button.HeightProperty.PropertyName)
            {
                FacebookButton button = (FacebookButton)sender;
                CGRect frame = loginButton.Frame;
                frame.Height = (nfloat)button.Height;
                loginButton.Frame = frame;
            }
        }

    }
}