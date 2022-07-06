using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class OrderItemViewPresenter : MonoBehaviour
{
    [SerializeField] private OrderItemViewController orderItemViewController;
    [SerializeField] private OrderItemModel orderItemModel;

    private void Awake()
    {
        orderItemModel.SetCollectionLength(orderItemViewController.GetImageListLength());
        orderItemModel.InitItemCollection();
    }

    void Start()
    {
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
