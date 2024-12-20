﻿using System;

namespace BlackOut.GameManage.InputKeys
{
    /// <summary>
    /// キー入力を管理するための列挙型。
    /// KeyTypeHolderとの併用前提
    /// </summary>
    [Flags]
    public enum KeyType
    {
        None = 0,            // キー入力なし
        Confirm = 1 << 0,    // 決定キー
        Cancel = 1 << 1,     // キャンセルキー
        Right = 1 << 2,      // 右キー
        Left = 1 << 3,       // 左キー
        Up = 1 << 4,         // 上キー
        Down = 1 << 5,       // 下キー
    }

    [Flags]
    public enum PressType
    {
        None = 0,
        Down = 1 << 0,
        Up = 1 << 1,
        Keep = 1 << 2,
    }
}
