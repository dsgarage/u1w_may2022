using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class CountDownSystem : MonoBehaviour
{
    [SerializeField] private CountDownModelPresenter countDownModelPresenter;
    [SerializeField] private int countDownCount;

    public IEnumerator CountDownStart()
    {
        countDownModelPresenter.SetCountDownValue(countDownCount);
        for (int i = countDownCount; i >= 0; i--)
        {
            yield return new WaitForSeconds(1);
            if(i == 0)yield break;
            countDownModelPresenter.SetCountDownValue(i - 1);
        }
        yield break;
    }
}
