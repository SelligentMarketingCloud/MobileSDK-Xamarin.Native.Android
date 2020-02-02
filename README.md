# MobileSDK-Xamarin.Native.Android

## 1. Installation

There are two ways you can use the Selligent Xamarin Android binding library:

1.	Direct reference to the dll :

	1.	Download the dll into your solution folder
	1.	Right click on the "References" folder in your solution and select "Add References..."
	1.	In the windows that appears select ".Net Assemblies" tab at the top of the window
	1.	Click "Browse..." at the bottom right of the pane
	1.	Find and select the *SelligentMobile_ANDROID_Xamarin.dll* and click "open"

1.	Reference the binding library project :

	1.	Download the binding library into your solution folder
	1.	Right click on the solution in your IDE and select "Add" -> "Existing Project..."
	1.	Find and select the folder containing the binding library and click "open"
	1.	Click "Browse..." at the bottom right of the pane
	1.	Right click on the "References" folder in your solution and select "Add References..."
	1.	In the windows that appears select "Projects" tab at the top of the window
	1.	Select the checkbox next to the binding library project you just added



After following one of these set of steps the *SelligentMobile_ANDROID_Xamarin.dll* will be added to your solution and you can start using it in your code by using "Com.Selligent.Sdk" 

## 2. Dependencies

1.	You will need to add dependencies necessary for your app to build by adding the following nuggets to your solutiton **(Note that at the time of this writing Xamarin.AndroidX packages are only available as pre-release packages)** :
	
	*	Xamarin.Android.Arch.Core.Common.1.1.1.3
	*	Xamarin.Android.Arch.Core.Runtime.1.1.1.3
	*	Xamarin.Android.Arch.Lifecycle.Common.1.1.1.3
	*	Xamarin.Android.Arch.Lifecycle.LiveData.1.1.1.3
	*	Xamarin.Android.Arch.Lifecycle.LiveData.Core.1.1.1.3
	*	Xamarin.Android.Arch.Lifecycle.Runtime.1.1.1.3
	*	Xamarin.Android.Arch.Lifecycle.ViewModel.1.1.1.3
	*	Xamarin.Android.Support.Animated.Vector.Drawable.28.0.0.3
	*	Xamarin.Android.Support.Annotations.28.0.0.3
	*	Xamarin.Android.Support.AsyncLayoutInflater.28.0.0.3
	*	Xamarin.Android.Support.Collections.28.0.0.3
	*	Xamarin.Android.Support.Compat.28.0.0.3
	*	Xamarin.Android.Support.CoordinaterLayout.28.0.0.3
	*	Xamarin.Android.Support.Core.UI.28.0.0.3
	*	Xamarin.Android.Support.Core.Utils.28.0.0.3
	*	Xamarin.Android.Support.CursorAdapter.28.0.0.3
	*	Xamarin.Android.Support.CustomTabs.28.0.0.3
	*	Xamarin.Android.Support.CustomView.28.0.0.3
	*	Xamarin.Android.Support.DocumentFile.28.0.0.3
	*	Xamarin.Android.Support.DrawerLayout.28.0.0.3
	*	Xamarin.Android.Support.Fragment.28.0.0.3
	*	Xamarin.Android.Support.Interpolator.28.0.0.3
	*	Xamarin.Android.Support.Loader.28.0.0.3
	*	Xamarin.Android.Support.LocalBroadcastManager.28.0.0.3
	*	Xamarin.Android.Support.Media.Compat.28.0.0.3
	*	Xamarin.Android.Support.Print.28.0.0.3
	*	Xamarin.Android.Support.SlidingPaneLayout.28.0.0.3
	*	Xamarin.Android.Support.SwipeRefreshLayout.28.0.0.3
	*	Xamarin.Android.Support.Vector.Drawable.28.0.0.3
	*	Xamarin.Android.Support.VersionedParcelable.28.0.0.3
	*	Xamarin.Android.Support.ViewPager.28.0.0.3
	*	Xamarin.Android.Support.v4.28.0.0.3
	*	Xamarin.Android.Support.v7.AppCompat.28.0.0.3
	*	Xamarin.Android.Support.v7.CardView.28.0.0.3
	*	Xamarin.AndroidX.Activity.1.0.0-rc1
	*	Xamarin.AndroidX.Annotation.1.1.0-rc1
	*	Xamarin.AndroidX.AppCompat.1.1.0-rc1
	*	Xamarin.AndroidX.AppCompat.Resources.1.1.0-rc1
	*	Xamarin.AndroidX.Arch.Core.Common.2.1.0-rc1
	*	Xamarin.AndroidX.Arch.Core.Runtime.2.1.0-rc1
	*	Xamarin.AndroidX.AsyncLayoutInflater.1.0.0-rc1
	*	Xamarin.AndroidX.Browser.1.0.0-rc1
	*	Xamarin.AndroidX.CardView.1.0.0-rc1
	*	Xamarin.AndroidX.Collection.1.1.0-rc1
	*	Xamarin.AndroidX.CoordinatorLayout.1.1.0-rc1
	*	Xamarin.AndroidX.Core.1.1.0-rc1
	*	Xamarin.AndroidX.CursorAdapter.1.0.0-rc1
	*	Xamarin.AndroidX.CustomView.1.0.0-rc1
	*	Xamarin.AndroidX.DocumentFile.1.0.1-rc1
	*	Xamarin.AndroidX.DrawerLayout.1.0.0-rc1
	*	Xamarin.AndroidX.Fragment.1.1.0-rc1
	*	Xamarin.AndroidX.Interpolator.1.0.0-rc1
	*	Xamarin.AndroidX.Legacy.Preference.V14.1.0.0-rc1
	*	Xamarin.AndroidX.Legacy.Support.Core.UI.1.0.0-rc1
	*	Xamarin.AndroidX.Legacy.Support.Core.Utils.1.0.0-rc1
	*	Xamarin.AndroidX.Legacy.Support.V4.1.0.0-rc1
	*	Xamarin.AndroidX.Lifecycle.Common.2.1.0-rc1
	*	Xamarin.AndroidX.Lifecycle.Extensions.2.1.0-rc1
	*	Xamarin.AndroidX.Lifecycle.LiveData.2.1.0-rc1
	*	Xamarin.AndroidX.Lifecycle.LiveData.Core.2.1.0-rc1
	*	Xamarin.AndroidX.Lifecycle.Process.2.1.0-rc1
	*	Xamarin.AndroidX.Lifecycle.Runtime.2.1.0-rc1
	*	Xamarin.AndroidX.Lifecycle.Service.2.1.0-rc1
	*	Xamarin.AndroidX.Lifecycle.ViewModel.2.1.0-rc1
	*	Xamarin.AndroidX.Loader.1.1.0-rc1
	*	Xamarin.AndroidX.LocalBroadcastManager.1.0.0-rc1
	*	Xamarin.AndroidX.Media.1.1.0-rc1
	*	Xamarin.AndroidX.Migration.1.0.0-rc1
	*	Xamarin.AndroidX.MultiDex.2.0.1-rc1
	*	Xamarin.AndroidX.Preference.1.1.0-rc2
	*	Xamarin.AndroidX.Print.1.0.0-rc1
	*	Xamarin.AndroidX.RecyclerView.1.1.0-rc1
	*	Xamarin.AndroidX.SavedState.1.0.0-rc1
	*	Xamarin.AndroidX.SlidingPaneLayout.1.0.0-rc1
	*	Xamarin.AndroidX.SwipeRefreshLayout.1.0.0-rc1
	*	Xamarin.AndroidX.VectorDrawable.1.1.0-rc1
	*	Xamarin.AndroidX.VectorDrawable.Animated.1.1.0-rc1
	*	Xamarin.AndroidX.VersionedParcelable.1.1.0-rc1
	*	Xamarin.AndroidX.ViewPager.1.0.0-rc1
	*	Xamarin.Build.Download.0.4.11
	*	Xamarin.Essentials.1.3.1
	*	Xamarin.Firebase.Common.71.1610.0
	*	Xamarin.Firebase.Iid.71.1710.0
	*	Xamarin.Firebase.Iid.Interop.71.1601.0
	*	Xamarin.Firebase.Measurement.Connector.71.1701.0
	*	Xamarin.Firebase.Messaging.71.1740.0
	*	Xamarin.Google.AutoValue.Annotations.1.6.5
	*	Xamarin.GooglePlayServices.Base.71.1610.0
	*	Xamarin.GooglePlayServices.Basement.71.1620.0
	*	Xamarin.GooglePlayServices.Stats.71.1601.0
	*	Xamarin.GooglePlayServices.Tasks.71.1601.0

## 3. Documentation

You can refer to the native documentation for information on what extra dependencies you will need for the SDK to work and how to use it. The documentation is availble at the following link : [Android - Using the SDK](https://github.com/SelligentMarketingCloud/MobileSDK-Android/blob/master/Documentation/Android%20-%20Using%20the%20SDK.pdf)

You can also take a look at the sample app provided under the SMXAMDROIDTemplate folder
