⛔️ DEPRECATED - No further updates will be delivered

# MobileSDK-Xamarin.Native.Android

## 1. Installation

There are two ways you can use the Selligent Xamarin Android binding library:

1.	Direct reference to the dll :

	1.	Download the *SelligentMobile_ANDROID_Xamarin.dll*  dll into your solution folder
	1.	Right click on the "References" folder in your solution and select "Add References..."
	1.	In the windows that appears select ".Net Assemblies" tab at the top of the window
	1.	Click "Browse..." at the bottom right of the pane
	1.	Find and select the *SelligentMobile_ANDROID_Xamarin.dll* and click "open"

1.	Reference the binding library project :

	1.	Pull the repository into your solution folder
	1.	Right click on the solution in your IDE and select "Add" -> "Existing Project..."
	1.	Open the folder named *SelligentMobileDroid* containing the binding library and double click the "SelligentMobileDroid.csproj" file.
	1.	Right click on the "References" folder in your solution and select "Add References..."
	1.	In the windows that appears select "Projects" tab at the top of the window
	1.	Select the checkbox next to the binding library project you just added and click "Ok"

After following one of these set of steps the *SelligentMobile_ANDROID_Xamarin.dll* will be added to your solution and you can start using it in your code by using "Com.Selligent.Sdk" 

## 2. Dependencies

You will need to add dependencies necessary for your app to build by adding the nuggets listed below to your solutiton.

###  Google packages:

		Xamarin.Google.Android.Material
		GoogleGson
		
### Xamarin.AndroidX packages :

**(Note that at the time of this writing Xamarin.AndroidX packages are only available as pre-release packages so you will have to check the box that is labeled "show pre-release packages" in your nuget manager)** 
		
		Xamarin.AndroidX.Browser
		Xamarin.AndroidX.LifeCycle.Extensions
		Xamarin.AndroidX.Legacy.Support.V4
		Xamarin.AndroidX.Legacy.Preference.V14
		Xamarin.AndroidX.CardView

###  Xamarin.Android packages:

		Xamarin.Android.Support.v7.AppCompat
		Xamarin.Android.Support.v4
		Xamarin.Android.Support.Animated.Vector.Drawable
		Xamarin.Android.Support.v7.CardView

###  Xamarin essential packages:
		Xamarin.Essentials

###  Firebase packages:

		Xamarin.Firebase.Messaging


## 3. Documentation

You can refer to the native documentation for information on how to use the SDK. The documentation is availble at the following link : [Android - Using the SDK](https://github.com/SelligentMarketingCloud/MobileSDK-Android/blob/master/Documentation/Android%20-%20Using%20the%20SDK.pdf)
(Remember to set the google-services.json's Build Action to "GoogleServicesJson")

You can also take a look at the sample app provided under the SMXAMDROIDTemplate folder
