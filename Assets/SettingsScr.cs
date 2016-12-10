using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsScr : MonoBehaviour {
    public Text RusButton;
    public Text EngButton;
    public Text BackButton;
     
    public void ChangeToEnglish()
    {
       
    }
    public void ChangeToRussian()
    {
        
    }
    public void ClickBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

