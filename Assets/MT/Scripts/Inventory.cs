using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // インベントリのリスト
    public  static List<string> inventory = new List<string>();

    // インベントリにアイテムを追加する
    public void AddItem(string itemName)
    {
        inventory.Add(itemName);

    switch(itemName)
    {
        case "Item_Key": //|インベントリにアイテム「Key」が入ったとき
            ItemCheck.Item_Key = true;
            InformationManager.HaveKey = true;
            Debug.Log($"{itemName}をインベントリに追加しました！");
            break;

        case "Item_Camera": //|インベントリにアイテム「Camera」が入ったとき
            ItemCheck.Item_Camera = true;
            InformationManager.HaveCamera = true;
            Debug.Log($"{itemName}をインベントリに追加しました！");
            break;

        case "Item_Alarm_clock": //|インベントリにアイテム「」が入ったとき
            ItemCheck.Item_Alarm_clock = true;
            InformationManager.HaveAlarm_clock = true;
            Debug.Log($"{itemName}をインベントリに追加しました！");
            break;

        case "Item_Watch": //|インベントリにアイテム「」が入ったとき
            ItemCheck.Item_Watch = true;
            InformationManager.HaveWatch = true;
            Debug.Log($"{itemName}をインベントリに追加しました！");
            break;

        case "Item_Ball": //|インベントリにアイテム「」が入ったとき
            ItemCheck.Item_Ball = true;
            InformationManager.HaveBall = true;
            Debug.Log($"{itemName}をインベントリに追加しました！");            
            break;

        case "Item_Loudspeaker": //|インベントリにアイテム「」が入ったとき
            ItemCheck.Item_Loudspeaker = true;
            InformationManager.HaveLoudspeaker = true;
            Debug.Log($"{itemName}をインベントリに追加しました！");
            break;

        case "Item_Salt": //|インベントリにアイテム「」が入ったとき
            ItemCheck.Item_Salt = true;
            InformationManager.HaveSalt = true;
            Debug.Log($"{itemName}をインベントリに追加しました！");
            break;

        case "Item_Cushion_that_ruins_people": //|インベントリにアイテム「」が入ったとき
            ItemCheck.Item_Cushion_that_ruins_people = true;
            InformationManager.HaveCushion_that_ruins_people = true;
            Debug.Log($"{itemName}をインベントリに追加しました！");
            break;

        case "Item_Metal_bat": //|インベントリにアイテム「」が入ったとき
            ItemCheck.Item_Metal_bat = true;
            InformationManager.HaveMetal_bat = true;
            Debug.Log($"{itemName}をインベントリに追加しました！");            
            break;

        case "Item_Robot_Parts": //|インベントリにアイテム「」が入ったとき
            ItemCheck.Item_Robot_Parts = true;
            InformationManager.HaveRobot_Parts = true;
            Debug.Log($"{itemName}をインベントリに追加しました！");
            break;

        case "Item_Setting_materials_collection": //|インベントリにアイテム「」が入ったとき
            ItemCheck.Item_Setting_materials_collection = true;
            InformationManager.HaveSetting_materials_collection = true;
            Debug.Log($"{itemName}をインベントリに追加しました！");
            break;

        case "Item_Sweets": //|インベントリにアイテム「」が入ったとき
            ItemCheck.Item_Sweets = true;
            InformationManager.HaveSweets = true;
            Debug.Log($"{itemName}をインベントリに追加しました！");            
            break;
    }

    }

    // インベントリの内容をコンソールに表示
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("現在のインベントリ:");
            foreach (var item in inventory)
            {
                Debug.Log(item);
            }
        }

    }

}
