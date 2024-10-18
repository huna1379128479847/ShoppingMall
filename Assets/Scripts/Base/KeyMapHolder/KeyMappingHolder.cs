using System.Collections.Generic;
using UnityEngine;
using Helpers;

namespace BlackOut.GameManage.InputKeys
{
    /// <summary>
    /// KeyTypeとKeyCodeのマッピングを管理し、特定のキーが押されたかどうかを確認するためのクラス。
    /// ゲーム内でのキー入力の確認やカスタムマッピングに使用する。
    /// </summary>
    public static class KeyMappingHolder
    {
        // KeyTypeとKeyCodeのマッピング (複数のKeyCodeを1つのKeyTypeに関連付ける)
        private static Dictionary<KeyType, List<KeyCode>> inputKeyType = new Dictionary<KeyType, List<KeyCode>>();
        private readonly static Dictionary<KeyType, KeyCode> defaultKeyType = new Dictionary<KeyType, KeyCode>()
        {
            { KeyType.Confirm, KeyCode.Z },
            { KeyType.Cancel, KeyCode.X},
            { KeyType.Up, KeyCode.UpArrow },
            { KeyType.Down, KeyCode.DownArrow },
            { KeyType.Right, KeyCode.RightArrow },
            { KeyType.Left, KeyCode.LeftArrow }
        };

        public static Dictionary<KeyType, List<KeyCode>> InputKeyType => inputKeyType;
        /// <summary>
        /// Confirmキーが押されているかどうかを確認するメソッド。
        /// KeyType.Confirmに関連付けられたキーが押されていればtrueを返す。
        /// </summary>
        public static bool IsPressConfirmKey(PressType type = PressType.Down)
        {
            return Check(KeyType.Confirm, type);
        }

        /// <summary>
        /// Cancelキーが押されているかどうかを確認するメソッド。
        /// KeyType.Cancelに関連付けられたキーが押されていればtrueを返す。
        /// </summary>
        public static bool IsPressCancelKey(PressType type = PressType.Down)
        {
            return Check(KeyType.Cancel, type);
        }

        public static List<KeyType> CheckPressAllowKeys(PressType type = PressType.Down)
        {
            List<KeyType> result = new List<KeyType>();
            if (Check(KeyType.Up, type)) result.Add(KeyType.Up);
            if (Check(KeyType.Down, type)) result.Add(KeyType.Down);
            if (Check(KeyType.Left, type)) result.Add(KeyType.Left);
            if (Check(KeyType.Right, type)) result.Add(KeyType.Right);
            return result;
        }
        /// <summary>
        /// 指定されたKeyTypeに関連するキーが押されているかどうかを確認する内部メソッド。
        /// </summary>
        /// <param name="type">確認するKeyType (例: Confirm, Cancel)</param>
        /// <returns>対応するKeyCodeが押されていればtrue。</returns>
        private static bool Check(KeyType type, PressType pressType)
        {
            if (!inputKeyType.TryGetValue(type, out List<KeyCode> keys))
            {
                return Input.GetKeyDown(defaultKeyType[type]);
            }
            // リスト内のすべてのキーに対して、キーが押されたかどうかを確認
            foreach (var key in keys)
            {
                if (Check(key, pressType)) return true;
            }
            return false;
        }

        private static bool Check(KeyCode key, PressType pressType)
        {
            if (FLGHelper.FLGCheck((uint)pressType, (uint)PressType.Down) && Input.GetKeyDown(key) ||
                FLGHelper.FLGCheck((uint)pressType, (uint)PressType.Keep) && Input.GetKey(key) ||
                FLGHelper.FLGCheck((uint)pressType, (uint)PressType.Up) && Input.GetKeyUp(key))
            {
                return true;
            }
            return false;
        }
    }
}
