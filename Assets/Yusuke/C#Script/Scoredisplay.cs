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
        tx.text="Score: "+Gmg.syamozi+" “_!";
    }

    
}
