using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{
    int score=0;
    public GManager Gm;
    bool onetime=true;
    Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        Gm=GameObject.Find("GManager").GetComponent<GManager>(); 
       
    }
    void Update(){
        if(Gm.currentHp==0&&onetime){
            SceneManager.LoadScene("Gameover");
            Gm.end=false;
            onetime=false;
        }
        if(Gm.end){
            SceneManager.LoadScene("GameClear");
            score = Gm.syamozi;
            scoretext=GameObject.Find("Score").GetComponent<Text>();
            scoretext.text="Score: "+score.ToString()+" “_";
            Gm.end=false;
        }
    
    }
}
