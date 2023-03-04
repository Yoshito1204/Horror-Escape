using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelChanger : MonoBehaviour
{
   public GameObject rightArrow;
   public GameObject leftArrow;
   public GameObject backArrow;
   public AudioClip walk;
   public GameObject itembox;
   public GameObject Map;
   public GameObject Hint;
   public GameObject Camera;
   private PerlinNoiseShaker perlinNoise;
   public GameObject Bar;
   public bool dooropen;
   public bool dailclear;
   public int GoLightNum;
   public GameObject Yuurei2;
   public int GoBasin;
   public GameObject BasinFace;
   GameObject obj;
   GameObject P17;
   public int GoAtticNum;
   public GameObject Yuurei3;
   public GameObject GirlFace;
   public GameObject Phone;
   public GameObject CallPhone;
   public AudioClip se1;
   public AudioClip se2;
   public AudioClip entrance;
   public AudioClip slowwalk;
   public AudioClip water;
   public AudioClip iki;
   public AudioClip kimo;
   private AudioSource audioSource;
   public static PanelChanger instance;
  public enum Panel
   {
      ItemBoxPanel,
      Panel0,
      Panel1,
      Panel2,
      Panel3,
      Panel4,
      Panel5,
      Panel6,
      Panel7,
      Panel8,
      Panel9,
      Panel10,
      Panel11,
      Panel12,
      Panel13,
      Panel14,
      Panel15,
      Panel16,
      Panel17,
      Panel18,
      Panel19,
      Panel20,
      Panel21,
   }
  public Panel currentPanel = Panel.Panel0;
  public Panel now;

  private void Awake() {
        if(instance == null){
            instance = this;
        }
    }

    void Start(){
      HideArrow();
      rightArrow.SetActive(true);
      leftArrow.SetActive(true);
      audioSource = GetComponent<AudioSource>();
      perlinNoise = Camera.GetComponent<PerlinNoiseShaker>();
      perlinNoise.enabled = false;
      dooropen = false;
      dailclear = false;
      GoLightNum = 0;
      Yuurei2.SetActive(false);
      GoBasin = 0;
      P17 = GameObject.Find("Panel3.washbasin");
      GoAtticNum = 0;
      Yuurei3.SetActive(false);
      GirlFace.SetActive(false);
      Bar.SetActive(false);
      Phone.SetActive(false);
      CallPhone.SetActive(false);
      
      ShowPanel(Panel.Panel0);
    }

    void Update(){
        now = currentPanel;
       /* if(dailclear == true){
           Bar.SetActive(true);
           dailclear = false;
        }*/
    }

    public void HideArrow(){
      rightArrow.SetActive(false);
      leftArrow.SetActive(false);
      backArrow.SetActive(false);
      
    }


   public void ShowPanel(Panel nextPanel){
      currentPanel = nextPanel;

      if(nextPanel == Panel.Panel0){
        this.transform.localPosition = new Vector2(0,0);
        HideArrow();
      rightArrow.SetActive(true);
      leftArrow.SetActive(true);
      audioSource.Stop();
      audioSource.PlayOneShot(entrance,0.5f);
      audioSource.loop = true;
      }else if(nextPanel == Panel.Panel1){
        this.transform.localPosition = new Vector2(-2000,0);
        HideArrow();
      leftArrow.SetActive(true);
      audioSource.Stop();
      audioSource.PlayOneShot(entrance,0.5f);
      audioSource.loop = true;
      }else if(nextPanel == Panel.Panel2){
        this.transform.localPosition = new Vector2(2000,0);
        HideArrow();
      rightArrow.SetActive(true);
      audioSource.Stop();
      audioSource.PlayOneShot(entrance,0.5f);
      audioSource.loop = true;
      }else if(nextPanel == Panel.Panel3){
        this.transform.localPosition = new Vector2(0,2000);
        HideArrow();
      rightArrow.SetActive(true);
      leftArrow.SetActive(true);
      audioSource.Stop();
      audioSource.PlayOneShot(slowwalk,0.7f);
      audioSource.loop = true;
        if(GoLightNum == 2){
           Yuurei2.SetActive(true);

        }else{
          return;
        }

        if(ItemBox.instance.usedinjector == true){
          Phone.SetActive(true);
        }

      }else if(nextPanel == Panel.Panel4){
        this.transform.localPosition = new Vector2(-2000,2000);
        HideArrow();
      leftArrow.SetActive(true);
      audioSource.Stop();
      audioSource.PlayOneShot(water);
      audioSource.loop = true;
      }else if(nextPanel == Panel.Panel5){
        this.transform.localPosition = new Vector2(2000,2000);
        HideArrow();
      rightArrow.SetActive(true);
      audioSource.Stop();
      }else if(nextPanel == Panel.Panel6){
        this.transform.localPosition = new Vector2(0,4000);
        HideArrow();
      rightArrow.SetActive(true);
      leftArrow.SetActive(true);
      audioSource.Stop();
      }else if(nextPanel == Panel.Panel7){
        this.transform.localPosition = new Vector2(2000,4000);
        HideArrow();
        rightArrow.SetActive(true);
        audioSource.Stop();
      }else if(nextPanel == Panel.Panel8){
        this.transform.localPosition = new Vector2(-2000,4000);
        HideArrow();
      leftArrow.SetActive(true);
      audioSource.Stop();
      }else if(nextPanel == Panel.Panel9){
        this.transform.localPosition = new Vector2(-2000,6000);
        HideArrow();
      leftArrow.SetActive(true);
      audioSource.Stop();
       GoAtticNum++;
      }else if(nextPanel == Panel.Panel10){
        this.transform.localPosition = new Vector2(0,6000);
        HideArrow();
      rightArrow.SetActive(true);
      leftArrow.SetActive(true);
      audioSource.Stop();
      if(GoAtticNum == 2){
        StartCoroutine("ApproachFace");
      }
       GoAtticNum++;

      }else if(nextPanel == Panel.Panel11){
        this.transform.localPosition = new Vector2(2000,6000);
        HideArrow();
      rightArrow.SetActive(true);
      audioSource.Stop();
       GoAtticNum++;
      }else if(nextPanel == Panel.Panel12){
        this.transform.localPosition = new Vector2(2000,8000);
        HideArrow();
      rightArrow.SetActive(true);
      audioSource.Stop();
      }else if(nextPanel == Panel.Panel13){
        this.transform.localPosition = new Vector2(0,8000);
        HideArrow();
        audioSource.Stop();
        if(ItemBox.instance.usedbar == true){
           rightArrow.SetActive(true);
           leftArrow.SetActive(true);
           audioSource.PlayOneShot(iki);
           audioSource.loop = true;
        }
      
      }else if(nextPanel == Panel.Panel14){
        this.transform.localPosition = new Vector2(-2000,8000);
        HideArrow();
      leftArrow.SetActive(true);
      audioSource.Stop();
      }else if(nextPanel == Panel.Panel15){
        this.transform.localPosition = new Vector2(-4000,2000);
        HideArrow();
      backArrow.SetActive(true);
      audioSource.Stop();
      }else if(nextPanel == Panel.Panel16){
        this.transform.localPosition = new Vector2(-6000,2000);
        HideArrow();
      backArrow.SetActive(true);
      audioSource.Stop();
      }else if(nextPanel == Panel.Panel17){
        this.transform.localPosition = new Vector2(-8000,2000);
        HideArrow();
      backArrow.SetActive(true);
       audioSource.Stop();

      }else if(nextPanel == Panel.Panel18){
        this.transform.localPosition = new Vector2(-4000,4000);
        HideArrow();
      backArrow.SetActive(true);
      audioSource.Stop();
      }else if(nextPanel == Panel.Panel19){
        this.transform.localPosition = new Vector2(-4000,6000);
        HideArrow();
      backArrow.SetActive(true);
      audioSource.Stop();
      }else if(nextPanel == Panel.Panel20){
        this.transform.localPosition = new Vector2(-6000,4000);
        HideArrow();
      backArrow.SetActive(true);
      audioSource.Stop();
      }else if(nextPanel == Panel.Panel21){
        this.transform.localPosition = new Vector2(-4000,8000);
        HideArrow();
      backArrow.SetActive(true);
      audioSource.Stop();
      audioSource.PlayOneShot(kimo);
      audioSource.loop = true;
      }

    }

    public void OnItemBoxPanel(){
       itembox.transform.localPosition = Camera.transform.localPosition;
    }

    public void OnMapPanel(){
       Map.transform.localPosition = Camera.transform.localPosition;
    }

    public void OnHintPanel(){
       Hint.transform.localPosition = Camera.transform.localPosition;
    }

    public void OnEntrance(){
      ShowPanel(Panel.Panel0);
      Map.transform.localPosition = new Vector3(2000,1500,0);
    }

    public void OnWasitu(){
      ShowPanel(Panel.Panel3);
      Map.transform.localPosition = new Vector3(2000,1500,0);
    }

    public void OnKokuban(){
      ShowPanel(Panel.Panel6);
      Map.transform.localPosition = new Vector3(2000,1500,0);
    }

    public void OnKokubanFront(){
      ShowPanel(Panel.Panel20);
    }

    public void OnYaneura(){
      ShowPanel(Panel.Panel10);
      Map.transform.localPosition = new Vector3(2000,1500,0);
    }

    public void OnOperating(){
      ShowPanel(Panel.Panel13);
      Map.transform.localPosition = new Vector3(2000,1500,0);
    }

    public void OnSitai(){
      ShowPanel(Panel.Panel15);
    }

    public void OnLight(){
      ShowPanel(Panel.Panel16);
      GoLightNum++;
    }

    public void OnWashbasin(){
      ShowPanel(Panel.Panel17);
      GoBasin++;

      if(GoBasin == 1 || GoBasin == 5 || GoBasin == 8){
        obj = (GameObject)Instantiate(BasinFace);
        obj.transform.SetParent(P17.transform,false);
         audioSource.PlayOneShot(se1);
         
      }
    }

    public void OnFloor(){
      ShowPanel(Panel.Panel18);
    }

    public void OnFamily(){
      ShowPanel(Panel.Panel19);
      GoAtticNum++;
    }

    public void OnBed(){
      ShowPanel(Panel.Panel21);
    }

    IEnumerator ApproachFace(){
       Yuurei3.SetActive(true);
       rightArrow.SetActive(false);
       leftArrow.SetActive(false);

       yield return new WaitForSeconds(3);
      
      Yuurei3.SetActive(false);
      perlinNoise.enabled = true;
      //perlinNoise.Shake(100f,100f);
       GirlFace.SetActive(true);
       audioSource.PlayOneShot(se1);
       
       yield return new WaitForSeconds(1);

       perlinNoise.enabled = false;
      
       GirlFace.SetActive(false);
       rightArrow.SetActive(true);
       leftArrow.SetActive(true);
    }
    public void OnRightArrow(){
       audioSource.PlayOneShot(walk);

       if(now == Panel.Panel0){
          ShowPanel(Panel.Panel1);
       }else if(now == Panel.Panel2){
          ShowPanel(Panel.Panel0);
       }else if(now == Panel.Panel3){
          ShowPanel(Panel.Panel4);
       }else if(now == Panel.Panel5){
          ShowPanel(Panel.Panel3);
       }else if(now == Panel.Panel6){
          ShowPanel(Panel.Panel8);
       }else if(now == Panel.Panel7){
          ShowPanel(Panel.Panel6);
       }else if(now == Panel.Panel10){
          ShowPanel(Panel.Panel9);
       }else if(now == Panel.Panel11){
          ShowPanel(Panel.Panel10);
       }else if(now == Panel.Panel12){
          ShowPanel(Panel.Panel13);
       }else if(now == Panel.Panel13){
          ShowPanel(Panel.Panel14);
       }

       if(SearchButton.instance.ImageText.activeSelf == true){
        SearchButton.instance.ImageText.SetActive(false);
       }
    }
    public void OnLeftArrow(){
       audioSource.PlayOneShot(walk);

       if(now == Panel.Panel0){
          ShowPanel(Panel.Panel2);
       }else if(now == Panel.Panel1){
          ShowPanel(Panel.Panel0);
       }else if(now == Panel.Panel3){
          ShowPanel(Panel.Panel5);
       }else if(now == Panel.Panel4){
          ShowPanel(Panel.Panel3);
       }else if(now == Panel.Panel2){
          ShowPanel(Panel.Panel0);
       }else if(now == Panel.Panel6){
          ShowPanel(Panel.Panel7);
       }else if(now == Panel.Panel8){
          ShowPanel(Panel.Panel6);
       }else if(now == Panel.Panel9){
          ShowPanel(Panel.Panel10);
       }else if(now == Panel.Panel10){
          ShowPanel(Panel.Panel11);
       }else if(now == Panel.Panel13){
          ShowPanel(Panel.Panel12);
       }else if(now == Panel.Panel14){
          ShowPanel(Panel.Panel13);
       }
        
       
       if(SearchButton.instance.ImageText.activeSelf == true){
        SearchButton.instance.ImageText.SetActive(false);
       }
    }
    public void OnBackArrow(){

      HideArrow();
      audioSource.PlayOneShot(walk);

       if(now == Panel.Panel15){
        ShowPanel(Panel.Panel3);
       }else if(now == Panel.Panel16){
         ShowPanel(Panel.Panel3);
       }else if(now == Panel.Panel17){
         ShowPanel(Panel.Panel4);
       }else if(now == Panel.Panel18){
         ShowPanel(Panel.Panel6);
       }else if(now == Panel.Panel19){
         ShowPanel(Panel.Panel10);
       }else if(now == Panel.Panel20){
         ShowPanel(Panel.Panel6);
       }else if(now == Panel.Panel21){
         ShowPanel(Panel.Panel13);
       }

       if(SearchButton.instance.ImageText.activeSelf == true){
        SearchButton.instance.ImageText.SetActive(false);
       }
    }

    public void OnKey(){
        ShowPanel(Panel.Panel2);
    }
}
