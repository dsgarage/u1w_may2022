using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug_ON_OFF : MonoBehaviour
{
    /// <summary>
    /// Debug_ON_OFF_Data�̃A�Z�b�g�f�[�^
    /// </summary>
    private static Debug_ON_OFF_Data asset;

    /// <summary>
    /// ScriptableObject�̃f�[�^��
    /// </summary>
    private static readonly string DATA_NAME = "Debug_ON_OFF_Data";

    /// <summary>
    /// �f�o�b�O���
    /// </summary>
    public enum DebugType
    {
        /// <summary>
        /// �f�o�b�O���[�h
        /// </summary>
        DebugMode,
    }

    /// <summary>
    /// �f�o�b�O�@�\��ON/OFF���擾
    /// </summary>
    /// <param name="_debugType"></param>
    /// <returns></returns>
    public static bool GetDebugActive(DebugType _debugType)
    {
        // Debug_ON_OFF_Data���擾
        asset = Resources.Load(DATA_NAME) as Debug_ON_OFF_Data;

        // �A�Z�b�g�������ꍇ
        if (asset == null)
            return false;

        switch (_debugType)
        {
            case DebugType.DebugMode: return asset.debugMode;

            default: return false;
        }
    }
}