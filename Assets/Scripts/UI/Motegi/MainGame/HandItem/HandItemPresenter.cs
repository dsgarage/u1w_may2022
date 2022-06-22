using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class HandItemPresenter : MonoBehaviour
{
    [SerializeField] private HandItemModel handItemModel;
    [SerializeField] private HandItemViewController handItemViewController;
    void Start()
    {
        handItemModel.InitItemCollection(handItemViewController.GetImageListLength());
        handItemModel.r_handKinds
            .ObserveReplace()
            .Subscribe((CollectionReplaceEvent<UIItemKind> x) =>
            {
                handItemViewController.HandItemImageUpdate(x.Index, x.NewValue);
            })
            .AddTo(this);
    }
}
