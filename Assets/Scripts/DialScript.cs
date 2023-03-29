using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialScript : MonoBehaviour
{
    public GameObject buttonDialLText; //左ダイヤルテキスト
    public GameObject buttonDialMText; //真ん中ダイヤルテキスト
    public GameObject buttonDialNText; //右ダイヤルテキスト
    public GameObject buttonDialOText; //右ダイヤルテキスト

    public GameObject Panel11Back;
    public Sprite Panel11BackNew;
    
    public GameObject kinko;

    private int NumL = 0;
    private int NumM = 0;
    private int NumN = 0;
    private int NumO = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //DialLを押した
     public void PushButtonDialL()
    {
        NumL = NumL+1; //押される毎に１足していく

        if (NumL == 10)　//表示前に判定、１０になっていたら
        {
            NumL = 0;　//０に戻す。
        }
        else { }　//１～９のあいだったら何もしない
        buttonDialLText.transform.GetChild(0).GetComponent<Text>().text = NumL.ToString();
    }

    //DialMを押した
    public void PushButtonDialM()
    {
        NumM = NumM + 1;

        if (NumM == 10)
        {
            NumM = 0;
        }
        else { }
        buttonDialMText.transform.GetChild(0).GetComponent<Text>().text = NumM.ToString();
    }

    //DialNを押した
    public void PushButtonDialN()
    {
        NumN = NumN + 1;

        if (NumN == 10)
        {
            NumN = 0;
        }
        else { }
        buttonDialNText.transform.GetChild(0).GetComponent<Text>().text = NumN.ToString();
    }

    //DialOを押した
    public void PushButtonDialO()
    {
        NumO = NumO + 1;

        if (NumO == 10)
        {
            NumO = 0;
        }
        else { }
        buttonDialOText.transform.GetChild(0).GetComponent<Text>().text = NumO.ToString();
    }

    //Enterを押した
    public void PushEnter(){
        if(NumL == 4 && NumM == 3 && NumN == 3 && NumO == 6){
            Panel11Back.GetComponent<Image>().sprite = Panel11BackNew; 
            PanelChanger.instance.Bar.SetActive(true);
            PanelChanger.instance.dailclear = true;
            kinko.SetActive(false);
            this.gameObject.SetActive(false);
        }else{
            this.gameObject.SetActive(false);
        }
    }
}
