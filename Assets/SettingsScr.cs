using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsScr : MonoBehaviour {

    public GameObject ChangeToRu;
    public GameObject ChangeToEn;
    private string CurrentLang;


    public Text DiceButton;
    public Text CoinButton;
    public Text TimersButton;
    public Text TwisterButton;

    void Start()
    {
        if (CurrentLang == "EN")
        {
            ChangeToRu.SetActive(true); ChangeToEn.SetActive(false);
        }
        if (CurrentLang == "RU")
        {
            ChangeToRu.SetActive(false); ChangeToEn.SetActive(true);
        }
        DiceButton.text = LangManager.instance.GetWord("Dice");
        CoinButton.text = LangManager.instance.GetWord("Coin");
        TimersButton.text = LangManager.instance.GetWord("Timers");
        TwisterButton.text = LangManager.instance.GetWord("Twister");
    }
    

   
    public void Changelang()
    {
        if (CurrentLang == "EN")
        {
            PlayerPrefs.SetString("SysLanguage", "RU");
            PlayerPrefs.Save();
           ChangeButton();
            Debug.Log(CurrentLang);
            ChangeToRu.SetActive(true); ChangeToEn.SetActive(false);
        }
         if(CurrentLang == "RU")
        {
            PlayerPrefs.SetString("SysLanguage", "EN");
            PlayerPrefs.Save();
            ChangeButton();
            Debug.Log(CurrentLang);
            ChangeToRu.SetActive(false); ChangeToEn.SetActive(true);
        }
    }
    public void ChangeButton()
    {
        DiceButton.text = LangManager.instance.GetWord("Dice");
        CoinButton.text = LangManager.instance.GetWord("Coin");
        TimersButton.text = LangManager.instance.GetWord("Timers");
        TwisterButton.text = LangManager.instance.GetWord("Twister");
    }
    
    
    void FixedUpdate()
    {
        CurrentLang = PlayerPrefs.GetString("SysLanguage", "");
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
  
}

