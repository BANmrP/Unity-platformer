using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{   
    public int index; //номер скіна
    public int indexOpen = 0; //який скін відкритий
    public int MaxGoods = 1; // скільки скінів(початок з 0)
    //купляні скіни
    public int Skin1 = 1; 
    public int Skin2 = 0;   

    public int GoodIndex = 0; //вибраний скін

    public GameObject Store; 
    public GameObject[] items;
    public GameObject[] BuyButtons;
    public GameObject[] ChooseButtons;
    public GameObject[] ChooseText;

    void Start()
    {
        Store.SetActive(false);

        Skin1 = PlayerPrefs.GetInt("Skin1");
        Skin2 = PlayerPrefs.GetInt("Skin2");
        GoodIndex = PlayerPrefs.GetInt("GoodIndex");

        if (Skin1 == 1)
        {
            BuyButtons[0].SetActive(false);
            ChooseButtons[0].SetActive(true);          
        }

        if (Skin2 == 1)
        {
            BuyButtons[1].SetActive(false);
            ChooseButtons[1].SetActive(true);         
        }

        if (GoodIndex == 0)
        {           
            ChooseButtons[0].SetActive(false);
            ChooseText[0].SetActive(true);
        }

        if (GoodIndex == 1)
        {
            ChooseButtons[1].SetActive(false);
            ChooseText[1].SetActive(true);
        }     
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Store.SetActive(false);
        }
    }

    public void OpenStore()
    {
        Store.SetActive(true);
    }

    public void BuyStoreOne()
    {
        index = 0;
        BuyStore();
    }

    public void BuyStoreTwo()
    {
        index = 1;
        BuyStore();
    }

    public void BuyStore()
    {
        if (index == 0 && Score.coin >= 0)
        {
            Score.coin -= 0;
            Skin1 = 1;
            BuyButtons[index].SetActive(false);
            ChooseButtons[index].SetActive(true);

            PlayerPrefs.SetInt("Skin1", Skin1);
        }

        else if (index == 1 && Score.coin >= 100)
        {
            Score.coin -= 100;
            Skin2 = 1;
            BuyButtons[index].SetActive(false);
            ChooseButtons[index].SetActive(true);

            PlayerPrefs.SetInt("Skin2", Skin2);
        }  
    }

    public void Back()
    {
        if (indexOpen == 0)
        {
            return;
        }
        else
        {
            items[indexOpen].SetActive(false);
            indexOpen--;
            items[indexOpen].SetActive(true);

            PlayerPrefs.SetInt("IndexOpen", indexOpen);
        }
    }

    public void Next()
    {
        if (indexOpen == MaxGoods)
        {
            return;
        }
        else
        {
            items[indexOpen].SetActive(false);
            indexOpen++;
            items[indexOpen].SetActive(true);

            PlayerPrefs.SetInt("IndexOpen", indexOpen);
        }
    }

    public void ChooseOne()
    {
        if (Skin1 == 1)
        {
            ChooseButtons[0].SetActive(false);
            ChooseText[0].SetActive(true);
            ChooseButtons[GoodIndex].SetActive(true);
            ChooseText[GoodIndex].SetActive(false);
          
            GoodIndex = 0;

            PlayerPrefs.SetInt("GoodIndex", GoodIndex);
        }
    }

    public void ChooseTwo()
    {
        if (Skin2 == 1)
        {
            ChooseButtons[1].SetActive(false);
            ChooseText[1].SetActive(true);
            ChooseButtons[GoodIndex].SetActive(true);
            ChooseText[GoodIndex].SetActive(false);
          
            GoodIndex = 1;

            PlayerPrefs.SetInt("GoodIndex", GoodIndex);
        }
    }
}