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
    private bool twodices = false; //определяем сколько кубиков бросать
    private bool showlist = false; //выводит полный список бросков
    public Text TxtRoll; //текстовые поля, потом будут нужны при выборе языка
    public Text TxtAddDice;
    public Text TxtResult;
    public Text TxtBack;
    public Text TxtLastRoll;
    public Text TxtChooseDice;
    public GameObject AllRollsList;
    private List<string> numberofthem = new List<string>(); //создаем лист который будет хранить значения бросков
       
    void Start()
    {
        TxtRoll.text = "D6 " + LangManager.instance.GetWord("Roll");
        TxtAddDice.text = LangManager.instance.GetWord("AddDice");
        TxtResult.text = LangManager.instance.GetWord("Result");
        TxtBack.text = LangManager.instance.GetWord("Back");
        TxtLastRoll.text = LangManager.instance.GetWord("AllResults");
        TxtChooseDice.text = LangManager.instance.GetWord("ChooseDice");
    }

 
    public void ClickRoll() //бросок
    {
        finalnumber = Random.Range(minnumber, maxnumber);
        if (twodices)
        {finalnumber2 = Random.Range(minnumber, maxnumber);}
        else { finalnumber2 = 0; }
        totalnumber = finalnumber + finalnumber2;
        numberofthem.Add(TxtResult.text.ToString()); //при клике добавляем полученый результат в лист бросков
        if (twodices == false) { TxtResult.text = "" + finalnumber; }
        else if (twodices)
        {TxtResult.text = "" + finalnumber + "+" + finalnumber2 + "=" + totalnumber;}
        if (showlist) // если список всех бросков открыт, то прячем его при броске
        {ClickShowList();}
    }    
    public void ClickAddDice () //добавить кубик
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
        TxtRoll.text = "D4 " + LangManager.instance.GetWord("Roll");
    }
    public void ClickD6()
    {
        maxnumber = 7; 
        TxtRoll.text = "D6 " + LangManager.instance.GetWord("Roll");
    }
    public void ClickD8()
    {
        maxnumber = 9; 
        TxtRoll.text = "D8 " + LangManager.instance.GetWord("Roll");
    }
    public void ClickD10()
    {
        maxnumber = 11; 
        TxtRoll.text = "D10 " + LangManager.instance.GetWord("Roll");
    }
    public void ClickD12()
    {
        maxnumber = 13; 
        TxtRoll.text = "D12 " + LangManager.instance.GetWord("Roll");
    }
    public void ClickD20()
    {
        maxnumber = 21;
        TxtRoll.text = "D20 " + LangManager.instance.GetWord("Roll");
    }
    public void ClickD30()
    {
        maxnumber = 31; 
        TxtRoll.text = "D30 " + LangManager.instance.GetWord("Roll");
    }
    void Update()
    {
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