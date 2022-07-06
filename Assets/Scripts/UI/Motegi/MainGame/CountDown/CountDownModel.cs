using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class CountDownModel : MonoBehaviour
{
    public IReadOnlyReactiveProperty<int> r_value => value;
    private readonly IntReactiveProperty value = new IntReactiveProperty(999);
    void Start()
    {
        value.AddTo(this);
    }

    public void SetValue(int value)
    {
        this.value.Value = value;
    }


}
