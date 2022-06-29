using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownViewController : MonoBehaviour
{
    [SerializeField] private CountDownTextView countDownTextView;

    public void TextViewUpdate(int value)
    {
        countDownTextView.TextValueUpdate(value);
    }
}
