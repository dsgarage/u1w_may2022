using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIIniter : MonoBehaviour
{
    [SerializeField] private CountDownModelPresenter countDownModelPresenter;
    [SerializeField] private UITimerSystem uiTimerSystem;
    [SerializeField] private HandItemModelPresenter handItemModelPresenter;
    [SerializeField] private OrderItemModelPresenter orderItemModelPresenter;
    [SerializeField] private ResultScoreModelPresenter resultScoreModelPresenter;
    [SerializeField] private ResultStarModelPresenter resultStarModelPresenter;

    public void CountDownInit()
    {
        countDownModelPresenter.Init();
    }

    public void MainPanelInit()
    {
        uiTimerSystem.TimerInit();
        handItemModelPresenter.Init();
        orderItemModelPresenter.Init();
    }

    public void ResultInit()
    {
        resultStarModelPresenter.Init();
        resultScoreModelPresenter.Init();
    }
}
