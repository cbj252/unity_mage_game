using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Status : MonoBehaviour
{
    public int Health;
    public TextMeshProUGUI HealthText;
    public double silenceTime;
    public double rootTime;
    public double channelTime;
    public bool channelSuccess = true;

    void Update()
    {
        HealthText.text = Health.ToString();
        if (silenceTime > 0)
        {
            silenceTime -= Time.deltaTime;
        }
        else if (silenceTime < 0)
        {
            silenceTime = 0f;
        }
        if (rootTime > 0)
        {
            rootTime -= Time.deltaTime;
        }
        else if (rootTime < 0)
        {
            rootTime = 0f;
        }
        if (channelTime > 0)
        {
            channelTime -= Time.deltaTime;
            if (silenceTime > 0)
            {
                channelSuccess = false;
                channelTime = 0;
            }
        }
        else if (channelTime < 0)
        {
            channelTime = 0f;
        }
    }
}

