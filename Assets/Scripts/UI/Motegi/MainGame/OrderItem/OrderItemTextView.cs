using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OrderItemTextView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI numText;

    public void NumTextValueUpdate(int num)
    {
        if (num <= 0)
        {
            numText.text = "";
        }
        else
        {
            numText.text = num.ToString();
        }
    }
}
