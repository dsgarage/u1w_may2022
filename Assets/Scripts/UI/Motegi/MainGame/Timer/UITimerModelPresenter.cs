using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITimerModelPresenter : MonoBehaviour
{
    [SerializeField] private UITimerModel uiTimerModel;

    public void SetUITimerValue(float uiTimerValue)
    {
        if (uiTimerValue >= 0)
        {
            uiTimerModel.SetTimerValue(uiTimerValue);
        }
        else
        {
            Debug.LogError(this + "範囲外の値をセットしようとしています！");
        }
    }
}
