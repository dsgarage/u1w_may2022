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
            Debug.LogError(this + "範囲外の値をセットしようとしています！");
        }
    }
    public void Init()
    {
        countDownModel.SetValue(999);
    }
}
