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
         if(Gm.syamozi*Gm.currentHp*10 > highscore3){//highscore3���傫��
            if(Gm.syamozi*Gm.currentHp*10 > highscore2){//highscore2���傫��
             if(Gm.syamozi*Gm.currentHp*10 > highscore){//highscore���傫��
            highscore = Gm.syamozi*Gm.currentHp*10;
            //"SCORE"���L�[�Ƃ��āA�n�C�X�R�A��ۑ�
            PlayerPrefs.SetInt("SCORE", highscore);
            PlayerPrefs.Save();//�f�B�X�N�ւ̏�������
                                                        }else{
            highscore2 = Gm.syamozi*Gm.currentHp*10;
            //"SCORE"���L�[�Ƃ��āA�n�C�X�R�A��ۑ�
            PlayerPrefs.SetInt("SCORE", highscore2);
            PlayerPrefs.Save();//�f�B�X�N�ւ̏�������
                                                        }
                                                        }else{
            highscore3 = Gm.syamozi*Gm.currentHp*10;
            //"SCORE"���L�[�Ƃ��āA�n�C�X�R�A��ۑ�
            PlayerPrefs.SetInt("SCORE", highscore3);
            PlayerPrefs.Save();//�f�B�X�N�ւ̏�������
                                                        }
        }
        txtranking1.text=("1�ʁF"+highscore);
        txtranking2.text=("2�ʁF"+highscore2);
        txtranking3.text=("3�ʁF"+highscore3);
       
    }

   
}
