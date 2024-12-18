using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    
    
    // インベントリのリスト
    public List<string> inventory = new List<string>();

    // インベントリにアイテムを追加するメソッド
    public void AddItem(string itemName)
    {
        inventory.Add(itemName);
        
        if(itemName == "Item_Key")
        {
            ItemCheck.Item_Key = true;
            InformationManager.HaveKey = true;
            Debug.Log($"{itemName}をインベントリに追加しました！");
        }

    }

    // インベントリの内容をコンソールに表示
    public void ShowInventory()
    {
        Debug.Log("現在のインベントリ:");
        foreach (var item in inventory)
        {
            Debug.Log(item);
        }
    }
}
