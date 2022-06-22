using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandItemImageView : MonoBehaviour
{
    //Ç±Ç±ÇÃêîÇ™ModelÇÃCollectionÇÃêîÇ…Ç»ÇÈ
    [SerializeField] Image vegetableImage;
    [SerializeField,Tooltip("0:Potate 1:Corn 2:Tomato 3:Watermelon")] List<Sprite> vegetableSprites;

    public void ChangeImages(UIItemKind kind)
    {
        switch (kind)
        {
            case UIItemKind.None:
                vegetableImage.sprite = null;
                vegetableImage.color = Color.clear;
                break;
            case UIItemKind.Potate:
                vegetableImage.sprite = vegetableSprites[0];
                vegetableImage.color = Color.white;
                break;
            case UIItemKind.Corn:
                vegetableImage.sprite = vegetableSprites[1];
                vegetableImage.color = Color.white;
                break;
            case UIItemKind.Tomato:
                vegetableImage.sprite = vegetableSprites[2];
                vegetableImage.color = Color.white;
                break;
            case UIItemKind.Watermelon:
                vegetableImage.sprite = vegetableSprites[3];
                vegetableImage.color = Color.white;
                break;
        }
    }

}
