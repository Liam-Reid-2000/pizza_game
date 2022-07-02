using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{

    private TextMeshProUGUI pizzaText;

    void Start()
    {
        pizzaText = GetComponent<TextMeshProUGUI>();
    }

    public void SetPizzaText(string pizzaText)
    {
        this.pizzaText.text = pizzaText;
    }
}
