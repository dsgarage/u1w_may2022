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

    public int GetValue()
    {
        return value.Value;
    }

    public void Dispose()
    {
        value.Dispose();
    }

    public void Init()
    {
        value.Value = -1;
    }
}
