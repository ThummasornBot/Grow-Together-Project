using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayDay : MonoBehaviour
{
    public int day = 0;
    public Text dayTxt;
    public Player player;
    public GameObject scenesSleep;
    public GameObject endScenesSleep;

    public GameObject timerDisplay;
    public int timerMin;
    public int timerSec;
    public bool takingAway = true;
    public bool goSleep = false;

    bool Checkbed = false;
    

    // Start is called before the first frame update
    void Start()
    {
        takingAway = false;
        timerMin = 2;
        timerSec = 59;
        day = 1;
        dayTxt.text = "Day : " + day;
        timerDisplay.GetComponent<Text>().text = "0" + timerMin + ":" + timerSec;

    }
    void TimerSet()
    {
        takingAway = false;
        timerMin = 2;
        timerSec = 59;
        dayTxt.text = "Day : " + day;
        timerDisplay.GetComponent<Text>().text = "0" + timerMin + ":" + timerSec;
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        if (timerMin > 0 && timerSec == 0)
        {
            timerDisplay.GetComponent<Text>().text = "0" + timerMin + ":0" + timerSec;
            
            timerMin -= 1;
            timerSec = 60;
        }
        else if (timerMin == 0 && timerSec == 0)
        {
            timerDisplay.GetComponent<Text>().text = "0" + timerMin + ":0" + timerSec;
            GoSleep();
        }

        yield return new WaitForSeconds(1);
        timerSec -= 1;
        Debug.Log("nt");
        if (timerMin < 10 && timerSec < 10)
        {
            timerDisplay.GetComponent<Text>().text = "0" + timerMin + ":0" + timerSec;
        }
        else if(timerMin < 10 )
        {
            timerDisplay.GetComponent<Text>().text = "0" + timerMin + ":" + timerSec;
        }
        
        takingAway = false;
    }

    public void NextDay()
    {

        day += 1;
        dayTxt.text = "Day : " + day;
        player.currentQuest = 0;


    }

    // Update is called once per frame
    void Update()
    {
        if (takingAway == false && timerSec >= 0 && goSleep == false)
        {
            StartCoroutine(TimerTake());
        }
        UseGoSleep();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Checkbed = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Checkbed = false;
        }
    }

    public void UseGoSleep()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Checkbed == true)
        {
            GoSleep();
        }
    }

    public void GoSleep()
    {
        goSleep = true;
        scenesSleep.SetActive(true);
        endScenesSleep.SetActive(false);
    }
    public void NextScene()
    {
        endScenesSleep.SetActive(true);
    }
    public void endScene()
    {
        scenesSleep.SetActive(false);
        endScenesSleep.SetActive(false);
        NextDay();
        TimerSet();
        goSleep = false;
    }
}
