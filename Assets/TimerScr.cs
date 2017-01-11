using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScr : MonoBehaviour {
    /*очень сильно упростил и оптимизровал этот скрипт
     1. убрал повторяющиеся переменные в старте (уже присутствуют в иницииации)
     2. убрал кнопку Timer. Теперь одна кнопка Sandglass и при ее нажатии она меняется на Timer
     3. убрал объекты seconds, minutes, hours и вписал все данные в один текстовый объект TxtCounts, сильно облегчило скрипт
     4. как следсвтие, убрал объекты TimerCLock и SandClock и их присутствие в скрипте, осуществил работу через переменные EnableTimer.
     5. мелкие исправления по ходу кода, убирал копирующие друг друга переменные. Например в ClickTimer вывел за if'ы StartCoroutine(Second()) т.к. он должен включаться в любом случае и нет смысла его повторять в каждом if+
     6. Добавлен функционал для песочных часов. Время отсчитывается в обратном порядке
     7. Добавлена возможность выбирать время для песочных часов. Шаг 10 сек
     8. Добавлено выпадающее меню в sandglass с возможностью выбирать нужное время
     */
    private int Seconds = 0;
    private int Minutes = 0;
    private int Hours = 0;
    private float MaxSeconds = 61;
    private int MaxMinutes = 61;
    private int MaxHours = 25;
    public bool TimerCount = false;
    private bool EnableTimer = true;
    private bool EnableSand = false;
    public Text TxtStart;
    public Text TxtReset;
    public Text TxtBack;
    public Text TxtSandGlass;
    public GameObject ChooseTime;

    void Start()
    {
        TxtBack.text = LangManager.instance.GetWord("Back");
        TxtStart.text = LangManager.instance.GetWord("Start");
        TxtReset.text = LangManager.instance.GetWord("Reset");
        TxtSandGlass.text = LangManager.instance.GetWord("Timer");
        ChooseTime.SetActive(false);
    }

    public void ClickTimer()
    {
        if (!TimerCount)
        {
            TimerCount = true;
            TxtStart.text = LangManager.instance.GetWord("Pause");
        } else if (TimerCount)
        {
            TimerCount = false;
            TxtStart.text = LangManager.instance.GetWord("Start");
        }
        StartCoroutine(Second());
    }

    public IEnumerator Second()
    {
        if (EnableTimer)
        {
            while (TimerCount == true)
            {
                Seconds = Seconds + 1;
                yield return new WaitForSeconds(1);
            }
        }
        if (EnableSand)
        {
            while (TimerCount == true)
            {
                Seconds = Seconds - 1;
                yield return new WaitForSeconds(1);
            }
        }
    }

    public void Reset()
    {
        Seconds = 0;
        Minutes = 0;
        Hours = 0;
    }

    void Update()
    {
        if (Seconds == MaxSeconds)
        {
            Seconds = 0;
            Minutes = Minutes + 1;
        }
        if (Minutes == MaxMinutes)
        {
            Seconds = 0;
            Minutes = 0;
            Hours = Hours + 1;
        }
        if (Hours == MaxHours)
        {
            Seconds = 0;
            Minutes = 0;
            Hours = 0;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ClickBack();
        }
        Text TxtCounts = GameObject.Find("TxtCounts").GetComponent<Text>();
        if (EnableSand && Seconds < 0)
        {
            TxtCounts.text = "TIME IS OVER";
        } else { TxtCounts.text = Hours + "h " + Minutes + "m " + Seconds + "s"; }
    }

    public void ClickChangeTimer()
    {
        if (EnableTimer)
        {
            EnableTimer = false;
            EnableSand = true;
            ChooseTime.SetActive(true);
            TxtSandGlass.text = LangManager.instance.GetWord("SandGlass");
        } else if (!EnableTimer)
        {
            EnableTimer = true;
            EnableSand = false;
            ChooseTime.SetActive(false);
            TxtSandGlass.text = LangManager.instance.GetWord("Timer");            
            if (TimerCount)
            {
                ClickTimer();
            }
        }
        Reset(); //обнуляем таймер и останавливаем отсчет при переключении
        if (TimerCount)
        {
            ClickTimer();
        }
    }
    //
    public void ClickAddSec()
    {
        if (Seconds < 59)
        { Seconds += 1; }
    }
    public void ClickDelSec()
    {
        if (Seconds > 0)
        { Seconds -= 1; }
    }
    public void ClickAdd10Sec()
    {
        if (Seconds < 50)
        { Seconds += 10; }
    }
    public void ClickDel10Sec()
    {
        if (Seconds >= 10)
        { Seconds -= 10; }
    }
    public void ClickAddMin()
    {
        if (Minutes < 59)
        { Minutes += 1; }
    }
    public void ClickDelMin()
    {
        if (Minutes > 0)
        { Minutes -= 1; }
    }
    public void ClickAdd10Min()
    {
        if (Minutes < 50)
        { Minutes += 10; }
    }
    public void ClickDel10Min()
    {
        if (Minutes > 10)
        { Minutes -= 10; }
    }
    public void ClickAddHr()
    { 
        if (Hours < 24)
        {Hours += 1;}
    }
    public void ClickDelHr()
    {
        if (Hours > 0)
        {Hours -= 1;}
    }
    public void ClickBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
