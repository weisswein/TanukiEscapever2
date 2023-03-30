 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class GManager : MonoBehaviour
 {
    [Header("スピード")] public float speed = 6.0f;
    public static GManager instance = null;
    public int currentHp=20;//現在のHPなくなったらゲームオーバー
    public int maxHp=20;
    public bool GameStart = false;
    public int syamozi = 0;//点数
    public bool hit=false;
    public bool dash=false;
    public bool disguiseR=false;
    public bool cool=false;
    public bool end=false;//終わりの判定
    public float[] setp_y;
    public float[] setp_ye;
    public float[] setp_yf;
    public float setp_x;
    public float dashTime;
    public int lane_num;
    private AudioSource audioSource = null;
    private void Awake()
    {
      

        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject); 
        }
        else
        {
            Destroy(this.gameObject);
        }
      
    }
    public void destroymethod(){
        Destroy(this.gameObject);
    }
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlaySE(AudioClip clip)
    {
        if (audioSource != null)
        {
            audioSource.PlayOneShot(clip);
        }
        else
        {
            Debug.Log("オーディオソースが設定されていません");
        }
    }
}