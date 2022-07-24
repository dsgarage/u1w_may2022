using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class UITimerModel : MonoBehaviour
{
    public IReadOnlyReactiveProperty<float> r_time => time;
    private readonly FloatReactiveProperty time = new FloatReactiveProperty(999);

    void Start()
    {
        time.AddTo(this);
    }

    public void SetTimerValue(float value)
    {
        time.Value = value;
    }
}
