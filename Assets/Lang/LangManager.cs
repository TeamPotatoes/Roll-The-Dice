using UnityEngine;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using UnityEngine.UI;



public class LangManager : MonoBehaviour {

/*
    private static LangManager LangPrefab;
    public static LangManager instance = null;
    public string[] tags;
    public TextAsset languageFile;
    private string lang;
    private string Lang { get { return lang; } set { PlayerPrefs.SetString("SysLanguage", value); lang = value; } }
    private string SysLang;



    public Text DiceButton;
    public Text CoinButton;
    public Text TimersButton;
    public Text TwisterButton;


    public string GetLang()
    {
        return lang;
        
    }
    public void SetLang(string lan)
    {
        PlayerPrefs.SetString("SysLanguage", lan);
    }

    private Dictionary<string, Dictionary<string, string>> languages;
    private XmlDocument xmlDoc = new XmlDocument();
    private XmlReader reader;

    //переменные тряски
    private float AccelUpadateInterval = 1 / 60;
    private float LowPassSec = 1;
    private float ShakeDetectPoint = 2;
    private float LowPassFilter;
    private Vector3 LowPassValue = Vector3.zero;
    private Vector3 Accel;
    private Vector3 DeltaAccel;
    public bool ShakeIsOn;

    void Awake()
    {
        SysLang = Application.systemLanguage.ToString();
        instance = this;
    }


  void DontDestoryThisFile()
    {
        DontDestroyOnLoad(this);
        if(LangPrefab == null) { LangPrefab = this;}
        else { Destroy(gameObject); }
    }

    void Start()
    {
       DontDestoryThisFile();


        if (!PlayerPrefs.HasKey("SysLanguage") || !PlayerPrefs.HasKey("SysLanguage") && SysLang == "Russian")
        {
            PlayerPrefs.SetString("SysLanguage", "RU");
            PlayerPrefs.Save();
            // PlayerPrefs.SetString("SysLanguage", "EN");
            Lang = tags[0];
        }
        else if (!PlayerPrefs.HasKey("SysLanguage") || !PlayerPrefs.HasKey("SysLanguage") && SysLang == "Russian")
        {
            PlayerPrefs.SetString("SysLanguage", "EN");
            PlayerPrefs.Save();
        }
        else
        {
           
            Lang = PlayerPrefs.GetString("SysLanguage");
           
        }

        languages = new Dictionary<string, Dictionary<string, string>>();
        reader = XmlReader.Create(new StringReader(languageFile.text));
        xmlDoc.Load(reader);

        for (int i = 0; i < tags.Length; i++)
        {
            languages.Add(tags[i], new Dictionary<string, string>());
            XmlNodeList langs = xmlDoc["Data"].GetElementsByTagName(tags[i]);
            for (int j = 0; j < langs.Count; j++)
            {
                languages[tags[i]].Add(langs[j].Attributes["Key"].Value, langs[j].Attributes["Word"].Value);
            }
        }
        //тряска
        ShakeDetectPoint *= ShakeDetectPoint;
        LowPassValue = Input.acceleration;
    }

    void Update()
    {
        DiceButton.text = LangManager.instance.GetWord("Dice");
        CoinButton.text = LangManager.instance.GetWord("Coin");
        TimersButton.text = LangManager.instance.GetWord("Timers");
        TwisterButton.text = LangManager.instance.GetWord("Twister");




        lang = PlayerPrefs.GetString("SysLanguage");
        //для тряски
        LowPassFilter = AccelUpadateInterval / LowPassSec;
        Accel = Input.acceleration;
        LowPassValue = Vector3.Lerp(LowPassValue, Accel, LowPassFilter);
        DeltaAccel = Accel - LowPassValue;
        if (DeltaAccel.sqrMagnitude >= ShakeDetectPoint)
        {
            Debug.Log("ТРЯСЕТ БЛЕАААТЬ111" + Time.deltaTime);
            ShakeIsOn = true;
        }
        else { ShakeIsOn = false;}
   
    }

    public string GetWord(string key)
    {
        return languages[lang][key];
    }
    */
}
