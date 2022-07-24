using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class ResultScoreViewPresenter : MonoBehaviour
{
    [SerializeField] private ResultScoreModel resultScoreModel;
    [SerializeField] private ResultScoreViewController resultScoreViewController;
    void Start()
    {
        resultScoreModel.r_score
            .Subscribe(x =>
            {
                resultScoreViewController.TextViewUpdate(x);
            })
            .AddTo(this);
    }
}
