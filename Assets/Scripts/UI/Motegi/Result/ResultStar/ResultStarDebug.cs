using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultStarDebug : MonoBehaviour
{
    [SerializeField] private ResultStarModel resultStarModel;
    [SerializeField] private int value;

    void Update()
    {
        resultStarModel.SetStars(value);
    }
}
