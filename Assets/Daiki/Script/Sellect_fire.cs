using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sellect_fire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int ran=Random.Range(0, 6);
        switch(ran){
            case 0:
                GetComponent<Fire>().enabled = true;
                GetComponent<Renderer>().material.color = new Color32(224, 186, 40, 255);
                break;
            case 1:
                GetComponent<FireM>().enabled = true;
                break;
            case 2:
                GetComponent<FireV>().enabled = true;
                break;
            case 3:
                GetComponent<FireT>().enabled = true;
                break;
            case 4:
                GetComponent<FireI>().enabled = true;
                break;
            case 5:
                GetComponent<Fire>().enabled = true;
                GetComponent<Renderer>().material.color = new Color32(224, 186, 40, 255);
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
