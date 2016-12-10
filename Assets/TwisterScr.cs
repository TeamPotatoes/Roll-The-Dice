using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class TwisterScr : MonoBehaviour {
    private int finalnumber = 0; // результат вращения цвет    
    private int finalnumber2 = 0; // результат вращения конечность 
    public Text TxtTurn;
    public Text TxtResult;
    public Text TxtResult2;
    public Sprite tw_foot; //спрайт ноги
    public Sprite tw_hand; //спрайт руки

    void Start()
    {
        GetComponent<Renderer>().material.color = new Color(0.0F, 1.0F, 0.0F, 0.0F); //спрайт ноги виден при работе, но при старте игры станет прозрачным. Удобно
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
            GetComponent<SpriteRenderer>().material.color = Color.red;
        } else if (finalnumber == 2)
        {
            TxtResult.text = "Green";
            TxtResult.color = Color.green;
            GetComponent<SpriteRenderer>().material.color = Color.green;
        }else if (finalnumber == 3)
        {
            TxtResult.text = "Yellow";
            TxtResult.color = Color.yellow;
            GetComponent<SpriteRenderer>().material.color = Color.yellow;
        }else if (finalnumber == 4)
        {
            TxtResult.text = "Blue";
            TxtResult.color = Color.blue;
            GetComponent<SpriteRenderer>().material.color = Color.blue;
        }
        if (finalnumber2 == 1)
        {
            TxtResult2.text = "Left Hand";
            GetComponent<SpriteRenderer>().sprite = tw_hand;
            GetComponent<SpriteRenderer>().flipX = true;
        } else if (finalnumber2 == 2)
        {
            TxtResult2.text = "Right Hand";
            GetComponent<SpriteRenderer>().sprite = tw_hand;
            GetComponent<SpriteRenderer>().flipX = false;
        } else if (finalnumber2 == 3)
        {
            TxtResult2.text = "Left foot";
            GetComponent<SpriteRenderer>().sprite = tw_foot;
            GetComponent<SpriteRenderer>().flipX = false;
        } else if (finalnumber2 == 4)
        {
            TxtResult2.text = "Right foot";
            GetComponent<SpriteRenderer>().sprite = tw_foot;
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }
    public void ClickBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
