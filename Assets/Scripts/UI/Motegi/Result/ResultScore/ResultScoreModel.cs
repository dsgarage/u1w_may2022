using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class ResultScoreModel : MonoBehaviour
{
    public IReadOnlyReactiveProperty<int> r_score => score;
    private readonly IntReactiveProperty score = new IntReactiveProperty(0);

    public void SetScore(int value)
    {
        score.Value = value;
    }

    public int GetScore(int value)
    {
        return score.Value;
    }

    public void Dispose()
    {
        score.Dispose();
    }
}
