using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderItemViewController : MonoBehaviour
{
    [SerializeField] private OrderItemImageView[] orderItemImageViews;
    [SerializeField] private OrderItemTextView[] orderItemTextViews;

    public void OrderItemTextUpdate(int numValue,int itemNum)
    {
        orderItemTextViews[itemNum].NumTextValueUpdate(numValue);
    }
    public void OrderItemImageUpdate(UIItemKind kind, int itemNum)
    {
        orderItemImageViews[itemNum].vegetacleImageSpriteUpdate(kind);
    }
    //これを使ってModelのCollectionを初期化する
    public int GetImageListLength()
    {
        return orderItemImageViews.Length;
    }
}
