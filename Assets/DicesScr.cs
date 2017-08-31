using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class DicesScr : MonoBehaviour {    
    private int finalnumber = 0; // результат броска
    private int finalnumber2 = 0; // результат броска второго кубика если есть
    private int finalnumber3 = 0;
    private int finalnumber4 = 0;
    private int finalnumber5 = 0;
    private int totalnumber = 0; //результат сложения броска двух кубиков
    private int minnumber = 1; // минимальное значение на кубике
    private int maxnumber = 7; // максимальнеое значение на кубике
    private int numberofdices = 1;
    private bool twodices = false; //определяем сколько кубиков бросать
    private bool showlist = false; //выводит полный список бросков
    private bool shakeOn = false;
    //текстовые поля, потом будут нужны при выборе языка
    public Text TxtAddDice;
    public Text TxtResult;
    public Text TxtTotalResult;
    public Text TxtChooseDice;
    public GameObject AllRollsList;
    private List<string> numberofthem = new List<string>(); //создаем лист который будет хранить значения бросков

    void Start()
    {      
       /* TxtResult.text = LangManager.instance.GetWord("Result");
        TxtChooseDice.text = LangManager.instance.GetWord("ChooseDice");*/
    }

 
    public void ClickRoll() //бросок
    {         
        /*
        if (twodices)
        {finalnumber2 = Random.Range(minnumber, maxnumber);}
        else { finalnumber2 = 0; }         
        if (twodices == false) { TxtResult.text = "" + finalnumber; }
        else if (twodices)
        {TxtResult.text = "" + finalnumber + "+" + finalnumber2 + "=" + totalnumber;}
        */
        //ГОВЕНЫЙ КУСОК - НАДО ОПТИМИЗОРОВАТЬ ПОЛЮБЭ
        switch (numberofdices) //определяем количество бросаемых кубиков
        {
            case 1:
                finalnumber = Random.Range(minnumber, maxnumber);
                finalnumber2 = 0;
                finalnumber3 = 0;
                finalnumber4 = 0;
                finalnumber5 = 0;
                break;
            case 2:
                finalnumber = Random.Range(minnumber, maxnumber);
                finalnumber2 = Random.Range(minnumber, maxnumber);
                finalnumber3 = 0;
                finalnumber4 = 0;
                finalnumber5 = 0;
                break;
            case 3:
                finalnumber = Random.Range(minnumber, maxnumber);
                finalnumber2 = Random.Range(minnumber, maxnumber);
                finalnumber3 = Random.Range(minnumber, maxnumber);
                finalnumber4 = 0;
                finalnumber5 = 0;
                break;
            case 4:
                finalnumber = Random.Range(minnumber, maxnumber);
                finalnumber2 = Random.Range(minnumber, maxnumber);
                finalnumber3 = Random.Range(minnumber, maxnumber);
                finalnumber4 = Random.Range(minnumber, maxnumber);
                finalnumber5 = 0;
                break;
            case 5:
                finalnumber = Random.Range(minnumber, maxnumber);
                finalnumber2 = Random.Range(minnumber, maxnumber);
                finalnumber3 = Random.Range(minnumber, maxnumber);
                finalnumber4 = Random.Range(minnumber, maxnumber);
                finalnumber5 = Random.Range(minnumber, maxnumber);
                break;
        }
        totalnumber = finalnumber + finalnumber2 + finalnumber3 + finalnumber4 + finalnumber5;
        TxtTotalResult.text = "" + totalnumber;
        TxtResult.text = "" + finalnumber + "+" + finalnumber2+ "+" + finalnumber3 + "+" + finalnumber4 + "+" + finalnumber5;
        numberofthem.Add(TxtResult.text.ToString()); //при клике добавляем полученый результат в лист бросков
        if (showlist) // если список всех бросков открыт, то прячем его при броске
        { ClickShowList(); }
    }       
    public void ClickShowList() //выводит список всех бросков
    {               
        if (!showlist)
        {
            showlist = true;
            AllRollsList.SetActive(true); //активируем всплывающее меню с общим количеством бросков
            Text TxtAllRolls = GameObject.Find("TxtCountedRolls").GetComponent<Text>();
            TxtAllRolls.text = "";         
                for (int i = 1; i < numberofthem.Count; i++)
                {
                    TxtAllRolls.text += numberofthem.Count - i + ". " + numberofthem[numberofthem.Count - i] + "\n";
                }
        } else {showlist = false; AllRollsList.SetActive(false);}       
    }
    public void ClickD4()
    {
        maxnumber = 5;
        TxtChooseDice.text = "D4 ";       
    }
    public void ClickD6()
    {
        maxnumber = 7;
        TxtChooseDice.text = "D6 ";
    }
    public void ClickD8()
    {
        maxnumber = 9;
        TxtChooseDice.text = "D8 ";
    }
    public void ClickD10()
    {
        maxnumber = 11;
        TxtChooseDice.text = "D10 ";
    }
    public void ClickD12()
    {
        maxnumber = 13;
        TxtChooseDice.text = "D12 ";
    }
    public void ClickD20()
    {
        maxnumber = 21;
        TxtChooseDice.text = "D20 ";
    }
    public void ClickD30()
    {
        maxnumber = 31;
        TxtChooseDice.text = "D30 ";
    }
    public void ClickX1()
    {
        TxtAddDice.text = "x1";
        numberofdices = 1;
    }
    public void ClickX2()
    {
        TxtAddDice.text = "x2";
        numberofdices = 2;
    }
    public void ClickX3()
    {
        TxtAddDice.text = "x3";
        numberofdices = 3;
    }
    public void ClickX4()
    {
        TxtAddDice.text = "x4";
        numberofdices = 4;
    }
    public void ClickX5()
    {
        TxtAddDice.text = "x5";
        numberofdices = 5;
    }
    public void ClickShakeOn()
    {
        if (shakeOn)
        {
            shakeOn = false;            
        } else {shakeOn = true;}
    }
    void Update()
    {
       /* if (shakeOn)
        { 
           bool Delta1 = GameObject.Find("LangManager").GetComponent<LangManager>().ShakeIsOn;
            if (Delta1 == true)
            { ClickRoll(); }
        }*/
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
    public void ClickBack()
    {
        SceneManager.LoadScene("MainMenu");
    }  
  }