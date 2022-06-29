using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class HandItemPresenter : MonoBehaviour
{
    [SerializeField] private HandItemModel handItemModel;
    [SerializeField] private HandItemViewController handItemViewController;

    private void Awake()
    {
        handItemModel.SetCollectionLength(handItemViewController.GetImageListLength());
        handItemModel.InitItemCollection();
    }

    void Start()
    {
        handItemModel.r_handKinds
            .ObserveReplace()
            .Subscribe(x =>
            {
                handItemViewController.HandItemImageUpdate(x.Index, x.NewValue);
            })
            .AddTo(this);
        Init();

    }

    void Init()
    {
        int length = handItemModel.r_handKinds.Count;
        for (int i = 0; i < length; i++)
        {
            handItemViewController.HandItemImageUpdate(i,UIItemKind.None);
        }
    }
}
