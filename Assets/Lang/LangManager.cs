using UnityEngine;
using System.Collections.Generic;
using System.Xml;
using System.IO;



public class LangManager : MonoBehaviour {


    private static LangManager LangPrefab;
    public static LangManager instance = null;
    public string[] tags;
    public TextAsset languageFile;
    private string lang;
    private string Lang {get{return lang;}set{PlayerPrefs.SetString("SysLanguage", value); lang = value;}}

    public string GetLang()
    {
        return lang;
        
    }

 /*   public void SetLang(string lan)
    {
        PlayerPrefs.SetString("SysLanguage", lan);
    }*/

    private Dictionary<string, Dictionary<string, string>> languages;
    private XmlDocument xmlDoc = new XmlDocument();
    private XmlReader reader;
    
    void Awake()
    {
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
    

        if (!PlayerPrefs.HasKey("SysLanguage"))
        {
            Lang = tags[0];
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
     
    }

    void Update()
    {
        lang = PlayerPrefs.GetString("SysLanguage");
    }

  public string GetWord(string key)
    {
        return languages[lang][key];
    }
}
