using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class GoalQuest 
{
    public GoalType goalType;

    public int requiredAmount;
    public int currentAmount;

    public bool IsReached()
    {
        return (currentAmount >= requiredAmount);
    }

    public void DishWash ()
    {
        if (goalType == GoalType.wash)
            currentAmount++;
    }
    public void Ok()
    {
        if (goalType == GoalType.buy)
            currentAmount++;
    }
}

public enum GoalType
{
    wash,buy
}
