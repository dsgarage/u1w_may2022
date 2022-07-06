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
            Debug.LogError(this + "�͈͊O�̒l���Z�b�g���悤�Ƃ��Ă��܂��I");
        }
    }
}
