using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public void DiceScene ()
    {
        Application.LoadLevel("DiceScene");
    }
    public void CoinScene()
    {
        Application.LoadLevel("CoinScene");
    }
    public void TimerScene()
    {
        Application.LoadLevel("TimerScene");
    }
    public void TwisterScene()
    {
        Application.LoadLevel("TwisterScene");
    }
    public void SettingsScene()
    {
        Application.LoadLevel("SettingsScene");
    }
    public void ExitApp ()
    {
        Application.Quit();
    }
}
