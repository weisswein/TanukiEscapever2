using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartSystem : MonoBehaviour
{
    public AudioSource As_start;
    public AudioClip Ac_start;
    public GameObject Destroyobject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Getbutton(){
        Destroyobject.SetActive(false);
        As_start.PlayOneShot(Ac_start);
        Invoke("GetStart",5);
    }
    private void GetStart(){
        SceneManager.LoadScene("StoryScene");
    }
}
