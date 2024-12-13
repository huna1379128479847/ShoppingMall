using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemRetention : MonoBehaviour
{
    // Stairsスクリプトを参照
    private Stairs stairsScript;

    // アイテムタグと対応する処理を辞書で管理
    private Dictionary<string, System.Action> itemActions;

    private void Start()
    {
        // シーン内のStairsコンポーネントを取得
        stairsScript = FindObjectOfType<Stairs>();

        // アイテムタグと対応する処理を辞書で管理
        itemActions = new Dictionary<string, System.Action>()
        {
            {"Key" , () => ItemCheck.Item_Key = true},
            {"Camera" , () => ItemCheck.Item_Camera = true},
            {"Alarm_clock" , () => ItemCheck.Item_Alarm_clock = true},
            {"watch" , () => ItemCheck.Item_watch = true},
            {"Ball" , () => ItemCheck.Item_Ball = true},
            {"Loudspeaker" , () => ItemCheck.Item_Loudspeaker = true},
            {"Salt" , () => ItemCheck.Item_Salt = true},
            {"Cushion" , () => ItemCheck.Item_Cushion_that_ruins_people = true},
            {"Metal_bat" , () => ItemCheck.Item_Metal_bat = true},
            {"Robot_Parts" , () => ItemCheck.Item_Robot_Parts = true},
            {"Setting_materials" , () => ItemCheck.Item_Setting_materials_collection = true},
            {"Sweets" , () => ItemCheck.Item_Sweets = true},
        };
    }

    public void ItemGet(Collider other)
    {

            if (itemActions.ContainsKey(other.tag))
            {
                itemActions[other.tag]();  // 対応する処理を実行
                Destroy(other.gameObject);  // アイテムを破壊
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
            DestroyAllItem();  // 他のすべてのアイテムを破壊
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
