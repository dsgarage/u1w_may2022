using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug_ON_OFF : MonoBehaviour
{
    /// <summary>
    /// Debug_ON_OFF_Dataのアセットデータ
    /// </summary>
    private static Debug_ON_OFF_Data asset;

    /// <summary>
    /// ScriptableObjectのデータ名
    /// </summary>
    private static readonly string DATA_NAME = "Debug_ON_OFF_Data";

    /// <summary>
    /// デバッグ種類
    /// </summary>
    public enum DebugType
    {
        /// <summary>
        /// デバッグモード
        /// </summary>
        DebugMode,
    }

    /// <summary>
    /// デバッグ機能のON/OFFを取得
    /// </summary>
    /// <param name="_debugType"></param>
    /// <returns></returns>
    public static bool GetDebugActive(DebugType _debugType)
    {
        // Debug_ON_OFF_Dataを取得
        asset = Resources.Load(DATA_NAME) as Debug_ON_OFF_Data;

        // アセットが無い場合
        if (asset == null)
            return false;

        switch (_debugType)
        {
            case DebugType.DebugMode: return asset.debugMode;

            default: return false;
        }
    }
}