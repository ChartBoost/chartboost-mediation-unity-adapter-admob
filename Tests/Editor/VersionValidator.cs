using Chartboost.Editor;
using Chartboost.Mediation.AdMob;
using NUnit.Framework;

namespace Chartboost.Tests.Editor
{
    internal class VersionValidator
    {
        private const string UnityPackageManagerPackageName = "com.chartboost.mediation.unity.adapter.admob";
        private const string NuGetPackageName = "Chartboost.CSharp.Mediation.Unity.Adapter.AdMob";
        
        [Test]
        public void ValidateVersion() 
            => VersionCheck.ValidateVersions(UnityPackageManagerPackageName, NuGetPackageName, AdMobAdapter.AdapterUnityVersion);
    }
}
