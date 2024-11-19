using System.Collections.Generic;
using Chartboost.Mediation.Adapters;
using Chartboost.Mediation.AdMob.Common;
using Chartboost.Mediation.AdMob.Default;

namespace Chartboost.Mediation.AdMob
{
    /// <inheritdoc cref="IAdMobAdapter"/>
    public static class AdMobAdapter 
    {
        internal static IAdMobAdapter Instance = new AdMobDefault();
        
        /// <summary>
        /// The partner adapter Unity version.
        /// </summary>
        public const string AdapterUnityVersion = "5.0.2";

        /// <inheritdoc cref="IPartnerAdapterConfiguration.AdapterNativeVersion"/>
        public static string AdapterNativeVersion => Instance.AdapterNativeVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerSDKVersion"/>
        public static string PartnerSDKVersion => Instance.PartnerSDKVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerIdentifier"/>
        public static string PartnerIdentifier => Instance.PartnerIdentifier;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerDisplayName"/>
        public static string PartnerDisplayName => Instance.PartnerDisplayName;

        /// <inheritdoc cref="IAdMobAdapter.TestDeviceIds"/>
        public static IReadOnlyCollection<string> TestDeviceIds
        {
            get => Instance.TestDeviceIds;
            set => Instance.TestDeviceIds = value;
        }
    }
}
