using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandItemDebug : MonoBehaviour
{
    [SerializeField]
    private HandItemModel handItemModel;

    [SerializeField] private UIItemKind[] itemKinds;
    
    void Update()
    {
        for (int i = 0; i < itemKinds.Length; i++)
        {
            handItemModel.SetHandItems(i,itemKinds[i]);
        }
    }
}
