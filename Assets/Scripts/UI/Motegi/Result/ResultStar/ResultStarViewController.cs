using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultStarViewController : MonoBehaviour
{
    [SerializeField] private ResultStarImageView[] resultStarImageView;

    public void ImageViewUpdate(int value)
    {
        for (int i = 0; i < resultStarImageView.Length; i++)
        {
            if (i < value)
            {
                resultStarImageView[i].ImageColorUpdate(true);
            }
            else
            {
                resultStarImageView[i].ImageColorUpdate(false);
            }
        }
    }
}
