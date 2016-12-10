using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScr : MonoBehaviour {

    private int Seconds=0;
    private int Minutes=0;
    private int Hours=0;
    private float MaxSeconds = 61;
    private int MaxMinutes = 61;
    private int MaxHours = 25;
    public bool TimerCount;
    private GameObject TimerClock;
    private GameObject SandClock;
    public Text HoursTxt;
    public Text MinutesTxt;
    public Text SecondsTxt;
    public Text Button;
    

    // Use this for initialization  
    void Start ()
    {
        Seconds = 0;
        TimerCount = false;
        TimerClock = GameObject.Find("TimerClock");
        SandClock = GameObject.Find("SandClock");

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
            Seconds = Seconds + 1;
            yield return new WaitForSeconds(1);
        }
      
    }


  public void Reset()
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
        if (Minutes == MaxMinutes)
        {
            Seconds = 0;
            Minutes = 0;
            Hours = Hours + 1;
        }
        if (Hours == MaxHours)
        {
            Seconds = 0;
            Minutes = 0;
            Hours = 0;
        }
        HoursTxt.text = "" + Hours;
        MinutesTxt.text = "" + Minutes;
        SecondsTxt.text = "" + Seconds;
    }
           
    public void SwitchToSand() { TimerClock.SetActive(false); SandClock.SetActive(true); }
    public void SwitchToTimer() { TimerClock.SetActive(true); SandClock.SetActive(false); }



    // Update is called once per frame

    public void ClickBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
