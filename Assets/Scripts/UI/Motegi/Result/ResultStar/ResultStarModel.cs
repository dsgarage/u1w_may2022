using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class ResultStarModel : MonoBehaviour
{
    public IReadOnlyReactiveProperty<int> r_stars => stars;
    private readonly IntReactiveProperty stars = new IntReactiveProperty(0);
    void Start()
    {
        stars.AddTo(this);
    }

    public void SetStars(int value)
    {
        stars.Value = value;
    }

    public int GetStars()
    {
        return stars.Value;
    }

    public void Dispose()
    {
        stars.Dispose();
    }
}
