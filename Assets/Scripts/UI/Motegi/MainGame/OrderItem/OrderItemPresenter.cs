using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class OrderItemPresenter : MonoBehaviour
{
    [SerializeField] private OrderItemViewController orderItemViewController;
    [SerializeField] private OrderItemModel orderItemModel;
    void Start()
    {
        orderItemModel.InitItemCollection(orderItemViewController.GetImageListLength());
        List<OrderItem> items = orderItemModel.GetOrderItems();
        for (int i = 0; i < items.Count; i++)
        {
            orderItemModel.GetOrderItem(i).r_kind
                .SubscribeWithState(i,(x,n) =>
                {
                    orderItemViewController.OrderItemImageUpdate(x,n);
                })
                .AddTo(this);

            orderItemModel.GetOrderItem(i).r_value
                .SubscribeWithState(i, (x, n) =>
                {
                    orderItemViewController.OrderItemTextUpdate(x,n);
                })
                .AddTo(this);
        }
    }
    
}
