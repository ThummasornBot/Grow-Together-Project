using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int money;
    public string moneytxt;
    public Text txtmoney;

    public Quest quest;
    public Quest quest2;

    private void Start()
    {
        money = 0;
        txtmoney.text = "money " + money;
    }
    //quest one
    public void Q1()
    {
        if (quest.isActive)
        {
            quest.goal.DishWash();
            if (quest.goal.IsReached())
            {
                money += quest.money;
                quest.Complete();
                txtmoney.text = "money " + money;
            }
        }
    }
    //quest two
    public void Q2()
    {
        if (quest2.isActive)
        {
            quest2.goal.Ok();
            if (quest2.goal.IsReached())
            {
                money += quest2.money;
                quest2.Complete2();
                txtmoney.text = "money " + money;
            }
        }
    }
}
