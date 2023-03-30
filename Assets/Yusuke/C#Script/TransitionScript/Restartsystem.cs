using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restartsystem : MonoBehaviour
{
    public GManager Gm_last;
    public AudioSource As_over;
    public AudioClip Ac_over;

    // Start is called before the first frame update
    void Start()
    {
        Gm_last=GameObject.Find("GManager").GetComponent<GManager>();
    }

   
    public void RestartButton()
    {
        Gm_last.destroymethod();
        As_over.PlayOneShot(Ac_over);
        Invoke("Gameoverloadtitle",2);
    }

    private void Gameoverloadtitle(){
        SceneManager.LoadScene("StartScreen");
    }
}
