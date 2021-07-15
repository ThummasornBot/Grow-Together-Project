using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootSystem : MonoBehaviour
{
    public GameObject _Roulette01;
    public GameObject _Roulette02;
    public GameObject _SpinItem_Window;
    public GameObject _Joker;
    public GameObject _Money10Bath;
    public GameObject _Food;
    public GameObject _Money50Bath;
    public GameObject _Clothing;
    public GameObject _ClothingInBook;
    public GameObject _SpacialClothing;
    public GameObject _SpacialClothingInBook;

    float SpinNumber;

    public int SpinPrice;

    bool Check;

    bool CheckReceiveItem01 = false;
    bool CheckReceiveItem02 = false;
    bool CheckReceiveItem03 = false;

    public void Spawnner()
    {
        
        if (Player.HappyValue <= 1)
        {
            SpinNumber = Random.Range(1.0f, 100.0f);
            Debug.Log(SpinNumber);
            if (SpinNumber >= 1 && SpinNumber <= 70)
            {
                _Joker.SetActive(true);
                
            }
            else if (SpinNumber > 70 && SpinNumber <= 83)
            {
                CheckReceiveItem01 = true;
                _Money10Bath.SetActive(true);
            }
            else if (SpinNumber > 83 && SpinNumber <= 91)
            {
                CheckReceiveItem02 = true;
                _Food.SetActive(true);
            }
            else if (SpinNumber > 91 && SpinNumber <= 96)
            {
                CheckReceiveItem03 = true;
                _Money50Bath.SetActive(true);
            }
            else if (SpinNumber > 96 && SpinNumber <= 99)
            {
                _Clothing.SetActive(true);
                _ClothingInBook.SetActive(true);
            }
            else if (SpinNumber > 99 && SpinNumber <= 100)
            {
                _SpacialClothing.SetActive(true);
                _SpacialClothingInBook.SetActive(true);
            }
        }
        if (Player.HappyValue > 1 && Player.HappyValue <= 3)
        {
            SpinNumber = Random.Range(1.0f, 100.0f);
            Debug.Log(SpinNumber);
            if (SpinNumber >= 1 && SpinNumber <= 65)
            {
                _Joker.SetActive(true);

            }
            else if (SpinNumber > 65 && SpinNumber <= 79)
            {
                CheckReceiveItem01 = true;
                _Money10Bath.SetActive(true);
            }
            else if (SpinNumber > 79 && SpinNumber <= 88)
            {
                CheckReceiveItem02 = true;
                _Food.SetActive(true);
            }
            else if (SpinNumber > 88 && SpinNumber <= 94)
            {
                CheckReceiveItem03 = true;
                _Money50Bath.SetActive(true);
            }
            else if (SpinNumber > 94 && SpinNumber <= 98)
            {
                _Clothing.SetActive(true);
                _ClothingInBook.SetActive(true);
            }
            else if (SpinNumber > 98 && SpinNumber <= 100)
            {
                _SpacialClothing.SetActive(true);
                _SpacialClothingInBook.SetActive(true);
            }
        }
        if (Player.HappyValue > 3 && Player.HappyValue <= 5)
        {
            SpinNumber = Random.Range(1.0f, 100.0f);
            Debug.Log(SpinNumber);
            if (SpinNumber >= 1 && SpinNumber <= 60)
            {
                _Joker.SetActive(true);

            }
            else if (SpinNumber > 60 && SpinNumber <= 75)
            {
                CheckReceiveItem01 = true;
                _Money10Bath.SetActive(true);
            }
            else if (SpinNumber > 75 && SpinNumber <= 85)
            {
                CheckReceiveItem02 = true;
                _Food.SetActive(true);
            }
            else if (SpinNumber > 85 && SpinNumber <= 92)
            {
                CheckReceiveItem03 = true;
                _Money50Bath.SetActive(true);
            }
            else if (SpinNumber > 92 && SpinNumber <= 98)
            {
                _Clothing.SetActive(true);
                _ClothingInBook.SetActive(true);
            }
            else if (SpinNumber > 98 && SpinNumber <= 100)
            {
                _SpacialClothing.SetActive(true);
                _SpacialClothingInBook.SetActive(true);
            }
        }
        if (Player.HappyValue > 5 && Player.HappyValue <= 7)
        {
            SpinNumber = Random.Range(1.0f, 100.0f);
            Debug.Log(SpinNumber);
            if (SpinNumber >= 1 && SpinNumber <= 55)
            {
                _Joker.SetActive(true);

            }
            else if (SpinNumber > 55 && SpinNumber <= 71)
            {
                CheckReceiveItem01 = true;
                _Money10Bath.SetActive(true);
            }
            else if (SpinNumber > 71 && SpinNumber <= 82)
            {
                CheckReceiveItem02 = true;
                _Food.SetActive(true);
            }
            else if (SpinNumber > 82 && SpinNumber <= 90)
            {
                CheckReceiveItem03 = true;
                _Money50Bath.SetActive(true);
            }
            else if (SpinNumber > 90 && SpinNumber <= 97)
            {
                _Clothing.SetActive(true);
                _ClothingInBook.SetActive(true);
            }
            else if (SpinNumber > 97 && SpinNumber <= 100)
            {
                _SpacialClothing.SetActive(true);
                _SpacialClothingInBook.SetActive(true);
            }
        }
        if (Player.HappyValue > 7 && Player.HappyValue <= 9)
        {
            SpinNumber = Random.Range(1.0f, 100.0f);
            Debug.Log(SpinNumber);
            if (SpinNumber >= 1 && SpinNumber <= 50)
            {
                _Joker.SetActive(true);

            }
            else if (SpinNumber > 50 && SpinNumber <= 67)
            {
                CheckReceiveItem01 = true;
                _Money10Bath.SetActive(true);
            }
            else if (SpinNumber > 67 && SpinNumber <= 80)
            {
                CheckReceiveItem02 = true;
                _Food.SetActive(true);
            }
            else if (SpinNumber > 80 && SpinNumber <= 90)
            {
                CheckReceiveItem03 = true;
                _Money50Bath.SetActive(true);
            }
            else if (SpinNumber > 90 && SpinNumber <= 97)
            {
                _Clothing.SetActive(true);
                _ClothingInBook.SetActive(true);
            }
            else if (SpinNumber > 97 && SpinNumber <= 100)
            {
                _SpacialClothing.SetActive(true);
                _SpacialClothingInBook.SetActive(true);
            }
        }
        if (Player.HappyValue > 9 && Player.HappyValue <= 11)
        {
            SpinNumber = Random.Range(1.0f, 100.0f);
            Debug.Log(SpinNumber);
            if (SpinNumber >= 1 && SpinNumber <= 45)
            {
                _Joker.SetActive(true);

            }
            else if (SpinNumber > 45 && SpinNumber <= 63)
            {
                CheckReceiveItem01 = true;
                _Money10Bath.SetActive(true);
            }
            else if (SpinNumber > 63 && SpinNumber <= 77)
            {
                CheckReceiveItem02 = true;
                _Food.SetActive(true);
            }
            else if (SpinNumber > 77 && SpinNumber <= 89)
            {
                CheckReceiveItem03 = true;
                _Money50Bath.SetActive(true);
            }
            else if (SpinNumber > 89 && SpinNumber <= 96)
            {
                _Clothing.SetActive(true);
                _ClothingInBook.SetActive(true);
            }
            else if (SpinNumber > 96 && SpinNumber <= 100)
            {
                _SpacialClothing.SetActive(true);
                _SpacialClothingInBook.SetActive(true);
            }
        }
        if (Player.HappyValue == 12)
        {
            SpinNumber = Random.Range(1.0f, 100.0f);
            Debug.Log(SpinNumber);
            if (SpinNumber >= 1 && SpinNumber <= 40)
            {
                _Joker.SetActive(true);

            }
            else if (SpinNumber > 40 && SpinNumber <= 59)
            {
                CheckReceiveItem01 = true;
                _Money10Bath.SetActive(true);
            }
            else if (SpinNumber > 59 && SpinNumber <= 75)
            {
                CheckReceiveItem02 = true;
                _Food.SetActive(true);
            }
            else if (SpinNumber > 75 && SpinNumber <= 88)
            {
                CheckReceiveItem03 = true;
                _Money50Bath.SetActive(true);
            }
            else if (SpinNumber > 88 && SpinNumber <= 95)
            {
                _Clothing.SetActive(true);
                _ClothingInBook.SetActive(true);
            }
            else if (SpinNumber > 95 && SpinNumber <= 100)
            {
                _SpacialClothing.SetActive(true);
                _SpacialClothingInBook.SetActive(true);
            }
        }


        if (Player.money >= SpinPrice)
        {
            Check = true;
            _Roulette01.SetActive(false);
            _Roulette02.SetActive(true);
            Player.money -= SpinPrice;
            StartCoroutine(OpenSpinWindow());
        }
        
    }

    public void Close()
    {
        _Roulette01.SetActive(true);
        _Roulette02.SetActive(false);
        _SpinItem_Window.SetActive(false);
        _Joker.SetActive(false);
        _Clothing.SetActive(false);
        _SpacialClothing.SetActive(false);
        if (CheckReceiveItem01 == true)
        {
            _Money10Bath.SetActive(false);
            Player.money += 10;
            CheckReceiveItem01 = false;
        }
        else if (CheckReceiveItem02 == true)
        {
            CheckReceiveItem02 = false;
            _Food.SetActive(false);
            if (Player.HappyValue < Player.maxHappyValue)
            {
                Player.HappyValue += 1;
            }
        }
        else if (CheckReceiveItem03 == true)
        {
            _Money50Bath.SetActive(false);
            Player.money += 50;
            CheckReceiveItem03 = false;
        }
    }

    IEnumerator OpenSpinWindow()
    {
        if (Check == true)
        {
            yield return new WaitForSeconds(2f);
            _Roulette01.SetActive(true);
            _Roulette02.SetActive(false);
            _SpinItem_Window.SetActive(true);
            Check = false;
        }
    }
}
