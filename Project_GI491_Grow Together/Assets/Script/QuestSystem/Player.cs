using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public bool Checkquest1 = false;//เช็คให้ปุ่มทำเควสทำงาน
    public bool haveQuest;
    public bool lateSleep;
    public bool lateLateSleep;
    public int maxQuest = 3;
    public int currentQuest;

    public static int money = 99999;
    public string moneytxt;
    public Text txtmoney;
    public Text TextHappy;
    public static int HappyValue;
    public static int maxHappyValue = 12;

    public Quest quest;
    public Quest quest2;

    private void Start()
    {
        haveQuest = false;
    }

    public void Update()
    {
        TextHappy.text = "" + HappyValue;
        txtmoney.text = "" + money;
        Quest1Button();
    }

    public void NextDay()
    {
        currentQuest = 0;
    }

    public void Quest1Button()//ปุ่มกดให้เควสทำงาน
    {
        if (Input.GetKeyDown(KeyCode.Space) && Checkquest1 == true) 
        {
            quest.CheckButton = true;
            QuestWash();
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Quest"))
        {
            Checkquest1 = true;
            quest.CheckButton = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Quest"))
        {
            Checkquest1 = false;
            quest.CheckButton = false;
        }
    }

    //quest 
    public void QuestWash()
    {
        if (quest.isActive)
        {
            quest.goal.DishWash();
            if (quest.goal.IsReached())
            {
                money += quest.money;
                quest.Complete();
            }
        }
    }
    public void QuestWater()
    {
        if (quest.isActive)
        {
            quest.goal.Water();
            if (quest.goal.IsReached())
            {
                money += quest.money;
                quest.Complete();
                txtmoney.text = "Money " + money;
            }
        }
    }

    public void QuestBrush()
    {
        if (quest.isActive)
        {
            quest.goal.Brush();
            if (quest.goal.IsReached())
            {
                money += quest.money;
                quest.Complete();
                txtmoney.text = "Money " + money;
            }
        }
    }
    public void QuestBath()
    {
        if (quest.isActive)
        {
            quest.goal.Bath();
            if (quest.goal.IsReached())
            {
                money += quest.money;
                quest.Complete();
                txtmoney.text = "Money " + money;
            }
        }
    }

    public void QuestBuy()
    {
        if (quest.isActive)
        {
            quest.goal.Buy();
            if (quest.goal.IsReached())
            {
                money += quest.money;
                quest.Complete();
                txtmoney.text = "Money " + money;
            }
        }
    }
    public void QuestEat()
    {
        if (quest.isActive)
        {
            quest.goal.Eat
();
            if (quest.goal.IsReached())
            {
                money += quest.money;
                quest.Complete();
                txtmoney.text = "Money " + money;
            }
        }
    }
    public void QuestRub()
    {
        if (quest.isActive)
        {
            quest.goal.Rub();
            if (quest.goal.IsReached())
            {
                money += quest.money;
                quest.Complete();
                txtmoney.text = "Money " + money;
            }
        }
    }

    public void QuestPick()
    {
        if (quest.isActive)
        {
            quest.goal.Pick();
            if (quest.goal.IsReached())
            {
                money += quest.money;
                quest.Complete();
                txtmoney.text = "Money " + money;
            }
        }
    }
    public void QuestSweep()
    {
        if (quest.isActive)
        {
            quest.goal.Sweep();
            if (quest.goal.IsReached())
            {
                money += quest.money;
                quest.Complete();
                txtmoney.text = "Money " + money;
            }
        }
    }
}
