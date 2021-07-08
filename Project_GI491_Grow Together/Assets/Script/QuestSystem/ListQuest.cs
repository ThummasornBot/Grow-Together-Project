using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListQuest : MonoBehaviour
{
    public Quest quest;

    public Player player;

    public GameObject questWindow;
    public Text titleText;

    
    
    void Start()
    {
        questWindow.SetActive(true);
        titleText.text = quest.title;
        quest.isActive = true;
        player.quest = quest;
      
    }
    public void QuestComplete()
    {
        questWindow.SetActive(false);
    }
}
