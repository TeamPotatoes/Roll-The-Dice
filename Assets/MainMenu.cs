using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    void Start()
    {
                
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            {ExitApp();}
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
    {Application.Quit();}
}
