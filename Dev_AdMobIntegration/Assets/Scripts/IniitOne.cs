
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class IniitOne : MonoBehaviour
{
    public static bool result=false;
    private void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
            result = true;
        });
    }


}
