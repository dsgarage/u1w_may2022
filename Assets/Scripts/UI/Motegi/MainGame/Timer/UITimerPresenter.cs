using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class UITimerPresenter : MonoBehaviour
{
    [SerializeField] private UITimerView uiTimerView;
    [SerializeField] private UITimerModel uiTimerModel;
    void Start()
    {
        uiTimerModel.r_time
            .Subscribe(x => uiTimerView.TimerTextValueUpdate(x))
            .AddTo(this);
    }
}
