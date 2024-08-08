using System.Collections.Generic;
using Chartboost.Constants;
using Chartboost.Mediation.AdMob.Common;
using UnityEngine;

namespace Chartboost.Mediation.AdMob.Android
{
    internal sealed class AdMobAdapter : IAdMobAdapter
    {
        private const string AdMobAdapterConfiguration = "com.chartboost.mediation.admobadapter.AdMobAdapterConfiguration";
        
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            AdMob.AdMobAdapter.Instance = new AdMobAdapter();
        }
        
        /// <inheritdoc/>
        public string AdapterNativeVersion
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(AdMobAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetAdapterVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerSDKVersion 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(AdMobAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerSdkVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerIdentifier
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(AdMobAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerId);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerDisplayName 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(AdMobAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerDisplayName);
            }
        }
        
        /// <inheritdoc/>
        public IReadOnlyCollection<string> TestDeviceIds {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(AdMobAdapterConfiguration);
                using var nativeTestDeviceIds = adapterConfiguration.Call<AndroidJavaObject>(SharedAndroidConstants.FunctionGetTestDeviceIds);
                return nativeTestDeviceIds.NativeListToList();
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(AdMobAdapterConfiguration);
                using var nativeList = value.EnumerableToNativeList();
                adapterConfiguration.Call(SharedAndroidConstants.FunctionSetTestDeviceIds, nativeList);
            }
        }
    }
}
