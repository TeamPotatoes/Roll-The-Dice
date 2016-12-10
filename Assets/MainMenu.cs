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
