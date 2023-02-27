using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeAds : MonoBehaviour
{
    BannerAds bannerAds;
    InterstitialAds interstitialAd;
   // Start is called before the first frame update
    void Start()
    {
        bannerAds = new BannerAds();
        interstitialAd = new InterstitialAds();
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
            // This callback is called once the MobileAds SDK is initialized.
            bannerAds.LoadBannerAds();
            interstitialAd.LoadInterstitialAd();
        });
    }

    

    


    
}
