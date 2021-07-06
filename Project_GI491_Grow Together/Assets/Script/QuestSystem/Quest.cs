using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Quest
{
    public bool CheckButton = false;

    public bool isActive;

    public string title;
    public string descrit;
    public int money = 15;

    public GoalQuest goal;

    

    public void Complete()
    {
        isActive = false;
        
        Debug.Log(title + " complete");
    }
    public void Complete2()
    {
        isActive = false;
        
        Debug.Log(title + " complete");
    }
}
