using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemRetention : MonoBehaviour
{
    // Stairsスクリプトを参照
    private Stairs stairsScript;

    private void Start()
    {
        // シーン内のStairsコンポーネントを取得
        stairsScript = FindObjectOfType<Stairs>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))  // プレイヤーが触れたとき
        {
            if (this.gameObject.CompareTag("Key"))  // タグが"Key"の場合
            {
                ItemCheck.Item_Key = true;  // 対応する処理を実行
                DestroyAllItem();  // 他のすべてのアイテムを破壊
                Debug.Log("アイテムを手に入れた！");
            }
        }
    }
    void Update()
    {
        if (ItemCheck.Item_Key)  // キーを持っているとき
        {
            ItemProcess();
        }

        else if (ItemCheck.Item_Camera)  // カメラを持っているとき
        {
            ItemProcess();
        }

        else if (ItemCheck.Item_Alarm_clock)  // 目覚まし時計を持っているとき
        {
            ItemProcess();
        }

        else if (ItemCheck.Item_watch)  // 腕時計を持っているとき
        {
            ItemProcess();
        }

        else if (ItemCheck.Item_Ball)  // を持っているとき
        {
            ItemProcess();
        }

        else if (ItemCheck.Item_Loudspeaker)  // 拡声器を持っているとき
        {
            ItemProcess();
        }

        else if (ItemCheck.Item_Salt)  // 盛り塩を持っているとき
        {
            ItemProcess();
        }

        else if (ItemCheck.Item_Cushion_that_ruins_people)  // クッションを持っているとき
        {
            ItemProcess();
        }

        else if (ItemCheck.Item_Metal_bat)  // 金属バットを持っているとき
        {
            ItemProcess();
        }

        else if (ItemCheck.Item_Robot_Parts)  // ロボットのパーツを持っているとき
        {
            ItemProcess();
        }

        else if (ItemCheck.Item_Setting_materials_collection)  // 設定資料集を持っているとき
        {
            ItemProcess();
        }

        else if (ItemCheck.Item_Sweets)  // お菓子を持っているとき
        {
            ItemProcess();
        }
    }

    void ItemProcess()
    {
        if (CompareTag("stairs"))  // 階段に触れている場合
        {
            stairsScript.MoveToFloor();  //MoveToFloorメソッドの呼び出し
        }
    }

    void DestroyAllItem()
    {
        // タグが"Item"のすべてのオブジェクトを検索
        GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
        foreach (GameObject item in items)
        {
            Destroy(item);  // アイテムオブジェクトを破壊
        }
    }
}
