using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioloop : MonoBehaviour
{
    [SerializeField] AudioClip Ac1;
    [SerializeField] AudioClip Ac2;
    private AudioSource As1;
    // Start is called before the first frame update
    void Start()
    {
        As1=this.GetComponent<AudioSource>();
        As1.PlayOneShot(Ac1);

    }

    // Update is called once per frame
    void Update()
    {
    if(!As1.isPlaying){
        As1.clip = Ac2;
        As1.loop=true;
        As1.Play();
    }
        
    }
}
