using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class Banner : MonoBehaviour
{
    private BannerView bannerView;
    
    public void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });

        this.RequestBanner();
    }

    private void RequestBanner()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-5832316352362931/1384368270";
        #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        if(SceneManager.GetActiveScene().name == "SampleScene"){ // hogehogeシーンでのみやりたい処理
           bannerView.Destroy();
        }
         if (bannerView != null)
        {
            bannerView.Destroy();
            Debug.Log("ad:バナー広告作成前に既にあるBannerViewを破棄する");
        }
        else if (bannerView == null)
        {
            Debug.Log("ad:バナー広告作成前にBannerViewは存在しない");
        }

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);

       
    }
}
