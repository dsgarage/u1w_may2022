using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITimerView : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI timerText;

    public void TimerTextValueUpdate(float value)
    {
        string st = value.ToString("F2");
        st = st.Replace('.', ':');
        if (st.Length < 5)st = st.Insert(0, "0");
        timerText.text = st;
    }
}
