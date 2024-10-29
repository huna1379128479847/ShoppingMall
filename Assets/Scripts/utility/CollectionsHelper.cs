﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

namespace BlackOut.Utility
{
    /// <summary>
    /// ゲーム内で使う汎用的なヘルパーメソッドをまとめたクラス。
    /// </summary>
    public static class CollectionsHelper
    {
        /// <summary>
        /// リストからランダムに1つの要素を選ぶ。
        /// </summary>
        /// <typeparam name="T">リストの要素の型。</typeparam>
        /// <param name="values">要素を持つリスト。</param>
        /// <returns>ランダムに選ばれた要素。リストが空またはnullの場合はデフォルト値を返す。</returns>
        public static T RandomPick<T>(List<T> values)
        {
            if (values == null || values.Count == 0) return default;
            return values[UnityEngine.Random.Range(0, values.Count)];
        }

        /// <summary>
        /// 辞書の値からランダムに1つの要素を選ぶ。
        /// </summary>
        /// <typeparam name="T">辞書のキーの型。</typeparam>
        /// <typeparam name="V">辞書の値の型。</typeparam>
        /// <param name="values">要素を持つ辞書。</param>
        /// <returns>ランダムに選ばれた値。辞書が空またはnullの場合はデフォルト値を返す。</returns>
        public static V RandomPick<T, V>(Dictionary<T, V> values)
        {
            if (values == null || values.Count == 0) return default;
            return values.Values.ElementAt(UnityEngine.Random.Range(0, values.Count));
        }

        /// <summary>
        /// 辞書の値をリストに変換する。
        /// </summary>
        /// <typeparam name="T">辞書のキーの型。</typeparam>
        /// <typeparam name="V">辞書の値の型。</typeparam>
        /// <param name="values">辞書。</param>
        /// <returns>辞書の全ての値を持つリスト。</returns>
        public static List<V> DictionaryToList<T, V>(Dictionary<T, V> values)
        {
            return values.Values.ToList();
        }

        public static bool TryChangeType<T, V>(T item, out V result)
        where T : class // T はクラス型であることを指定
        where V : class, T // V はクラス型で、かつ T の派生型（または同じ型）であることを指定
        {
            result = null;
            if (item is V)
            {
                // item を V 型にキャストする
                result = item as V;
                return true; // キャスト成功
            }
            return false; // キャスト失敗
        }

    }
}
