using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class CountDownViewPresenter : MonoBehaviour
{
    [SerializeField] private CountDownViewController countDownViewController;
    [SerializeField] private CountDownModel countDownModel;
    void Start()
    {
        countDownModel.r_value
            .Subscribe(x =>
            {
                countDownViewController.TextViewUpdate(x);
            })
            .AddTo(this);
    }
}
