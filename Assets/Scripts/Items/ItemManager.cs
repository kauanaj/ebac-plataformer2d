using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ebac.Core.Singleton;

public class ItemManager : Singleton<ItemManager>
{
    public SOInt coins;
    
    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coins.value = 0;
        //UpdateCoins();
    }

    public void AddCoins(int amount = 1)
    {
        coins.value += amount;
        //UpdateCoins();
    }
    
    private void UpdateCoins()
    {
        //UIinGameManager.UpdateTextCoins(coins.ToString());
    }
}
