using UnityEngine;
using System.Collections;
using System.Xml;


public class LangManager : MonoBehaviour {
    enum LangType { en = 0, ru};
    private static LangType curLanguage = LangType.en;
    public static LangType currentLanguage {
        get { return curLanguage; }
        set { curLanguage = value; }
    }

    void Start ()
    {
        XmlDocument root = new XmlDocument();
        if (!File.Exists(LanguagesFileName))
        {
            Debug.Log("Lang file is not find in directory");
            return;
        }
        }
	
	// Update is called once per frame
	void Update () {
	
	}
}
