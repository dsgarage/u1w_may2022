using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderItemDebug : MonoBehaviour
{
    [SerializeField] private OrderItemModelPresenter orderItemModelPresenter;
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
                orderItemModelPresenter.SetOrderItemKindValue(i,orderItemKinds[i]);
                orderItemModelPresenter.SetOrderItemNumValue(i,orderItemValues[i]);
            }
        }
    }
}
