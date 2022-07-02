using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerFundsText : MonoBehaviour
{
    private TextMeshProUGUI fundsText;

    void Start()
    {
        fundsText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void SetFundsText(string fundsText)
    {
        this.fundsText.text = fundsText;
    }
}
