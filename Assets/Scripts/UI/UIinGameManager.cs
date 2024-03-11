using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ebac.Core.Singleton;

public class UIinGameManager : Singleton<UIinGameManager>
{
    public TextMeshProUGUI uiAmountCoins;

    public static void UpdateTextCoins(string s)
    {
        instance.uiAmountCoins.text = s;
    }
}
