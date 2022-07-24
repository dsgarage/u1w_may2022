using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultScoreViewController : MonoBehaviour
{
    [SerializeField] private ResultScoreTextView resultScoreTextView;

    public void TextViewUpdate(int value)
    {
        resultScoreTextView.TextValueUpdate(value);
    }
}
