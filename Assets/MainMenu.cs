using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

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
