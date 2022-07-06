using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderItemModelPresenter : MonoBehaviour
{
    [SerializeField] private OrderItemModel orderItemModel;

    public void SetOrderItemNumValue(int orderItemIndex,int num)
    {
        if (orderItemIndex >= 0 && orderItemIndex < orderItemModel.GetOrderItems().Count)
        {
            orderItemModel.GetOrderItem(orderItemIndex).SetValue(num);
        }
        else
        {
            Debug.LogError(this + "範囲外の値をセットしようとしています！");
        }
    }

    public void SetOrderItemKindValue(int orderItemIndex, UIItemKind kind)
    {
        if (orderItemIndex >= 0 && orderItemIndex < orderItemModel.GetOrderItems().Count)
        {
            orderItemModel.GetOrderItem(orderItemIndex).SetKind(kind);
        }
        else
        {
            Debug.LogError(this + "範囲外の値をセットしようとしています！");
        }
    }

    public void Init()
    {
        for (int i = 0; i < orderItemModel.GetOrderItems().Count; i++)
        {
            orderItemModel.GetOrderItem(i).SetKind(UIItemKind.None);
            orderItemModel.GetOrderItem(i).SetValue(0);
        }
    }

}
