using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SettingsScr : MonoBehaviour {

    public bool English;
    public bool Russian;
    public PlayerPrefs Language;


    void Star()
    {
        English = true;
        Russian = false;
    }
 /*   public void ChangToEnglish()
    {
        English = true;
        Russian = false;
    }
    public void ChangeToRussian()
    {
        English = false;
        Russian = true;
    }
    */
    public void ChangeToEnglish()
    {
        PlayerPrefs.SetInt("Language", 1);
    }

    public void ChangeToRussian()
    {
        PlayerPrefs.SetInt("Language", 2);
    }
    void Update () {
	}
    public void ClickBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
