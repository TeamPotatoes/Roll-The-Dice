using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsScr : MonoBehaviour {
    public Text RusButton;
    public Text EngButton;
    public Text TxtBack;
  

    public void ChangeToEnglish()
    {
      
        PlayerPrefs.SetString("SysLanguage", "EN");
        PlayerPrefs.Save();
        RusButton.text = "Rus";
        EngButton.text = "Eng";
        TxtBack.text = "Back";
        Debug.Log(PlayerPrefs.GetString("SysLanguage"));
    }
    public void ChangeToRussian()
    {
        PlayerPrefs.SetString("SysLanguage", "RU");
        PlayerPrefs.Save();
        RusButton.text = "Рус";
        EngButton.text = "Англ";
        TxtBack.text = "Назад";
        Debug.Log(PlayerPrefs.GetString("SysLanguage"));
    }
    void Start()
    {
        RusButton.text = LangManager.instance.GetWord("Changetorus");
        EngButton.text = LangManager.instance.GetWord("Changetoeng");
        TxtBack.text = LangManager.instance.GetWord("Back");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
    public void ClickBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

