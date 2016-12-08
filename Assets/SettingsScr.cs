using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


public class SettingsScr : MonoBehaviour {
    public Text RusButton;
    public Text EngButton;
    public Text BackButton;
    private string SysLanguage;
    private string PathLang;


    public XmlDocument XmlDOc;
    public TextAsset Lang;
    private List<string> Buttons;
    private string filename;


   
   
    void Start()
    {

    //    loadXMLFromAssest();




          
        SysLanguage = PlayerPrefs.GetString("Language");
         if (SysLanguage == "Eng")
         {
            
            RusButton.text = "Change to Rus";
             EngButton.text = "Change to Eng";
            // BackButton.text = getString;

         }
         if (SysLanguage == "Rus")
         {
             RusButton.text = "Сменить на Рус";
             EngButton.text = "Сменить на Англ";
           //  BackButton.text = "Назад";

         }

    }



    public void ChangeToEnglish()
    {
        PlayerPrefs.SetString ("Language", "Eng");
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetString("Language"));
    }
    public void ChangeToRussian()
    {
        PlayerPrefs.SetString("Language", "Rus");
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetString("Language"));
    }
    public void ClickBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

