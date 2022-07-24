using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultStarDebug : MonoBehaviour
{
    [SerializeField] private ResultStarModelPresenter resultStarModelPresenter;
    [SerializeField] private int value;

    void Update()
    {
        resultStarModelPresenter.SetResultStarValue(value);
    }
}
