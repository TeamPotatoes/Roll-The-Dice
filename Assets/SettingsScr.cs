using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsScr : MonoBehaviour {
    public Text RusButton;
    public Text EngButton;
    public Text BackButton;
  

    public void ChangeToEnglish()
    {
      
        PlayerPrefs.SetString("SysLanguage", "EN");
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetString("SysLanguage"));
     /*   RusButton.text = LangManager.instance.GetWord("Changetorus");
        EngButton.text = LangManager.instance.GetWord("Changetoeng");
        BackButton.text = LangManager.instance.GetWord("Back");*/
    }
    public void ChangeToRussian()
    {
        PlayerPrefs.SetString("SysLanguage", "RU");
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetString("SysLanguage"));
       /* RusButton.text = LangManager.instance.GetWord("Changetorus");
        EngButton.text = LangManager.instance.GetWord("Changetoeng");
        BackButton.text = LangManager.instance.GetWord("Back");*/
    }
    void Update()
    {
        RusButton.text = LangManager.instance.GetWord("Changetorus");
        EngButton.text = LangManager.instance.GetWord("Changetoeng");
        BackButton.text = LangManager.instance.GetWord("Back");
    }
    public void ClickBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

