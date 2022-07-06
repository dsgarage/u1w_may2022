using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultScoreModelPresenter : MonoBehaviour
{
    [SerializeField] private ResultScoreModel resultScoreModel;
    public void SetResultScoreValue(int resultScoreValue)
    {
        if (resultScoreValue >= 0)
        {
            resultScoreModel.SetScore(resultScoreValue);
        }
        else
        {
            Debug.LogError(this + "範囲外の値をセットしようとしています！");
        }
    }
    public void Init()
    {
        resultScoreModel.SetScore(0);
    }
}
