using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.Serialization;


[SerializeField]
public class AddRU : MonoBehaviour
{
    private string json;
    private string PathJson;
    private string txtback;
    private string txtchangeeng;
    private string txtchangeerus;
    AddRU MyJson = new AddRU();
    void Start()
    {
        PathJson = Directory.GetCurrentDirectory() + @"\Assets\Lang\RU.json";
        // string json = JsonUtility.FromJson<RU>(MyJson);
    }
}



public class SettingsScr : MonoBehaviour {
    public Text RusButton;
    public Text EngButton;
    public Text BackButton;
    private string SysLanguage;
    private string PathEng;
    private string PathJson;
    //  public TextAsset RU;
    // public TextAsset ENG;
   // public string RU;



    void Start()
    {        
  
       
        Debug.Log(PathJson);
        PathJson = Directory.GetCurrentDirectory() + @"\Assets\Lang\RU.json";

        PathEng = Directory.GetCurrentDirectory() + @"\Assets\Lang\ENG-eng.txt" ;


        string ENG = File.ReadAllText(PathEng);

         using (StreamReader e = File.OpenText(PathEng))
         {
             string s = "";
             while ((s = e.ReadLine()) != null)
             {
                 Debug.Log(s);
               
            }
         }

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

