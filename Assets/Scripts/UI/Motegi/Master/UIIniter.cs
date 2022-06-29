using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIIniter : MonoBehaviour
{
    [SerializeField] private CountDownModel countDownModel;
    [SerializeField] private UITimerSystem uiTimerSystem;
    [SerializeField] private HandItemModel handItemModel;
    [SerializeField] private OrderItemModel orderItemModel;
    [SerializeField] private ResultScoreModel resultScoreModel;
    [SerializeField] private ResultStarModel resultStarModel;

    public void CountDownInit()
    {
        countDownModel.Init();
    }

    public void MainPanelInit()
    {
        uiTimerSystem.TimerInit();
        handItemModel.Init();
        orderItemModel.Init();
    }

    public void ResultInit()
    {
        resultStarModel.Init();
        resultScoreModel.Init();
    }
}
