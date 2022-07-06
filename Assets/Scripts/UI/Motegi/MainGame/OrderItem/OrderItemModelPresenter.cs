using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderItemModelPresenter : MonoBehaviour
{
    [SerializeField] private OrderItemModel orderItemModel;

    public void SetOrderItemNumValue(int orderItemIndex,int num)
    {
        if (orderItemIndex > 0 && orderItemIndex < orderItemModel.GetOrderItems().Count)
        {
            orderItemModel.GetOrderItem(orderItemIndex).SetValue(num);
        }
    }

    public void SetOrderItemKindValue(int orderItemIndex, UIItemKind kind)
    {
        if (orderItemIndex > 0 && orderItemIndex < orderItemModel.GetOrderItems().Count)
        {
            orderItemModel.GetOrderItem(orderItemIndex).SetKind(kind);
        }
    }
}
