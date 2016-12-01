﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class DicesScr : MonoBehaviour {
    private float BarWidth; //ширина фона у текста
    private int finalnumber = 0; // результат броска
    private int finalnumber2 = 0; // результат броска второго кубика если есть
    private int totalnumber = 0; //результат сложения броска двух кубиков
    private int minnumber = 1; // минимальное значение на кубике
    private int maxnumber = 7; // максимальнеое значение на кубике
    private string dicename = "6 sides dice"; // название кубика
    private int dicenumber = 1; // порядковый номер кубика в списке
    private int mindicenumber = 1; //переменная чтобы порядковый номер не был меньше ее
    private int maxdicenumber = 4; // максимальное количество типов кубиков
    private bool twodices = false; //определяем сколько кубиков бросать
    public Text TxtRoll;
    public Text TxtPrevious;
    public Text TxtNext;
    public Text TxtAddDice;
    public Text TxtResult;
    public Text TxtNumbers;


    //Масив результатов
    /*
    private int ColumnNum;
    private string Res1;
    private string Res2;
    private string Res3;
    private string Res4;
    private string Res5;
    private string Res6;
    private string Res7;
    private string Res8;
    private string Res9;
    private string Res10;
    */
    private string display = "";
    private List<string> numberofthem = new List<string>(); //создаем лист который будет хранить значения бросков

    void Start()
    {
        //Res1 = null;
        //ColumnNum = 0;
        BarWidth = Screen.width / 8;

    }
     
    void Update()
    {
        /*
        switch (ColumnNum)
        {
            case 1: Res1 = TxtResult.text.ToString(); break;
            case 2: Res2 = TxtResult.text.ToString(); break;
            case 3: Res3 = TxtResult.text.ToString(); break;
            case 4: Res4 = TxtResult.text.ToString(); break;
            case 5: Res5 = TxtResult.text.ToString(); break;
            case 6: Res6 = TxtResult.text.ToString(); break;
            case 7: Res7 = TxtResult.text.ToString(); break;
            case 8: Res8 = TxtResult.text.ToString(); break;
            case 9: Res9 = TxtResult.text.ToString(); break;
            case 10: Res10 = TxtResult.text.ToString(); break;
            default: Res1 = TxtResult.text.ToString(); break;
        }
        */
        //Ограничители для кнопок переключения       
        if (dicenumber >= maxdicenumber)
        { dicenumber = maxdicenumber; }
        if (dicenumber <= mindicenumber)
        { dicenumber = mindicenumber; }
        //список кубиков
        if (dicenumber == 1)
        {
            minnumber = 1; maxnumber = 7; dicename = "6 sides dice";
        }
        if (dicenumber == 2)
        {
            minnumber = 1; maxnumber = 11; dicename = "10 sides dice";
        }
        if (dicenumber == 3)
        {
            minnumber = 1; maxnumber = 13; dicename = "12 sides dice";
        }
        if (dicenumber == 4)
        {
            minnumber = 1; maxnumber = 21; dicename = "20 sides dice";
        }
               
        TxtRoll.text = dicename + " Roll"; //отображаем на кнопке текуший кубик
        if (twodices == false) { TxtResult.text = "" + finalnumber; }
        else if (twodices)
        { TxtResult.text = "" + finalnumber + "+" + finalnumber2 + "=" + totalnumber; }
    }

    void OnGUI()
    {
       /* for (int i=0; i < numberofthem.Count; i++)
        {
            GUI.Box(new Rect(Screen.width / 1.95f, (Screen.height / (2.65f - numberofthem.Count)), 150, 30), numberofthem[i]);
        }
        
        GUI.Box(new Rect(10, 10, BarWidth, 20), Res1);
        GUI.Box(new Rect(10, 30, BarWidth, 20), Res2);
        GUI.Box(new Rect(10, 50, BarWidth, 20), Res3);
        GUI.Box(new Rect(10, 70, BarWidth, 20), Res4);
        GUI.Box(new Rect(10, 90, BarWidth, 20), Res5);
        GUI.Box(new Rect(10, 110, BarWidth, 20), Res6);
        GUI.Box(new Rect(10, 130, BarWidth, 20), Res7);
        GUI.Box(new Rect(10, 150, BarWidth, 20), Res8);
        GUI.Box(new Rect(10, 170, BarWidth, 20), Res9);
        GUI.Box(new Rect(10, 190, BarWidth, 20), Res10);
    */
    }
    //Функции вызвываемые по клику мышки
    public void ClickRoll()
    {
        finalnumber = Random.Range(minnumber, maxnumber);
        if (twodices)
        { finalnumber2 = Random.Range(minnumber, maxnumber); }
        else { finalnumber2 = 0;}
        //ColumnNum = ColumnNum + 1;
        //if (ColumnNum >= 11) { ColumnNum = 1; }   //39 строк....ну это жесть

        numberofthem.Add(TxtResult.text.ToString()); //при клике добавляем переменную
        Debug.Log(numberofthem.Count); //переменная отображает сколько бросков сохранено
       
            /*foreach (string data in numberofthem)
            {
                Debug.Log(data);
                display = display.ToString() + data.ToString() + "\n";
                display = numberofthem[data];
            }
            TxtNumbers.text = display;
            */
        }
       
    public void ClickAddDice ()
    {
        if (twodices == false)
        {
            twodices = true;
            TxtAddDice.text = "Delete dice";
        }
        else if (twodices)
        {
            twodices = false;
            TxtAddDice.text = "Add dice";
        }
    }
    public void ClickPreviousDice()
    {
        dicenumber -= 1;
    }
    public void ClickNextDice()
    {
        dicenumber += 1;
    }
    public void ClickBack()
    {
        Application.LoadLevel("MainMenu");
    }
  

  }