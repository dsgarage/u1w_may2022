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
    //‚±‚ê‚ğg‚Á‚ÄModel‚ÌCollection‚ğ‰Šú‰»‚·‚é
    public int GetImageListLength()
    {
        return handItemImageViews.Length;
    }
}
