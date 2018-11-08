using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    private int min;
    private float sec;
    private float oldSec;
    public UnityEngine.UI.Text timerText;

    void Start()
    {
        min = 0;
        sec = 0f;
        oldSec = 0f;
    }

    void Update()
    {
        sec += Time.deltaTime;
        if (sec >= 60f)
        {
            min++;
            sec = sec - 60;
        }

        if ((int)sec != (int)oldSec)
        {
            timerText.text = min.ToString("D2") + ":" + ((int)sec).ToString("D2");
        }
        oldSec = sec;
    }
}