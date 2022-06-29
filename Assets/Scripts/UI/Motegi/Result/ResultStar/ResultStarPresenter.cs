using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class ResultStarPresenter : MonoBehaviour
{
    [SerializeField] private ResultStarViewController resultStarViewController;
    [SerializeField] private ResultStarModel resultStarModel;
    void Start()
    {
        resultStarModel.r_stars
            .Subscribe(x =>
            {
                resultStarViewController.ImageViewUpdate(x);
            })
            .AddTo(this);
    }
}
