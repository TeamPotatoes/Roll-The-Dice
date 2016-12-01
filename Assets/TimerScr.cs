﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScr : MonoBehaviour {

    private int Seconds=0;
    private int Minutes=0;
    private int Hours=0;
    private float MaxSeconds = 61;
    private int MaxMinuts = 10;
    private int MaxHours = 10;
    public bool TimerCount;
    public Text HoursTxt;
    public Text MinutesTxt;
    public Text SecondsTxt;
    public Text Button;

    // Use this for initialization  
    void Start ()
    {
        Seconds = 0;
        TimerCount = false;

       
    }

   public void ClickTimer()
    {

       if(TimerCount == false) { TimerCount = true; StartCoroutine(Second()); Button.text = "Pause"; }
       else if(TimerCount == true) { TimerCount = false;StopCoroutine(Second()); Button.text = "Start"; }
    }

  public  IEnumerator Second()
    {
        while (TimerCount == true)
        {

            Debug.Log(Seconds);

            Seconds = Seconds + 1;
            yield return new WaitForSeconds(1);
        }
      
    }


  public  void Reset()
    {
        Seconds = 0;
        Minutes = 0;
        Hours = 0;
        
    }
    void Update()
    {
        if(Seconds == MaxSeconds)
        {
           
            Seconds = 0;
            Minutes = Minutes + 1; 
        }
        HoursTxt.text = "" + Hours;
        MinutesTxt.text = "" + Minutes;
        SecondsTxt.text = "" + Seconds;
    }

    // Update is called once per frame

    public void ClickBack()
    {
        Application.LoadLevel("MainMenu");
    }
}