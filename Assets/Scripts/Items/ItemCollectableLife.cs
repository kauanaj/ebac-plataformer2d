using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableLife : ItemCollectableBase
{
    protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager.instance.AddLifes();
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
    }
}