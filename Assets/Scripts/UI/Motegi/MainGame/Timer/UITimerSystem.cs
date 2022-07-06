using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITimerSystem : MonoBehaviour
{
    [SerializeField] private UITimerModelPresenter uiTimerModelPresenter;
    [SerializeField] private float maxTime = 60;
    [SerializeField] private bool isTimerOn = false;
    private float time = 0;

    private void Awake()
    {
        time = maxTime;
        uiTimerModelPresenter.SetUITimerValue(time);
    }
    
    void Update()
    {
        if (isTimerOn)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                time = 0;
                TimerStop();
                uiTimerModelPresenter.SetUITimerValue(time);
            }
            else
            {
                uiTimerModelPresenter.SetUITimerValue(time);
            }
        }
    }
    public void TimerStop()
    {
        isTimerOn = false;
    }

    public void TimerStart()
    {
        isTimerOn = true;
    }

    public void TimerInit()
    {
        time = maxTime;
        uiTimerModelPresenter.SetUITimerValue(time);
    }
}
