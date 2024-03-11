using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ebac.Core.Singleton;

public class ItemManager : Singleton<ItemManager>
{
    public int coins;
    public TextMeshProUGUI uiScore;

    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coins = 0;
        uiScore.text = "x0";
    }

    public void AddCoins(int amount = 1)
    {
        coins += amount;
        UpdateCoins();
    }
    
    private void UpdateCoins()
    {
        uiScore.text = ("x "+coins.ToString());
    }
}
