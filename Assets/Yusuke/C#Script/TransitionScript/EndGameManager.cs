using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{
    int score=0;
    public GManager Gm;
    bool onetime;
    Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        Gm=GameObject.Find("GManager").GetComponent<GManager>(); 
        onetime=true;
    }
    void Update(){
        if(Gm.currentHp==0&&onetime){
            SceneManager.LoadScene("Gameover");
            Gm.end=false;
            onetime=false;
        }
        if(Gm.end&&onetime){
            SceneManager.LoadScene("Story_GameClear");
            score = Gm.syamozi;
            /*scoretext=GameObject.Find("Score").GetComponent<Text>();
            scoretext.text="Score: "+score.ToString()+" “_";*/
            onetime=false;
        }
    
    }
}
