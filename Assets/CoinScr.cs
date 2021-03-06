﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class CoinScr : MonoBehaviour
{
    private int finalnumber = 0; // результат броска 
    private int headscount = 0;
    private int tailscount = 0;
    private int totalflips = 0;
    public Text TxtResult;
    public Sprite co_head; //спрайт ноги
    public Sprite co_tail; //спрайт руки

    void Start()
    {

    }

            //Функции вызвываемые по клику мышки
    public void ClickFlip()
    {
        finalnumber = Random.Range(1, 3);
        if (finalnumber == 1)
        {
            TxtResult.text = "Head";
            headscount += 1;
            GetComponent<SpriteRenderer>().sprite = co_head;
        }
        if (finalnumber == 2)
        {
            TxtResult.text = "Tail";
            tailscount += 1;
            GetComponent<SpriteRenderer>().sprite = co_tail;
        }
        totalflips += 1;
        float Headstotal = ((float)headscount / (float)totalflips) * 100; //фишка в том что int обращается в 0 при делении из-за того что нет определения занков после запятой
        float Tailstotal = ((float)tailscount / (float)totalflips) * 100;
        Text TxtPercentage = GameObject.Find("TxtPercentage").GetComponent<Text>();        
        TxtPercentage.text = "Heads" + ": " + headscount + "(" + Headstotal.ToString("F1") + "%) " + "Tails" + ": " + tailscount + "(" + Tailstotal.ToString("F1") + "%)" + "\n" + totalflips;
    }   
    void Update()
    {
    /*  bool Delta1 = GameObject.Find("LangManager").GetComponent<LangManager>().ShakeIsOn;
    if (Delta1 == true)
    {
        Debug.Log("DSDFDSFSFD" + Time.deltaTime);
        ClickFlip();
    }*/
        if (Input.GetKeyDown(KeyCode.Escape))
            {ClickBack();}
    }

   public void ClickBack()
   {
        SceneManager.LoadScene("MainMenu");
   }
}
