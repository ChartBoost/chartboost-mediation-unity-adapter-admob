# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.0.6 *(2024-10-10)*
This version of the AdMob Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-admob:chartboost-mediation-adapter-admob:5.23.2+`
  * iOS: `ChartboostMediationAdapterAdMob: ~> 5.11.9.0`

### Version 5.0.0 *(2024-08-08)*

First version of the Chartboost Mediation Unity SDK - AdMob Adapter.

#Added 
- Support for the following `AdMob` dependencies. Notice adapter dependencies are optimistic and any patches and hot-fixes will be automatically picked up.:
    * Android: `com.chartboost:chartboost-mediation-adapter-admob:5.23.2.+`
    * iOS: `ChartboostMediationAdapterAdMob ~> 5.11.5.0`
    
- `AdMobAdapter.cs` with Configuration Properties for `AdMob`.
- The following properties have been added in `AdMobAdapter.cs`
    * `string AdapterUnityVersion`
    * `string AdapterNativeVersion`
    * `string PartnerSDKVersion`
    * `string PartnerIdentifier`
    * `string PartnerDisplayName`
    * `IReadOnlyCollection<string> TestDeviceIds`