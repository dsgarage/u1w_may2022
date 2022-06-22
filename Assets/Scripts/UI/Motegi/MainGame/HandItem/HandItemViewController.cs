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
    //������g����Model��Collection������������
    public int GetImageListLength()
    {
        return handItemImageViews.Length;
    }
}
