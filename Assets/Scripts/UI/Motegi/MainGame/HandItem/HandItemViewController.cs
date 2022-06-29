using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandItemViewController : MonoBehaviour
{
    [SerializeField] private HandItemImageView[] handItemImageViews;

    public void HandItemImageUpdate(int num,UIItemKind kind)
    {
        handItemImageViews[num].ChangeImages(kind);
    }
    //これを使ってModelのCollectionを初期化する
    public int GetImageListLength()
    {
        return handItemImageViews.Length;
    }
}
