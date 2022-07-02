using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateFundsText : MonoBehaviour
{
    private TextMeshProUGUI updateFundsText;
    private bool textVisable = false;
    private float timeSinceTextVisable;
    public float displayTime = 3f;

    void Start()
    {
        updateFundsText = GetComponent<TextMeshProUGUI>();
        updateFundsText.enabled = false;
    }

    // Update is called once per frame
    public void SetUpdateFundsText(string fundsText)
    {
        this.updateFundsText.text = fundsText;
        textVisable = true;
        timeSinceTextVisable = Time.timeSinceLevelLoad;
    }

    public void Update()
    {
        if (textVisable == false)
        {
            updateFundsText.enabled = false;
        } else
        {
            updateFundsText.enabled = true;
        }
        if (textVisable == true && Time.timeSinceLevelLoad > (timeSinceTextVisable + displayTime))
        {
            textVisable = false;
        }
    }
}
