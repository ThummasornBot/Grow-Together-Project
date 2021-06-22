using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListQuest2 : MonoBehaviour
{
    public Quest quest;

    public Player player;

    public GameObject questWindow;
    public Text titleText;



    public void Start()
    {
        questWindow.SetActive(true);
        titleText.text = quest.title;
        quest.isActive = true;
        player.quest2 = quest;
    }
    public void QuestComplete()
    {
        questWindow.SetActive(false);
    }
}
