using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TwisterScr : MonoBehaviour {
    private int finalnumber = 0; // результат вращения цвет    
    private int finalnumber2 = 0; // результат вращения конечность 
    public Text TxtTurn;
    public Text TxtResult;
    public Text TxtResult2;

    void Update()
    {      
        TxtTurn.text = "Turn wheel"; 
    }
        
    //Функции вызвываемые по клику мышки
    public void ClickFlip()
    {
        finalnumber = Random.Range(1, 5);
        finalnumber2 = Random.Range(1, 5);
        if (finalnumber == 1)
        {
            TxtResult.text = "Red";
            TxtResult.color = Color.red;
        }
        if (finalnumber == 2)
        {
            TxtResult.text = "Green";
            TxtResult.color = Color.green;
        }
        if (finalnumber == 3)
        {
            TxtResult.text = "Yellow";
            TxtResult.color = Color.yellow;
        }
        if (finalnumber == 4)
        {
            TxtResult.text = "Blue";
            TxtResult.color = Color.blue;
        }
        if (finalnumber2 == 1)
        {
            TxtResult2.text = "Left Hand";
        }
        if (finalnumber == 2)
        {
            TxtResult2.text = "Right Hand";
        }
        if (finalnumber == 3)
        {
            TxtResult2.text = "Left foot";
        }
        if (finalnumber == 4)
        {
            TxtResult2.text = "Right foot";
        }
    }
    public void ClickBack()
    {
        Application.LoadLevel("MainMenu");
    }
}
