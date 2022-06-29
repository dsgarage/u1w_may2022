using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class CountDownSystem : MonoBehaviour
{
    [SerializeField] private CountDownModel countDownModel;
    [SerializeField] private int countDownCount;

    public IEnumerator CountDownStart()
    {
        countDownModel.SetValue(countDownCount);
        for (int i = countDownCount; i >= 0; i--)
        {
            yield return new WaitForSeconds(1);
            countDownModel.SetValue(i - 1);
        }
        yield break;
    }
}
