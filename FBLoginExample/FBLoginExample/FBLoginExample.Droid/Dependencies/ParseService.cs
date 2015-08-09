//Enable this if you are using Facebook Login with Parse
//IMPORTANT: You must add Parse component to Android, iOS & Windows Phone projects

//using System;
//using System.Threading.Tasks;
//[assembly: Xamarin.Forms.Dependency(typeof(FBLoginExample.Dependencies.Droid.ParseService))]
//namespace FBLoginExample.Dependencies.Droid
//{
//    public class ParseService : IParse
//    {
//        public async Task<bool> LoginWithFacebook(string userId, string accessToken, DateTime tokenExpiration)
//        {
//            var user = await ParseFacebookUtils.LogInAsync(
//                userId,
//                accessToken,
//                tokenExpiration
//            );

//            return user != null;
//        }
//    }
//}