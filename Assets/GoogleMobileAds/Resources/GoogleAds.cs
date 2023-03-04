using System;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using UnityEngine.UI;

public class GoogleAds : MonoBehaviour
{
    private RewardedAd rewardedAd;
    public GameObject HintPanel;
    public GameObject HintText;
    private Text hinttext;
    public int hintnum;
    bool isRewarded;

    // Use this for initialization
    void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });
        RequestRewardAd();
        hinttext = HintText.transform.GetChild(0).GetComponent<Text>();
    }

    private void Update()
    {
        if (isRewarded)
        {
            isRewarded = false;
            ShowRewardResult();
        }
    }


    public void UserChoseToWatchAd()
    {
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
    }


    void RequestRewardAd()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-5832316352362931/9384263323";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
        string adUnitId = "unexpected_platform";
#endif
        this.rewardedAd = new RewardedAd(adUnitId);

        // Load成功時に実行する関数の登録
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        // Load失敗時に実行する関数の登録
       // this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // 表示時に実行する関数の登録
        this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        // 表示失敗時に実行する関数の登録
        this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // 報酬受け取り時に実行する関数の登録
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // 広告を閉じる時に実行する関数の登録
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        AdRequest request = new AdRequest.Builder().Build();
        this.rewardedAd.LoadAd(request);
    }






    public void ShowRewardResult()
    {
        HintText.transform.localPosition = HintPanel.transform.localPosition;
        if(hintnum == 1){
            hinttext.text = "フェンスを破壊出来そうなものがどこかにあるはず。";
        }else if(hintnum == 2){
            hinttext.text = "上に行けそうな場所で上に行けそうな道具を使おう。";
        }else if(hintnum == 3){
            hinttext.text = "色の付いた紙が床にクシャクシャになって落ちているよ。";
        }else if(hintnum == 4){
            hinttext.text = "木の板は何かで剝がせるよ。";
        }else if(hintnum == 5){
            hinttext.text = "水が切れる場所で血液パックを使おう。";
        }else if(hintnum == 6){
            hinttext.text = "どこかで鍵を入手しよう。";
        }else if(hintnum == 7){
            hinttext.text = "注射は人間に刺すものだ。刺せる人間を探そう。";
        }else if(hintnum == 8){
            hinttext.text = "ライターで火を点けて大爆発を起こそう。";
        }
    }


    public void CreateAndLoadRewardedAd()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
            string adUnitId = "unexpected_platform";
#endif

        this.rewardedAd = new RewardedAd(adUnitId);

        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        AdRequest request = new AdRequest.Builder().Build();
        this.rewardedAd.LoadAd(request);
    }


    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdLoaded event received");
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToLoad event received with message: "
                             + args.Message);

    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdOpening event received");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToShow event received with message: "
                             + args.Message);
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdClosed event received");
        CreateAndLoadRewardedAd();
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        MonoBehaviour.print(
            "HandleRewardedAdRewarded event received for "
                        + amount.ToString() + " " + type);
        isRewarded = true;
    }
}


