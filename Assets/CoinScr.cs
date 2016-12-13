using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CoinScr : MonoBehaviour {
    private int finalnumber = 0; // результат броска    
    public Text TxtFlip;
    public Text TxtResult;
    public Text BackButton;

    void Start()
    {      
        TxtFlip.text = LangManager.instance.GetWord("FlipCoin");
        BackButton.text = LangManager.instance.GetWord("Back");
    }
        
    //Функции вызвываемые по клику мышки
    public void ClickFlip()
    {
        finalnumber = Random.Range(1, 3);
        if (finalnumber == 1)
        {
            TxtResult.text = LangManager.instance.GetWord("TxtResultHeads");
        }
        if (finalnumber == 2)
        {
            TxtResult.text = LangManager.instance.GetWord("TxtResultTails");
        }
    }
    public void ClickBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
