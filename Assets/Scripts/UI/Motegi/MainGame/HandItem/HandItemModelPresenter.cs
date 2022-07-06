using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandItemModelPresenter : MonoBehaviour
{
    [SerializeField] private HandItemModel handItemModel;

    public void SetHandItemValue(int handItemIndex, UIItemKind kind)
    {
        if (handItemIndex >= 0 && 0 < handItemModel.GetHandItemsCount())
        {
            handItemModel.SetHandItem(handItemIndex, kind);
        }
        else
        {
            Debug.LogError(this + "範囲外の値をセットしようとしています！");
        }
    }
}
