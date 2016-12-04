using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

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
    private int maxdicenumber = 5; // максимальное количество типов кубиков
    private bool twodices = false; //определяем сколько кубиков бросать
    public Text TxtRoll; //текстовые поля, потом будут нужны при выборе языка
    public Text TxtPrevious;
    public Text TxtNext;
    public Text TxtAddDice;
    public Text TxtResult;
    public Text TxtNumbers;
    
    //Лист результатов броска
    private List<string> numberofthem = new List<string>(); //создаем лист который будет хранить значения бросков

    void Start()
    {
       BarWidth = Screen.width / 8;
    }
     
    void Update()
    {
        //Ограничители для кнопок переключения       
        if (dicenumber >= maxdicenumber)
        { dicenumber = maxdicenumber; }
        if (dicenumber <= mindicenumber)
        { dicenumber = mindicenumber; }
        //список кубиков
        if (dicenumber == 1)
        { minnumber = 1; maxnumber = 5; dicename = "4 sides dice"; }
        if (dicenumber == 2)
        { minnumber = 1; maxnumber = 7; dicename = "6 sides dice"; }
        if (dicenumber == 3)
        { minnumber = 1; maxnumber = 11; dicename = "10 sides dice"; }
        if (dicenumber == 4)
        { minnumber = 1; maxnumber = 13; dicename = "12 sides dice"; }
        if (dicenumber == 5)
        { minnumber = 1; maxnumber = 21; dicename = "20 sides dice"; }
               
        TxtRoll.text = dicename + " Roll"; //отображаем на кнопке текуший кубик
        if (twodices == false) { TxtResult.text = "" + finalnumber; }
        else if (twodices)
        { TxtResult.text = "" + finalnumber + "+" + finalnumber2 + "=" + totalnumber; }
    }

    void OnGUI()
    {        
            for (int i = 1; i < numberofthem.Count && i < 10; i++)
            {                
            if (numberofthem.Count > 10)
            {
                int n = numberofthem.Count - i; // ВОТ ЭТО СТРОКУ НАДО ПОПРАВИТЬ
                GUI.Box(new Rect(160, 10 + i * 20, BarWidth, 20), numberofthem[n]);
            } else { GUI.Box(new Rect(160, 10 + i * 20, BarWidth, 20), numberofthem[i]);};
            }
        /* ТОПОРНЫЙ МЕТОД, НО РАБОТАЕТ
        int n = 0;
        if (numberofthem.Count <= 10)
        {
            n = 11;
        }
        else if (numberofthem.Count > 10)
        {
            n = numberofthem.Count;
        }        
        GUI.Box(new Rect(40, 10, BarWidth, 20), numberofthem[n - 10]);
        GUI.Box(new Rect(40, 30, BarWidth, 20), numberofthem[n - 9]);
        GUI.Box(new Rect(40, 50, BarWidth, 20), numberofthem[n - 8]);
        GUI.Box(new Rect(40, 70, BarWidth, 20), numberofthem[n - 7]);
        GUI.Box(new Rect(40, 90, BarWidth, 20), numberofthem[n - 6]);
        GUI.Box(new Rect(40, 110, BarWidth, 20), numberofthem[n - 5]);
        GUI.Box(new Rect(40, 130, BarWidth, 20), numberofthem[n - 4]);
        GUI.Box(new Rect(40, 150, BarWidth, 20), numberofthem[n - 3]);
        GUI.Box(new Rect(40, 170, BarWidth, 20), numberofthem[n - 2]);
        GUI.Box(new Rect(40, 190, BarWidth, 20), numberofthem[n - 1]);
    */
    }
    //Функции вызвываемые по клику мышки
    public void ClickRoll()
    {
        finalnumber = Random.Range(minnumber, maxnumber);
        if (twodices)
        { finalnumber2 = Random.Range(minnumber, maxnumber); }
        else { finalnumber2 = 0;}
        totalnumber = finalnumber + finalnumber2;
      
        numberofthem.Add(TxtResult.text.ToString()); //при клике добавляем полученый результат в лист бросков
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
        SceneManager.LoadScene("MainMenu");
    }  
  }