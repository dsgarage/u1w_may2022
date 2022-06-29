using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDownTextView : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI text;

    public void TextValueUpdate(int value)
    {
        text.text = value.ToString();
    }
}
