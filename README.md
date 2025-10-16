# Chartboost Mediation Unity SDK - AdMob Adapter

Provides a list of externally configurable properties pertaining to the partner SDK that can be retrieved and set by publishers. 

Dependencies for the adapter are now embedded in the package, and can be found at `com.chartboost.mediation.unity.adapter.admob/Editor/AdMobAdapterDependencies.xml`.

# Installation

## Using the public [npm registry](https://www.npmjs.com/search?q=com.chartboost.mediation.unity.adapter.admob)

In order to add the Chartboost Mediation Unity SDK - AdMob Adapter to your project using the npm package, add the following to your Unity Project's ***manifest.json*** file. The scoped registry section is required in order to fetch packages from the NpmJS registry.

```json
"dependencies": {
    "com.chartboost.mediation.unity.adapter.admob": "5.2.0",
    ...
},
"scopedRegistries": [
{
    "name": "NpmJS",
    "url": "https://registry.npmjs.org",
    "scopes": [
    "com.chartboost"
    ]
}
]
```
## Using the public [NuGet package](https://www.nuget.org/packages/Chartboost.CSharp.Mediation.Unity.Adapter.AdMob)

To add the Chartboost Mediation Unity SDK - AdMob Adapter to your project using the NuGet package, you will first need to add the [NugetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) package into your Unity Project.

This can be done by adding the following to your Unity Project's ***manifest.json***

```json
  "dependencies": {
    "com.github-glitchenzo.nugetforunity": "https://github.com/GlitchEnzo/NuGetForUnity.git?path=/src/NuGetForUnity",
    ...
  },
```

Once <code>NugetForUnity</code> is installed, search for `Chartboost.CSharp.Mediation.Unity.Adapter.AdMob` in the search bar of Nuget Explorer window(Nuget -> Manage Nuget Packages).
You should be able to see the `Chartboost.CSharp.Mediation.Unity.Adapter.AdMob` package. Choose the appropriate version and install.

# Chartboost - Google Utilities for AndroidManifest.xml & Info.plist
In order for the Google User Messaging Platform to initialize the `application ID` must be added to the `AndroidManifest.xml` & `Info.plist`. Chartboost provides this functionality through its dependency package for Google adapters. 

Simply click on the Editor menu: `Chartboost/Google/Configure` and set your `application ID` as needed. This configuration is shared for all Google packages possibly integrated, e.g: Google User Messaging Platform, AdMob, Google Bidding, etc.

# Usage

The following code block exemplifies usage of the `AdMobAdapter.cs` configuration class.

## IPartnerAdapterConfiguration Properties

```csharp

// AdapterUnityVersion - The partner adapter Unity version, e.g: 5.0.0
Debug.Log($"Adapter Unity Version: {AdMobAdapter.AdapterUnityVersion}");

// AdapterNativeVersion - The partner adapter version, e.g: 5.22.3.0.0
Debug.Log($"Adapter Native Version: {AdMobAdapter.AdapterNativeVersion}");

// PartnerSDKVersion - The partner SDK version, e.g: 22.3.0
Debug.Log($"Partner SDK Version: {AdMobAdapter.PartnerSDKVersion}");

// PartnerIdentifier - The partner ID for internal uses, e.g: admob
Debug.Log($"Partner Identifier: {AdMobAdapter.PartnerIdentifier}");

// PartnerDisplayName - The partner name for external uses, e.g: AdMob
Debug.Log($"Partner Display Name: {AdMobAdapter.PartnerDisplayName}");
```

## Test Device Ids

Test device Ids can be set and fetch using `AdMobAdapter.TestDeviceIds`.

```csharp

// Example test device ids
var testDeviceIds = new List<string>
{
    "33BE2250B43518CCDA7DE426D04EE231",
    "33BE2250B43518CCDA7DE426D04EE232",
    "33BE2250B43518CCDA7DE426D04EE233"
};

// Setting test device ids
AdMobAdapter.TestDeviceIds = testDeviceIds;

// Clearing test device ids
AdMobAdapter.TestDeviceIds = null;
```