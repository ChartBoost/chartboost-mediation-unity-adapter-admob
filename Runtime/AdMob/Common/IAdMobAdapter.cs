using System.Collections.Generic;
using Chartboost.Mediation.Adapters;

namespace Chartboost.Mediation.AdMob.Common
{
    /// <summary>
    /// The Chartboost Mediation AdMob adapter.
    /// </summary>
    internal interface IAdMobAdapter : IPartnerAdapterConfiguration
    {
        /// <summary>
        /// List containing device IDs to be set for enabling AdMob test ads.
        /// It can be populated at any time and will take effect for the next ad request.
        /// Remember to empty this list or stop setting it before releasing your app.
        /// </summary>
        IReadOnlyCollection<string> TestDeviceIds { get; set; }
    }
}
