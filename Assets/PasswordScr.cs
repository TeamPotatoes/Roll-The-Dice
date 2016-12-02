using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PasswordScr : MonoBehaviour {
  
    const string glyphs = "abcdefghijklmnopqrstuvwxyz0123456789QAZWSXEDCRFVTGBYHNUJMIKOLP!_";
    private string myString;
    public Text Result;
    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}
    public void ClickGen()
    {
        int charAmount = Random.Range(6, 12);
        for (int i = 0; i < charAmount; i++)
        {
            myString += glyphs[Random.Range(0, glyphs.Length)];
            Result.text = myString;
        }
        Debug.Log(myString);
        if(myString != null) { myString = null; }
    }

    public void ClickBack()
    {
        Application.LoadLevel("MainMenu");
    }
}
