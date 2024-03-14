using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ebac.Core.Singleton;

public class ItemManager : Singleton<ItemManager>
{
    public SOInt coins;
    public SOInt lifes;
    
    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coins.value = 0;
        lifes.value = 0;
        //UpdateCoins();
    }

    public void AddCoins(int amount = 1)
    {
        coins.value += amount;
        //UpdateCoins();
    }

    public void AddLifes(int amount = 1)
    {
        lifes.value += amount;
    }

    private void UpdateCoins()
    {
        //UIinGameManager.UpdateTextCoins(coins.ToString());
    }
}
