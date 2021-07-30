using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChannelBar : MonoBehaviour
{
    public GameObject player;
    public GameObject main_bar;
    private bool channelSuccess;
    public float silenceTime_bar;
    public float channelTime_bar;
    public float current_silence;
    public float current_channel;
    public float bar_percent;
    public Color silence_color;
    public Color channel_color;
    public SpriteRenderer Render;

    void Start()
    {
        main_bar.transform.localScale = new Vector3(0, 0, 0);
    }


    // Update is called once per frame
    void Update()
    {
        current_silence = (float) player.GetComponent<Status>().silenceTime;
        current_channel = (float) player.GetComponent<Status>().channelTime;
        channelSuccess = player.GetComponent<Status>().channelSuccess;

        if (silenceTime_bar == 0 && current_silence != 0)
        {
            main_bar.transform.localScale = new Vector3(1, 0.2f, 1);
            Render.color = silence_color;
            silenceTime_bar = current_silence;
        }
        if (channelTime_bar == 0 && current_channel != 0)
        {
            main_bar.transform.localScale = new Vector3(1, 0.2f, 1);
            Render.color = channel_color;
            channelTime_bar = current_channel;
        }

        if (silenceTime_bar != 0 && current_silence != 0)
        {
            bar_percent = current_silence / silenceTime_bar;
            if (bar_percent < 0 | bar_percent > 1)
            {
                main_bar.transform.localScale = new Vector3(0, 0, 0);
                silenceTime_bar = 0;
            }
            transform.localScale = new Vector3(bar_percent, 1, 1);
        }
        if (channelTime_bar != 0 && current_channel != 0)
        {
            bar_percent = current_channel / channelTime_bar;
            if (bar_percent < 0 | bar_percent > 1)
            {
                main_bar.transform.localScale = new Vector3(0, 0, 0);
                channelTime_bar = 0;
            }
            transform.localScale = new Vector3(bar_percent, 1, 1);
        }

        if (silenceTime_bar != 0 && channelSuccess == false)
        {
            main_bar.transform.localScale = new Vector3(0, 0, 0);
            silenceTime_bar = 0;
            transform.localScale = new Vector3(bar_percent, 1, 1);
        }
        if (channelTime_bar != 0 && channelSuccess == false)
        {
            main_bar.transform.localScale = new Vector3(0, 0, 0);
            channelTime_bar = 0;
            transform.localScale = new Vector3(bar_percent, 1, 1);
        }
    }
}
