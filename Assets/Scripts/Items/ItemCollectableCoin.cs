using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollectableCoin : ItemCollectableBase
{
    protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager.instance.AddCoins();
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
    }
}
