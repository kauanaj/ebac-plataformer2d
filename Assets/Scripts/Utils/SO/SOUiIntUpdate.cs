using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SOUiIntUpdate : MonoBehaviour
{
    public SOInt soIntCoins;
    public SOInt soIntLifes;
    public TextMeshProUGUI uiTextCoins;
    public TextMeshProUGUI uiTextLifes;

    // Start is called before the first frame update
    void Start()
    {
        uiTextCoins.text = soIntCoins.value.ToString();
        uiTextLifes.text = soIntLifes.value.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        uiTextCoins.text = soIntCoins.value.ToString();
        uiTextLifes.text = soIntLifes.value.ToString();
    }
}
