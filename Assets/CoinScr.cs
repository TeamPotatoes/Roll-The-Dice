using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class CoinScr : MonoBehaviour {
    private int finalnumber = 0; // результат броска 
    private int headscount = 0;
    private int tailscount = 0;
    private int totalflips = 0;
    public Text TxtFlip;
    public Text TxtResult;
    public Text TxtBack;
        
    void Start()
    {      
        TxtFlip.text = LangManager.instance.GetWord("FlipCoin");
        TxtResult.text = LangManager.instance.GetWord("Result");
        TxtBack.text = LangManager.instance.GetWord("Back");
    }
    //Функции вызвываемые по клику мышки
    public void ClickFlip()
    {
        finalnumber = Random.Range(1, 3);
        if (finalnumber == 1)
        {TxtResult.text = LangManager.instance.GetWord("TxtResultHeads"); headscount += 1; }
        if (finalnumber == 2)
        {TxtResult.text = LangManager.instance.GetWord("TxtResultTails"); tailscount += 1; }
        totalflips += 1;
        float Headstotal = ((float)headscount / (float)totalflips) * 100; //фишка в том что int обращается в 0 при делении из-за того что нет определения занков после запятой
        float Tailstotal = ((float)tailscount / (float)totalflips) * 100;
        Text TxtPercentage = GameObject.Find("TxtPercentage").GetComponent<Text>();        
        TxtPercentage.text = LangManager.instance.GetWord("TxtResultHeads") + ": " + headscount + "(" + Headstotal.ToString("F1") + "%)" + LangManager.instance.GetWord("TxtResultTails") + ": " + tailscount + "(" + Tailstotal.ToString("F1") + "%)" + "\n" + totalflips;
    }   
    void Update()
    {
        bool Delta1 = GameObject.Find("LangManager").GetComponent<LangManager>().ShakeIsOn;
        if (Delta1 == true)
        {
            Debug.Log("DSDFDSFSFD" + Time.deltaTime);
            ClickFlip();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        { ClickBack(); }
    }
    public void ClickBack()
    {SceneManager.LoadScene("MainMenu");}
}
