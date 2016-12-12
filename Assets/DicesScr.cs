using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class DicesScr : MonoBehaviour {    
    private int finalnumber = 0; // результат броска
    private int finalnumber2 = 0; // результат броска второго кубика если есть
    private int totalnumber = 0; //результат сложения броска двух кубиков
    private int minnumber = 1; // минимальное значение на кубике
    private int maxnumber = 7; // максимальнеое значение на кубике
    private int dicenumber = 2; // порядковый номер кубика в списке
    private int mindicenumber = 1; //переменная чтобы порядковый номер не был меньше ее
    private int maxdicenumber = 7; // максимальное количество типов кубиков
    private bool twodices = false; //определяем сколько кубиков бросать
    private bool showlist = false; //выводит полный список бросков
    private string dicename; // название кубика
    public Text TxtRoll; //текстовые поля, потом будут нужны при выборе языка
    public Text TxtPrevious;
    public Text TxtNext;
    public Text TxtAddDice;
    public Text TxtResult;
    public Text TxtNumbers;
    private List<string> numberofthem = new List<string>(); //создаем лист который будет хранить значения бросков
       
    void CheckName() //исполняем все что внутри только если нажата кнопка определенная
    {
        //список кубиков
        if (dicenumber == 1)
        { minnumber = 1; maxnumber = 5; dicename = "d4 dice"; }
        if (dicenumber == 2)
        { minnumber = 1; maxnumber = 7; dicename = "d6 dice"; }
        if (dicenumber == 3)
        { minnumber = 1; maxnumber = 9; dicename = "d8 dice"; }
        if (dicenumber == 4)
        { minnumber = 1; maxnumber = 11; dicename = "d10 dice"; }
        if (dicenumber == 5)
        { minnumber = 1; maxnumber = 13; dicename = "d12 dice"; }
        if (dicenumber == 6)
        { minnumber = 1; maxnumber = 21; dicename = "d20 dice"; }
        if (dicenumber == 7)
        { minnumber = 1; maxnumber = 31; dicename = "d30 dice"; }
        TxtRoll.text = dicename + " Roll"; //отображаем на кнопке текуший кубик
    }

    void OnGUI()
    {        
            //выводим список последних 10 бросков на экран
            for (int i = 1; i < numberofthem.Count && i < 10; i++)
            {   
            if (numberofthem.Count > 10)
            {         
                GUI.Box(new Rect(900, 500 + i * 20, 260, 20), numberofthem.Count - i  + " " + numberofthem[numberofthem.Count - i]);
            } else { GUI.Box(new Rect(900, 700 - i * 20, 260, 20),  i  +  " " + numberofthem[i]);};
            }     
            if (showlist)
            {
                for (int i = 1; i < numberofthem.Count; i++)
                {
                    GUI.Box(new Rect(900, 700 - i * 20, 260, 20), i + " " + numberofthem[i]);
                }
            }   else { return; }
    }

    public void ClickRoll()
{
    finalnumber = Random.Range(minnumber, maxnumber);
    if (twodices)
    { finalnumber2 = Random.Range(minnumber, maxnumber); }
    else { finalnumber2 = 0; }
    totalnumber = finalnumber + finalnumber2;
    numberofthem.Add(TxtResult.text.ToString()); //при клике добавляем полученый результат в лист бросков
    if (twodices == false) { TxtResult.text = "" + finalnumber; }
    else if (twodices)
    {
        TxtResult.text = "" + finalnumber + "+" + finalnumber2 + "=" + totalnumber;
    }
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
        //Ограничители для кнопок переключения   
        if (dicenumber <= mindicenumber)
        { dicenumber = mindicenumber; }
        CheckName();
    }
    public void ClickNextDice()
    {
        dicenumber += 1;
        if (dicenumber >= maxdicenumber)
        { dicenumber = maxdicenumber; }
        CheckName();
    }
    public void ClickShowList()
    {
        if (!showlist)
        {
            showlist = true;
        } else {showlist = false;}
        
    }
    public void ClickBack()
    {
        SceneManager.LoadScene("MainMenu");
    }  
  }