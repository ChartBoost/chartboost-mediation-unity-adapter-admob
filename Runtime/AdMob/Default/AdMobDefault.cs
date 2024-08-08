using System;
using System.Collections.Generic;
using Chartboost.Mediation.AdMob.Common;

namespace Chartboost.Mediation.AdMob.Default
{
    internal class AdMobDefault : IAdMobAdapter
    {
        /// <inheritdoc/>
        public string AdapterNativeVersion => AdMobAdapter.AdapterUnityVersion;

        /// <inheritdoc/>
        public string PartnerSDKVersion => AdMobAdapter.AdapterUnityVersion;
        
        /// <inheritdoc/>
        public string PartnerIdentifier => "admob";
        
        /// <inheritdoc/>
        public string PartnerDisplayName => "AdMob";
        
        /// <inheritdoc/>
        public IReadOnlyCollection<string> TestDeviceIds {
            get => _testDeviceIds;
            set
            {
                if (value == null || value.Count == 0)
                    _testDeviceIds = Array.Empty<string>();
                else
                    _testDeviceIds = value;
            }
        }

        private IReadOnlyCollection<string> _testDeviceIds = Array.Empty<string>();
    }
}
