using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class OrderItem
{
    public IReadOnlyReactiveProperty<int> r_value => value;
    private readonly ReactiveProperty<int> value = new ReactiveProperty<int>(0);
    public IReadOnlyReactiveProperty<UIItemKind> r_kind => kind;
    private readonly ReactiveProperty<UIItemKind> kind = new ReactiveProperty<UIItemKind>(UIItemKind.None);

    public OrderItem(UIItemKind kind,int value)
    {
        this.kind.Value = kind;
        this.value.Value = value;
    }

    public UIItemKind GetKind()
    {
        return kind.Value;
    }
    public int GetValue()
    {
        return value.Value;
    }

    public void SetKind(UIItemKind kind)
    {
        this.kind.Value = kind;
    }

    public void SetValue(int value)
    {
        this.value.Value = value;
    }

    public void Dispose()
    {
        value.Dispose();
        kind.Dispose();
    }
}
public class OrderItemModel : MonoBehaviour
{

    private List<OrderItem> orderItems = new List<OrderItem>();
    int collectionLength = 0;

    public OrderItem GetOrderItem(int num)
    {
        return orderItems[num];
    }

    public List<OrderItem> GetOrderItems()
    {
        return orderItems;
    }
    public void SetCollectionLength(int length)
    {
        collectionLength = length;
    }
    public void InitItemCollection()
    {
        for (int i = 0; i < collectionLength; i++)
        {
            orderItems.Add(new OrderItem(UIItemKind.None,i));
        }
    }

    public void Init()
    {
        for (int i = 0; i < orderItems.Count; i++)
        {
            orderItems[i].SetKind(UIItemKind.None);
            orderItems[i].SetValue(0);
        }
    }

    private void OnDestroy()
    {
        foreach (var value in orderItems)
        {
            value.Dispose();
        }
    }
}
