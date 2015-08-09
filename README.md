# FBLoginButtonXF
A quick example how to use (a bit easy) Facebook Button Login with Xamarin Forms

This creates a Custom Renderer Button that will use Facebook SDK (iOS & Android) LoginButton class to implement the native look and feel of Facebook Login Button.

To access the Login operation you need to set up a Facebook App on the developer site. Please visit https://developers.facebook.com/products/login for more information.

In this example I will asume:
- You already have set up your Facebook App (so you must need your App ID where you will replace into the whole project it requires).
- You have already a namespace for your app (by default I left com.codercampos.fbexample in both Android & iOS project, so you must change this in the project or add it (this namespace) into your facebook application dashboard. In order to use Facebook login, your namespace must match your Facebook's namespace in the app) (I know, this is a bit annoying to do)
- You already have your debug.keystore hash key (this is for Android, in order to test your app. This will be added into your Facebook App dashboard).

##How did you do this?
After hours and hours testing different ways and guides (you can look into google if you want) We have found a simple way to implement a CustomRenderer which use de Facebook Login Buttton.

###Step 1: CustomRenderer and FacebookEventArgs
Into the PCL project you will find Renderers>FacebookButton. This will be the CustomRenderer you wil use. Also We have create a FacebookEventArgs class to pass from each platform all the values you will need to perform a Login (UserID, AccessToken and TokenExpirationDate). Create a EventHandler into the FacebookButton class which will recieve the FacebookEventArgs elements.

###Step 2: Create the CR into each platforms
Create each CustomRenderer implementation into the iOS & Android projects. Depending on the platform, the Facebook SDK acts in different ways. Check out the code to see the Facebook LoginButton class behievior.

###Step 3: Configure Facebook SDK into each platform
You will need to initialize Facebook SDK into the MainActivity (Android) and AppDelegate (iOS) classes in order to use Facebook Login. Also, you will see in the code, need to override OnAcivityResult (Android) and OpenURL (iOS) method in order to open/catch Facebook's Intent/ViewController. If the user does not have a Facebook App installed in the device, this will open a WebView in order to do the Login. In each platform, includes a Callback to get results values of this operation.

###Step 4: Implement FacebookButton view into your Xamarin.Forms project
Create a ContentPage where you can create a FacebookButton view to test the Login operation. In order to this, add an event handler to OnLogin method in the ContentPage to handle the FacebookEventArgs param comming from each platform (in the code you can see an example)

###Step 5: Test
Test your app

##Important notes & known issues
- Windows Phone implementation is missing. I will work on this later
- Don't forget to replace your App ID and change your namespace (also on your Facebook App)
- These does not have a Exception handler if network is missing (problems appears on Android in the OnActivityResult method, I haven't tested this on iOS yet)
- On Android, the Text inside the button appears at the top of the button (no matter if you GravityVertical). This is maybe because We are not initializing ths button in the MainActivity (neither applying an style in this Acivity). I will test this later (but if you solve this before, please feel free to share it).

##Credits
This originally started by Nelson Chicas (@NelsonChicas) and finished by myself (@codercampos) with the help of the great Xamarin, Android & iOS community.

- iOS implementation & Xamarin Forms CustomRenderer code: Nelson Chicas
- Android implementation code: Carlos Campos
- Repo, Comments & Guide: Carlos Campos

Thank You so much for your time, hope this will be helpfull to you.
