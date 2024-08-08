#import "CBMDelegates.h"
#import "ChartboostUnityUtilities.h"
#import <ChartboostMediationAdapterAdMob/ChartboostMediationAdapterAdMob-Swift.h>

extern "C" {

    const char * _CBMAdMobAdapterAdapterVersion(){
        return toCStringOrNull([AdMobAdapterConfiguration adapterVersion]);
    }

    const char * _CBMAdMobAdapterPartnerSDKVersion(){
        return toCStringOrNull([AdMobAdapterConfiguration partnerSDKVersion]);
    }

    const char * _CBMAdMobAdapterPartnerId(){
        return toCStringOrNull([AdMobAdapterConfiguration partnerID]);
    }

    const char * _CBMAdMobAdapterPartnerDisplayName(){
        return toCStringOrNull([AdMobAdapterConfiguration partnerDisplayName]);
    }

    const char * _CBMAdMobAdapterGetTestDeviceIds(){
        return toJSON([AdMobAdapterConfiguration testDeviceIdentifiers]);
    }

    void _CBMAdMobAdapterSetTestDeviceIds(const char** testDeviceIds, int testDeviceIdsSize){
        if (testDeviceIdsSize > 0)
            [AdMobAdapterConfiguration setTestDeviceIdentifiers:toNSMutableArray(testDeviceIds, testDeviceIdsSize)];
        else
            [AdMobAdapterConfiguration setTestDeviceIdentifiers:nil];
    }
}
