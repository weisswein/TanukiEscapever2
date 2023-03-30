using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scoredisplay : MonoBehaviour
{
    private GManager Gmg;
    public Text tx;
    // Start is called before the first frame update
    void Start()
    {
        Gmg = GameObject.Find("GManager").GetComponent<GManager>();
        tx.text="Score: "+Gmg.syamozi*Gmg.currentHp*10+" “_!";
        Debug.Log("syamozi"+Gmg.syamozi+"HP"+Gmg.currentHp);
    }

    
}
