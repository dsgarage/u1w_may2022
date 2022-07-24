using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class ResultScoreDebug : MonoBehaviour
{
    [SerializeField] private ResultScoreModelPresenter resultScoreModelPresenter;
    [SerializeField] private int score;
    void Update()
    {
        resultScoreModelPresenter.SetResultScoreValue(score);
    }
}
