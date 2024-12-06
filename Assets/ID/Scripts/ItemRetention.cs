using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemRetention : MonoBehaviour
{
    void Update()
    {
        if(ItemCheck.Item_Key)  // キーを持っているとき
        {
            CompareTag("stairs");  // 階段に触れている場合
            DestroyAllItem();  // 他のすべてのアイテムを破壊
        }

        if(ItemCheck.Item_Camera)  // カメラを持っているとき
        {
            CompareTag("stairs");  // 階段に触れている場合
            DestroyAllItem();  // 他のすべてのアイテムを破壊
        }

        if(ItemCheck.Item_DelayClock)  // 目覚まし時計を持っているとき
        {
            CompareTag("stairs");  // 階段に触れている場合
            DestroyAllItem();  // 他のすべてのアイテムを破壊
        }

        if(ItemCheck.Item_Accelerometer)  // 腕時計を持っているとき
        {
            CompareTag("stairs");  // 階段に触れている場合
            DestroyAllItem();  // 他のすべてのアイテムを破壊
        }

        if(ItemCheck.Item_Throwing_Support)  // を持っているとき
        {
            CompareTag("stairs");  // 階段に触れている場合
            DestroyAllItem();  // 他のすべてのアイテムを破壊
        }

        if(ItemCheck.Item_Loudspeaker)  // 拡声器を持っているとき
        {
            CompareTag("stairs");  // 階段に触れている場合
            DestroyAllItem();  // 他のすべてのアイテムを破壊
        }

        if(ItemCheck.Item_Salt)  // 盛り塩を持っているとき
        {
            CompareTag("stairs");  // 階段に触れている場合
            DestroyAllItem();  // 他のすべてのアイテムを破壊
        }

        if(ItemCheck.Item_A_cushion_that_ruins_people)  // クッションを持っているとき
        {
            CompareTag("stairs");  // 階段に触れている場合
            DestroyAllItem();  // 他のすべてのアイテムを破壊
        }

        if(ItemCheck.Item_Metal_bat)  // 金属バットを持っているとき
        {
            CompareTag("stairs");  // 階段に触れている場合
            DestroyAllItem();  // 他のすべてのアイテムを破壊
        }

        if(ItemCheck.Item_Robot_Parts)  // ロボットのパーツを持っているとき
        {
            CompareTag("stairs");  // 階段に触れている場合
            DestroyAllItem();  // 他のすべてのアイテムを破壊
        }

        if(ItemCheck.Item_Boss_info)  // 設定資料集を持っているとき
        {
            CompareTag("stairs");  // 階段に触れている場合
            DestroyAllItem();  // 他のすべてのアイテムを破壊
        }

        if(ItemCheck.Item_Sweets)  // お菓子を持っているとき
        {
            CompareTag("stairs");  // 階段に触れている場合
            DestroyAllItem();  // 他のすべてのアイテムを破壊
        }
    }

    void DestroyAllItem()
    {
        // タグが"Item"のすべてのオブジェクトを検索
        GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
        foreach(GameObject item in items)
        {
            Destroy(item);  // アイテムオブジェクトを破壊
        }
    }
}
