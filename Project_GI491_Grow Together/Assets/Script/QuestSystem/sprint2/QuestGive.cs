using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGive : MonoBehaviour
{
    public bool TalkMom;

    public Quest quest;

    public Player player;

    public GameObject questWindowtxt;
    public GameObject questWindow;
    public GameObject logWindow;
    public Text titleText;

    public void Update()
    {
        if (TalkMom && Input.GetKeyDown(KeyCode.Space))
        {
            OpenLogQuest();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TalkMom = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TalkMom = false;
        }
    }

    public void OpenLogQuest()
    {
        logWindow.SetActive(true);   
    }

    public void CloseLogMom()
    {
        logWindow.SetActive(false);
    }

    public void OpenWindowQuest()
    {
        if (player.haveQuest == false && player.currentQuest < player.maxQuest) 
        {
            questWindow.SetActive(true); 
        } 
    }

    public void CloseWindowQuest()
    {
        questWindow.SetActive(false);
        logWindow.SetActive(false);
    }

    public void GiveQuest()
    {
        if (player.haveQuest == false)
        {
            questWindowtxt.SetActive(true);
            titleText.text = quest.title;
            quest.isActive = true;
            player.quest = quest;
            player.haveQuest = true;
            logWindow.SetActive(false);
            questWindow.SetActive(false);
        }
    }

    public void QuestComplete()
    {
        if (player.haveQuest == true)
        {
            if (player.quest.isActive == false)
            {
                questWindowtxt.SetActive(false);
                player.currentQuest += 1;
                player.haveQuest = false;
            }
        }
    }

    private void FixedUpdate()
    {
        QuestComplete();
    }
}
