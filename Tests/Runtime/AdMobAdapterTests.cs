using System;
using System.Collections.Generic;
using Chartboost.Logging;
using Chartboost.Mediation.AdMob;
using Chartboost.Tests.Runtime;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class AdMobAdapterTests
    {
        [SetUp]
        public void SetUp()
            => LogController.LoggingLevel = LogLevel.Debug;

        [Test]
        public void AdapterNativeVersion()
            => TestUtilities.TestStringGetter(() => AdMobAdapter.AdapterNativeVersion);

        [Test]
        public void PartnerSDKVersion()
            => TestUtilities.TestStringGetter(() => AdMobAdapter.PartnerSDKVersion);

        [Test]
        public void PartnerIdentifier()
            => TestUtilities.TestStringGetter(() => AdMobAdapter.PartnerIdentifier);

        [Test]
        public void PartnerDisplayName()
            => TestUtilities.TestStringGetter(() => AdMobAdapter.PartnerDisplayName);

        [Test]
        public void TestDeviceIds()
        {
            Assert.AreEqual(Array.Empty<string>(), AdMobAdapter.TestDeviceIds);
            
            var testDeviceIds = new List<string>
            {
                "33BE2250B43518CCDA7DE426D04EE231",
                "33BE2250B43518CCDA7DE426D04EE232",
                "33BE2250B43518CCDA7DE426D04EE233"
            };

            AdMobAdapter.TestDeviceIds = testDeviceIds;
            Assert.AreEqual(testDeviceIds ,AdMobAdapter.TestDeviceIds);
            LogController.Log($"Test Device Ids: {Json.JsonTools.SerializeObject(AdMobAdapter.TestDeviceIds)}", LogLevel.Debug);
            AdMobAdapter.TestDeviceIds = null;
            Assert.AreEqual(Array.Empty<string>(), AdMobAdapter.TestDeviceIds);
        }
    }
}
