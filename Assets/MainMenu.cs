using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    public Text DiceButton;
    public Text CoinButton;
    public Text SandglassButton;
    public Text TwisterButton;
    public Text SettingButton;
    public Text ExitButton;
    private string SysLanguage;

    void Start()
    {
        SysLanguage = PlayerPrefs.GetString("Language");
        if(SysLanguage == "Eng")
        {
            DiceButton.text = "Dices";
            CoinButton.text = "Coin";
            SandglassButton.text = "Sandglass";
            TwisterButton.text = "Twister";
            SettingButton.text = "Settings";
            ExitButton.text = "Exit";
        }
        if (SysLanguage == "Rus")
        {
            DiceButton.text = "Кости";
            CoinButton.text = "Монетка";
            SandglassButton.text = "Песочные Часы";
            TwisterButton.text = "Твистер";
            SettingButton.text = "Настройки";
            ExitButton.text = "Выход";
        }
    }

    public void DiceScene ()
    {
        SceneManager.LoadScene("DiceScene");
    }
    public void CoinScene()
    {
        SceneManager.LoadScene("CoinScene");
    }
    public void TimerScene()
    {
        SceneManager.LoadScene("TimerScene");
    }
    public void TwisterScene()
    {
        SceneManager.LoadScene("TwisterScene");
    }
    public void SettingsScene()
    {
        SceneManager.LoadScene("SettingsScene");
    }
    public void PasswordScene()
    {
        SceneManager.LoadScene("PasswordScen");
    }
    public void ExitApp ()
    {
        Application.Quit();
    }
}
