using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SettingsScr : MonoBehaviour {


    
	void Start ()
    {

    }
	void Update () {
	}
    public void ClickBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
