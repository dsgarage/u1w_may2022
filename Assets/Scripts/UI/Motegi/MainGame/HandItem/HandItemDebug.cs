using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandItemDebug : MonoBehaviour
{
    [SerializeField]
    private HandItemModelPresenter handItemModelPresenter;
    [SerializeField] private GameObject panelObj;
    [SerializeField] private UIItemKind[] itemKinds;
    
    void Update()
    {
        if (panelObj.activeSelf)
        {
            for (int i = 0; i < itemKinds.Length; i++)
            {
                handItemModelPresenter.SetHandItemValue(i,itemKinds[i]);
            }
        }
    }
}
