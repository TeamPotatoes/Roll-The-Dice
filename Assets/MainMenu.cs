using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    public Text DiceButton;
    public Text CoinButton;
    public Text TimersButton;
    public Text TwisterButton;
    public Text SettingButton;
    public Text ExitButton;

    void Start()
    {
        DiceButton.text = LangManager.instance.GetWord("Dice");
        CoinButton.text = LangManager.instance.GetWord("Coin");
        TimersButton.text = LangManager.instance.GetWord("Timers");
        TwisterButton.text = LangManager.instance.GetWord("Twister");
        SettingButton.text = LangManager.instance.GetWord("Settings");
        ExitButton.text = LangManager.instance.GetWord("Exit");
    }

    public void DiceScene ()
    {SceneManager.LoadScene("DiceScene");}
    public void CoinScene()
    {SceneManager.LoadScene("CoinScene");}
    public void TimerScene()
    {SceneManager.LoadScene("TimerScene");}
    public void TwisterScene()
    {SceneManager.LoadScene("TwisterScene");}
    public void SettingsScene()
    {SceneManager.LoadScene("SettingsScene");}    
    public void ExitApp ()
    {
        Application.Quit();
    }
}
