using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class ResultScoreDebug : MonoBehaviour
{
    [SerializeField] private ResultScoreModel resultScoreModel;
    [SerializeField] private int score;
    void Update()
    {
        resultScoreModel.SetScore(score);
    }
}
