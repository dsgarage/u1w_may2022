using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public enum UIItemKind
{
    None = 0,
    Potate = 1,
    Corn = 2,
    Tomato = 3,
    Watermelon = 4,
}
public class HandItemModel : MonoBehaviour
{
    public IReadOnlyReactiveCollection<UIItemKind> r_handKinds => handItems;
    private readonly ReactiveCollection<UIItemKind> handItems = new ReactiveCollection<UIItemKind>();

    void Start()
    {
        handItems.AddTo(this);
    }

    public void SetHandItems(int num,UIItemKind kind)
    {
        handItems[num] = kind;
    }

    public UIItemKind GetHandItems(int num)
    {
        return handItems[num];
    }

    public void InitItemCollection(int num)
    {
        for (int i = 0; i < num; i++)
        {
            handItems.Add(UIItemKind.None);
        }
    }
}
