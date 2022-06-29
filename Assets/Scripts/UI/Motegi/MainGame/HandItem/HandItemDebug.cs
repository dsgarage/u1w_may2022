using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandItemDebug : MonoBehaviour
{
    [SerializeField]
    private HandItemModel handItemModel;
    [SerializeField] private GameObject panelObj;
    [SerializeField] private UIItemKind[] itemKinds;
    
    void Update()
    {
        if (panelObj.activeSelf)
        {
            for (int i = 0; i < itemKinds.Length; i++)
            {
                handItemModel.SetHandItems(i, itemKinds[i]);
            }
        }
    }
}
