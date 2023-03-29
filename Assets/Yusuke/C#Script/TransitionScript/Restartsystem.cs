using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restartsystem : MonoBehaviour
{
    public GManager Gm_last;
    // Start is called before the first frame update
    void Start()
    {
        Gm_last=GameObject.Find("GManager").GetComponent<GManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartButton()
    {
        Gm_last.destroymethod();
        SceneManager.LoadScene("StartScreen");
    }
}
