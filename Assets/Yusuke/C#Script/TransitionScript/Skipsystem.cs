using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skipsystem : MonoBehaviour
{
    public AudioSource Aus;
    public AudioClip Acskip;

    public void Skipmethod()
    {
        Aus.PlayOneShot(Acskip);
        //3�b��Ƀ��\�b�h�����s����
        Invoke("SkipStory", 2);
    }
    private void SkipStory(){
        SceneManager.LoadScene("ScrollMapScene 1");
    }
}
