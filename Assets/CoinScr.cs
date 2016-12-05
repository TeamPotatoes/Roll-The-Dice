using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CoinScr : MonoBehaviour {
    private int finalnumber = 0; // результат броска    
    public Text TxtFlip;
    public Text TxtResult;

    void Update()
    {      
        TxtFlip.text = "Flip Coin Here"; 
    }
        
    //Функции вызвываемые по клику мышки
    public void ClickFlip()
    {
        finalnumber = Random.Range(1, 3);
        if (finalnumber == 1)
        {
            TxtResult.text = "Heads";
        }
        if (finalnumber == 2)
        {
            TxtResult.text = "Tails";
        }
    }
    public void ClickBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
