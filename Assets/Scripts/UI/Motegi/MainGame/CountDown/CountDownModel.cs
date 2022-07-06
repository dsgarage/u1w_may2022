using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class CountDownModel : MonoBehaviour
{
    public IReadOnlyReactiveProperty<int> r_value => value;
    private readonly IntReactiveProperty value = new IntReactiveProperty(-1);
    void Start()
    {
        value.AddTo(this);
    }

    public void SetValue(int value)
    {
        this.value.Value = value;
    }

    public void Init()
    {
        value.Value = -1;
    }
}
