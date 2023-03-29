using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skipsystem : MonoBehaviour
{
    
    public void Skipmethod()
    {
        SceneManager.LoadScene("ScrollMapScene 1");
    }
}
