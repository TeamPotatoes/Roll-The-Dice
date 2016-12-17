using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class CoinScr : MonoBehaviour {
    private int finalnumber = 0; // результат броска 
    private int headscount = 0;
    private int tailscount = 0;  
    private bool showlist = false; //выводит полный список бросков 
    public Text TxtFlip;
    public Text TxtResult;
    public Text TxtBack;
    public Text TxtAllResults;
    public GameObject AllResultsList;
    private List<string> numberofthem = new List<string>(); //создаем лист который будет хранить значения бросков

    void Start()
    {      
        TxtFlip.text = LangManager.instance.GetWord("FlipCoin");
        TxtResult.text = LangManager.instance.GetWord("Result");
        TxtBack.text = LangManager.instance.GetWord("Back");
        TxtAllResults.text = LangManager.instance.GetWord("AllResults");
    }
        
    //Функции вызвываемые по клику мышки
    public void ClickFlip()
    {
        finalnumber = Random.Range(1, 3);
        if (finalnumber == 1)
        {TxtResult.text = LangManager.instance.GetWord("TxtResultHeads"); headscount += 1; }
        if (finalnumber == 2)
        {TxtResult.text = LangManager.instance.GetWord("TxtResultTails"); tailscount += 1; }
        numberofthem.Add(TxtResult.text.ToString()); //при клике добавляем полученый результат в лист бросков
        Text TxtCurrentResults = GameObject.Find("TxtCurrentResults").GetComponent<Text>();
        TxtCurrentResults.text = "";
        for (int i = 1; i < numberofthem.Count && i < 6; i++)
        {
            TxtCurrentResults.text += numberofthem.Count - i + ". " + numberofthem[numberofthem.Count - i] + "\n";
        }
        Text TxtPercentage = GameObject.Find("TxtPercentage").GetComponent<Text>();        
        TxtPercentage.text = LangManager.instance.GetWord("TxtResultHeads") + ": " + headscount + "(" + (headscount / numberofthem.Count) * 100 + "%)" + LangManager.instance.GetWord("TxtResultTails") + ": " + tailscount + "(" + numberofthem.Count / tailscount + "%)" + "\n" + numberofthem.Count;
        if (showlist) // если список всех бросков открыт, то прячем его при броске
        { ClickShowList(); }
    }
    public void ClickShowList() //выводит список всех бросков
    {
        if (!showlist)
        {
            showlist = true;
            AllResultsList.SetActive(true); //активируем всплывающее меню с общим количеством бросков
            Text TxtAllResultsList = GameObject.Find("TxtAllResults").GetComponent<Text>();
            TxtAllResultsList.text = "";
            for (int i = 1; i < numberofthem.Count; i++)
            {
                TxtAllResultsList.text += numberofthem.Count - i + ". " + numberofthem[numberofthem.Count - i] + "\n";
            }            
        }
        else { showlist = false; AllResultsList.SetActive(false); }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {SceneManager.LoadScene("MainMenu");}
    }
    public void ClickBack()
    {SceneManager.LoadScene("MainMenu");}
}
