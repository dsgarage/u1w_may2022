using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultStarModelPresenter : MonoBehaviour
{
    [SerializeField] private ResultStarModel resultStarModel;
    public void SetResultStarValue(int resultStarValue)
    {
        if (resultStarValue > 0 && resultStarValue < 4)
        {
            resultStarModel.SetStars(resultStarValue);
        }
        else
        {
            Debug.LogError(this + "範囲外の値をセットしようとしています！");
        }
    }
    public void Init()
    {
        resultStarModel.SetStars(0);
    }
}
