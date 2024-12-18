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

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // タグが"Item"であることを確認
            if (CompareTag("Item"))
            {
                Debug.Log("アイテムに触れた");
                // アイテムの種類を判定する
                ItemType itemTypeComponent = this.gameObject.GetComponent<ItemType>();
                if (itemTypeComponent != null)
                {
                    switch (itemTypeComponent.itemtype)
                    {
                        case ItemTypeEnum.Key:
                            ItemCheck.Item_Key = true;
                            Debug.Log("鍵を手に入れた");
                            break;

                        case ItemTypeEnum.Camera:
                            ItemCheck.Item_Camera = true;
                            Debug.Log("カメラを手に入れた");
                            break;

                        case ItemTypeEnum.Alarm_clock:
                            ItemCheck.Item_Alarm_clock = true;
                            Debug.Log("目覚まし時計を手に入れた");
                            break;

                        case ItemTypeEnum.watch:
                            ItemCheck.Item_watch = true;
                            Debug.Log("腕時計を手に入れた");
                            break;

                        case ItemTypeEnum.Ball:
                            ItemCheck.Item_Ball = true;
                            Debug.Log("ボールを手に入れた");
                            break;

                        case ItemTypeEnum.Loudspeaker:
                            ItemCheck.Item_Loudspeaker = true;
                            Debug.Log("拡声器を手に入れた");
                            break;

                        case ItemTypeEnum.Salt:
                            ItemCheck.Item_Salt = true;
                            Debug.Log("盛り塩を手に入れた");
                            break;

                        case ItemTypeEnum.Cushion_that_ruins_people:
                            ItemCheck.Item_Cushion_that_ruins_people = true;
                            Debug.Log("クッションを手に入れた");
                            break;

                        case ItemTypeEnum.Metal_bat:
                            ItemCheck.Item_Metal_bat = true;
                            Debug.Log("金属バットを手に入れた");
                            break;

                        case ItemTypeEnum.Robot_Parts:
                            ItemCheck.Item_Robot_Parts = true;
                            Debug.Log("ロボットのパーツを手に入れた");
                            break;

                        case ItemTypeEnum.Setting_materials_collection:
                            ItemCheck.Item_Setting_materials_collection = true;
                            Debug.Log("設定資料集を手に入れた");
                            break;

                        case ItemTypeEnum.Sweets:
                            ItemCheck.Item_Sweets = true;
                            Debug.Log("お菓子を手に入れた");
                            break;
                    }
                    // アイテムを破壊
                    DestroyAllItem();
                }
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
