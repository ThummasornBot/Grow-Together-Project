using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public bool Checkquest1 = false;//เช็คให้ปุ่มทำเควสทำงาน
    public bool haveQuest;
    public int maxQuest = 3;
    public int currentQuest;

    public static int money = 0;
    public string moneytxt;
    public Text txtmoney;
    public Text TextHappy;
    public static int HappyValue;

    public Quest quest;
    public Quest quest2;

    private void Start()
    {
        haveQuest = false;
    }

    public void Update()
    {
        TextHappy.text = "HappyValue :" + HappyValue;
        txtmoney.text = "Money :" + money;
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
            Q1();
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
                txtmoney.text = "Money " + money;
            }
        }
    }
}
