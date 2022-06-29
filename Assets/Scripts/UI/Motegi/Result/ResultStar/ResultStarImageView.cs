using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultStarImageView : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Sprite enableSprite, disableSprite;
    public void ImageColorUpdate(bool enable)
    {
        if (enable)
        {
            image.sprite = enableSprite;
        }
        else
        {
            image.sprite = disableSprite;
        }
    }
}
