using System.Runtime.CompilerServices;
using Chartboost.Mediation.AdMob;
using UnityEngine.Scripting;

[assembly: AlwaysLinkAssembly]
[assembly: InternalsVisibleTo(AssemblyInfo.AdMobAssemblyInfoAndroid)]
[assembly: InternalsVisibleTo(AssemblyInfo.AdMobAssemblyInfoIOS)]

namespace Chartboost.Mediation.AdMob
{
    internal class AssemblyInfo
    {
        public const string AdMobAssemblyInfoAndroid = "Chartboost.Mediation.AdMob.Android";
        public const string AdMobAssemblyInfoIOS = "Chartboost.Mediation.AdMob.IOS";
    }
}
