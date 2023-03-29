using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //public int countdownMinutes = 1;
    private float timer= 0.0f;
    private DateTime startTime;
    private Text timeText;
    public double second = 0;


    private void Start()
    {
        timeText = GetComponent<Text>();
        timer = 0;
    }

    void Update()
    {
        if((GManager.instance.GameStart)&&(!GManager.instance.end)){
            if(((int)second!=(int)(DateTime.Now - startTime).TotalSeconds)&&(GManager.instance.speed<13))GManager.instance.speed+=(timer/300);
            second = (DateTime.Now - startTime).TotalSeconds;
            //var span = new TimeSpan(0, 0, 70-(int)timer);
            timeText.text = ""+(int)(70-second);//span.ToString(@"mm\:ss");
            if(second>70) GManager.instance.end=true;
        }
        else{
            if(timer > 2.0f){
                GManager.instance.GameStart=true;
                timer=0f;
                startTime = System.DateTime.Now;
                Debug.Log("START!");
            }
            else{
                timer += Time.deltaTime;
            }
        }
        
    }
}