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
    int collectionLength = 0;

    void Start()
    {
        handItems.AddTo(this);
    }

    public void SetHandItem(int num,UIItemKind kind)
    {
        handItems[num] = kind;
    }

    public UIItemKind GetHandItem(int num)
    {
        return handItems[num];
    }

    public int GetHandItemsCount()
    {
        return handItems.Count;
    }

    public void SetCollectionLength(int length)
    {
        collectionLength = length;
    }

    public void InitItemCollection()
    {
        for (int i = 0; i < collectionLength; i++)
        {
            handItems.Add(UIItemKind.None);
        }
    }

}
