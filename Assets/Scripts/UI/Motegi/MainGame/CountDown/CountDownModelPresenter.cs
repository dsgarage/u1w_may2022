using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownModelPresenter : MonoBehaviour
{
    [SerializeField] private CountDownModel countDownModel;

    public void SetCountDownValue(int countDownValue)
    {
        if (countDownValue >= 0)
        {
            countDownModel.SetValue(countDownValue);
        }
        else
        {
            Debug.LogError(this + "�͈͊O�̒l���Z�b�g���悤�Ƃ��Ă��܂��I");
        }
    }
    public void Init()
    {
        countDownModel.SetValue(999);
    }
}
