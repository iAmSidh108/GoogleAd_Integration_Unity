using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class BannerAds : MonoBehaviour
{

    private string _adUnitId;
    private BannerView _bannerView;
    private AdRequest adRequest;

    
    public void LoadBannerAds()
    {
        #if UNITY_ANDROID
 _adUnitId = "ca-app-pub-3940256099942544/6300978111";
#elif UNITY_IPHONE
 _adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
  _adUnitId = "unused";
#endif
    _bannerView = new BannerView(_adUnitId, AdSize.Banner, AdPosition.Top);
        adRequest = new AdRequest.Builder()
        .AddKeyword("unity-admob-sample")
        .Build();
        Debug.Log("Loading banner ad.");
        _bannerView.LoadAd(adRequest);
        Debug.Log("Successfully Showed ad");
    }
}
