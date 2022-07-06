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
            Debug.LogError(this + "�͈͊O�̒l���Z�b�g���悤�Ƃ��Ă��܂��I");
        }
    }
    public void Init()
    {
        resultScoreModel.SetScore(0);
    }
}
