using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderItemDebug : MonoBehaviour
{
    [SerializeField] private OrderItemModel orderItemModel;
    [SerializeField] private GameObject panelObj;
    [SerializeField] private int[] orderItemValues;
    [SerializeField] private UIItemKind[] orderItemKinds;


    // Update is called once per frame
    void Update()
    {
        if (panelObj.activeSelf)
        {
            for (int i = 0; i < orderItemValues.Length; i++)
            {
                orderItemModel.GetOrderItem(i).SetKind(orderItemKinds[i]);
                orderItemModel.GetOrderItem(i).SetValue(orderItemValues[i]);
            }
        }
    }
}
