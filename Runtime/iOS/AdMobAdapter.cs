using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Chartboost.Constants;
using Chartboost.Mediation.AdMob.Common;
using Chartboost.Mediation.Utilities;
using UnityEngine;

namespace Chartboost.Mediation.AdMob.IOS
{
    internal sealed class AdMobAdapter : IAdMobAdapter
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            AdMob.AdMobAdapter.Instance = new AdMobAdapter();
        }

        /// <inheritdoc/>
        public string AdapterNativeVersion => _CBMAdMobAdapterAdapterVersion();
        
        /// <inheritdoc/>
        public string PartnerSDKVersion => _CBMAdMobAdapterPartnerSDKVersion();
        
        /// <inheritdoc/>
        public string PartnerIdentifier => _CBMAdMobAdapterPartnerId();
        
        /// <inheritdoc/>
        public string PartnerDisplayName => _CBMAdMobAdapterPartnerDisplayName();

        /// <inheritdoc/>
        public IReadOnlyCollection<string> TestDeviceIds
        {
            get
            {
                var testDeviceIds = _CBMAdMobAdapterGetTestDeviceIds();
                return string.IsNullOrEmpty(testDeviceIds) ? Array.Empty<string>() : testDeviceIds.ToList();
            }
            set
            {
                if (value == null || value.Count == 0)
                {
                    _CBMAdMobAdapterSetTestDeviceIds(Array.Empty<string>(), 0);
                    return;
                }
                _CBMAdMobAdapterSetTestDeviceIds(value.ToArray(), value.Count);
            }
        }

        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMAdMobAdapterAdapterVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMAdMobAdapterPartnerSDKVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMAdMobAdapterPartnerId();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMAdMobAdapterPartnerDisplayName();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMAdMobAdapterGetTestDeviceIds();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMAdMobAdapterSetTestDeviceIds(string[] testDeviceIds, int testDeviceIdsSize);
    }
}
