using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public enum UILoopState
{
    Title = 0,
    CountDown = 1,
    Main = 2,
    Result = 3,
}
public class GameUILoop : MonoBehaviour
{
    [SerializeField] private GameObject titleCanvasObj, mainGameCanvasObj, resultCanvasObj;
    [SerializeField] private GameObject mainUIPanelObj, countDownUIPanelObj;
    private readonly ReactiveProperty<UILoopState> state = new ReactiveProperty<UILoopState>(UILoopState.Title);
    [SerializeField] private CountDownModel countDownModel;
    [SerializeField] private CountDownSystem countDownSystem;
    [SerializeField] private UITimerModel uiTimerModel;
    [SerializeField] private UITimerSystem uiTimerSystem;
    [SerializeField] private UIIniter uiIniter;
    void Start()
    {
        titleCanvasObj.SetActive(true);
        state.Subscribe(x =>
        {
            AllObjOff();
            switch (x)
                {
                    case UILoopState.Title:
                        titleCanvasObj.SetActive(true);
                        break;
                    case UILoopState.CountDown:
                        mainGameCanvasObj.SetActive(true);
                        mainUIPanelObj.SetActive(false);
                        countDownUIPanelObj.SetActive(true);
                        //countdown init
                        uiIniter.CountDownInit();
                        //countdown start
                        StartCoroutine(countDownSystem.CountDownStart());
                        break;
                    case UILoopState.Main:
                        mainGameCanvasObj.SetActive(true);
                        mainUIPanelObj.SetActive(true);
                        countDownUIPanelObj.SetActive(false);
                        //MainPanel init
                        uiIniter.MainPanelInit();
                        //timer start
                    uiTimerSystem.TimerStart();
                        break;
                    case UILoopState.Result:
                        resultCanvasObj.SetActive(true);
                        //result init
                        uiIniter.ResultInit();
                    break;
                    default:
                        break;
                }
            })
            .AddTo(this);

        countDownModel.r_value
            .Where(x => x == 0)
            .Subscribe(_ =>
            {
                //CountDown Finished
                state.Value = UILoopState.Main;
            })
            .AddTo(this);
        uiTimerModel.r_time
            .Where(x => x == 0)
            .Subscribe(_ =>
            {
                //LimitTime Finished
                state.Value = UILoopState.Result;
            })
            .AddTo(this);
    }

    void AllObjOff()
    {
        titleCanvasObj.SetActive(false);
        mainGameCanvasObj.SetActive(false);
        resultCanvasObj.SetActive(false);
        mainUIPanelObj.SetActive(false);
        countDownUIPanelObj.SetActive(false);
    }

    public void OnGameStart()
    {
        //StartButton Pressed
        state.Value = UILoopState.CountDown;
    }

    public void OnRetry()
    {
        //retryButton Pressed
        state.Value = UILoopState.CountDown;
    }

    public void OnTitle()
    {
        //TitleButton Pressed
        state.Value = UILoopState.Title;
    }
}
