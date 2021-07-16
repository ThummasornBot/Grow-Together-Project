using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGive : MonoBehaviour
{
    public bool TalkMom;

    public Quest quest1;
    public GameObject popUpWash;
    public Quest quest2;
    public GameObject popUpWater;
    public Quest quest3;
    public GameObject popUpBrush;
    public Quest quest4;
    public GameObject popUpBath;
    public Quest quest5;
    public GameObject popUpBuy;
    public Quest quest6;
    public GameObject popUpEat;
    public Quest quest7;
    public GameObject popUpRub;
    public Quest quest8;
    public GameObject popUpPick;
    public Quest quest9;
    public GameObject popUpSweep;

    public Player player;

    public GameObject questWindowtxt;
    public GameObject questWindow;
    public GameObject logWindow;
    public Text titleText;

    public GameObject[] buttonAccept;
    public GameObject infoQuest;
    public Text questTitle;
    public Text questDes;
    public Text questMoney;

    public GameObject WashTextbutton;

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

    public void CancelQuest()
    {
        questWindow.SetActive(false);
        logWindow.SetActive(false);
        infoQuest.SetActive(false);
        buttonAccept[0].SetActive(false);
        buttonAccept[1].SetActive(false);
        buttonAccept[2].SetActive(false);
        buttonAccept[3].SetActive(false);
        buttonAccept[4].SetActive(false);
        buttonAccept[5].SetActive(false);
        buttonAccept[6].SetActive(false);
        buttonAccept[7].SetActive(false);
        buttonAccept[8].SetActive(false);

    }

    public void GiveQuest()
    {
        if (player.haveQuest == false && Player.HappyValue > 0)
        {
            questTitle.text = quest1.title;
            questDes.text = quest1.descrit;
            questMoney.text = "Money : " + quest1.money;
            buttonAccept[0].SetActive(true);
            infoQuest.SetActive(true);
        }
    }
    public void AcceptQuest()
    {
        popUpWash.SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest1.title;
        quest1.isActive = true;
        player.quest = quest1;
        player.haveQuest = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        Player.HappyValue -= 1;
    }

    public void GiveQuest2()
    {
        if (player.haveQuest == false && Player.HappyValue > 0)
        {
            questTitle.text = quest2.title;
            questDes.text = quest2.descrit;
            questMoney.text = "Monet : " + quest2.money;
            buttonAccept[1].SetActive(true);
            infoQuest.SetActive(true);
        }
    }
    public void AcceptQuest2()
    {
        popUpWater.SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest2.title;
        quest2.isActive = true;
        player.quest = quest2;
        player.haveQuest = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        Player.HappyValue -= 1;
    }

    public void GiveQuest3()
    {
        if (player.haveQuest == false && Player.HappyValue > 0)
        {
            questTitle.text = quest3.title;
            questDes.text = quest3.descrit;
            questMoney.text = "Monet : " + quest3.money;
            buttonAccept[2].SetActive(true);
            infoQuest.SetActive(true);
        }
    }
    public void AcceptQuest3()
    {
        popUpBrush.SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest3.title;
        quest3.isActive = true;
        player.quest = quest3;
        player.haveQuest = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        Player.HappyValue -= 1;
    }

    public void GiveQuest4()
    {
        if (player.haveQuest == false && Player.HappyValue > 0)
        {
            questTitle.text = quest4.title;
            questDes.text = quest4.descrit;
            questMoney.text = "Monet : " + quest4.money;
            buttonAccept[3].SetActive(true);
            infoQuest.SetActive(true);
        }
    }
    public void AcceptQuest4()
    {
        popUpBath.SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest4.title;
        quest4.isActive = true;
        player.quest = quest4;
        player.haveQuest = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        Player.HappyValue -= 1;
    }

    public void GiveQuest5()
    {
        if (player.haveQuest == false && Player.HappyValue > 0)
        {
            questTitle.text = quest5.title;
            questDes.text = quest5.descrit;
            questMoney.text = "Monet : " + quest5.money;
            buttonAccept[4].SetActive(true);
            infoQuest.SetActive(true);
        }
    }
    public void AcceptQuest5()
    {
        popUpBuy.SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest5.title;
        quest5.isActive = true;
        player.quest = quest5;
        player.haveQuest = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        Player.HappyValue -= 1;
    }

    public void GiveQuest6()
    {
        if (player.haveQuest == false && Player.HappyValue > 0)
        {
            questTitle.text = quest6.title;
            questDes.text = quest6.descrit;
            questMoney.text = "Monet : " + quest6.money;
            buttonAccept[5].SetActive(true);
            infoQuest.SetActive(true);
        }
    }
    public void AcceptQuest6()
    {
        popUpEat.SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest6.title;
        quest6.isActive = true;
        player.quest = quest6;
        player.haveQuest = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        Player.HappyValue -= 1;
    }

    public void GiveQuest7()
    {
        if (player.haveQuest == false && Player.HappyValue > 0)
        {
            questTitle.text = quest7.title;
            questDes.text = quest7.descrit;
            questMoney.text = "Monet : " + quest7.money;
            buttonAccept[6].SetActive(true);
            infoQuest.SetActive(true);
        }
    }
    public void AcceptQuest7()
    {
        popUpRub.SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest7.title;
        quest7.isActive = true;
        player.quest = quest7;
        player.haveQuest = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        Player.HappyValue -= 1;
    }

    public void GiveQuest8()
    {
        if (player.haveQuest == false && Player.HappyValue > 0)
        {
            questTitle.text = quest8.title;
            questDes.text = quest8.descrit;
            questMoney.text = "Monet : " + quest8.money;
            buttonAccept[7].SetActive(true);
            infoQuest.SetActive(true);
        }
    }
    public void AcceptQuest8()
    {
        popUpPick.SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest8.title;
        quest8.isActive = true;
        player.quest = quest8;
        player.haveQuest = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        Player.HappyValue -= 1;
    }

    public void GiveQuest9()
    {
        if (player.haveQuest == false && Player.HappyValue > 0)
        {
            questTitle.text = quest9.title;
            questDes.text = quest9.descrit;
            questMoney.text = "Monet : " + quest9.money;
            buttonAccept[8].SetActive(true);
            infoQuest.SetActive(true);
        }
    }
    public void AcceptQuest9()
    {
        popUpSweep.SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest9.title;
        quest9.isActive = true;
        player.quest = quest9;
        player.haveQuest = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        Player.HappyValue -= 1;
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
                if (quest1.isFinish == true)
                {
                    WashTextbutton.SetActive(false);
                    popUpWater.SetActive(false);
                }
            }
        }
    }

    private void FixedUpdate()
    {
        QuestComplete();
    }
}
