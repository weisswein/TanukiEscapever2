using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreRanking : MonoBehaviour
{   
    private GManager Gm;
    public int highscore;
    public int highscore2;
    public int highscore3;
    public Text txtranking1;
    public Text txtranking2;
    public Text txtranking3;

    // Start is called before the first frame update
    void Start()
    {   
        
        
        highscore = PlayerPrefs.GetInt("SCORE", 0); 
        Gm=GameObject.Find("GManager").GetComponent<GManager>();
         if(Gm.syamozi*Gm.currentHp*10 > highscore3){//highscore3より大きい
            if(Gm.syamozi*Gm.currentHp*10 > highscore2){//highscore2より大きい
             if(Gm.syamozi*Gm.currentHp*10 > highscore){//highscoreより大きい
            highscore = Gm.syamozi*Gm.currentHp*10;
            //"SCORE"をキーとして、ハイスコアを保存
            PlayerPrefs.SetInt("SCORE", highscore);
            PlayerPrefs.Save();//ディスクへの書き込み
                                                        }else{
            highscore2 = Gm.syamozi*Gm.currentHp*10;
            //"SCORE"をキーとして、ハイスコアを保存
            PlayerPrefs.SetInt("SCORE", highscore2);
            PlayerPrefs.Save();//ディスクへの書き込み
                                                        }
                                                        }else{
            highscore3 = Gm.syamozi*Gm.currentHp*10;
            //"SCORE"をキーとして、ハイスコアを保存
            PlayerPrefs.SetInt("SCORE", highscore3);
            PlayerPrefs.Save();//ディスクへの書き込み
                                                        }
        }
        txtranking1.text=("1位："+highscore);
        txtranking2.text=("2位："+highscore2);
        txtranking3.text=("3位："+highscore3);
       
    }

   
}
