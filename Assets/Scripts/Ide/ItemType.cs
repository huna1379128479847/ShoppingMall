using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// アイテムの種類を定義する列挙型
public enum ItemTypeEnum
{
    Key,
    Camera,
    Alarm_clock,
    watch,
    Ball,
    Loudspeaker,
    Salt,
    Cushion_that_ruins_people,
    Metal_bat,
    Robot_Parts,
    Setting_materials_collection,
    Sweets
}

public class ItemType : MonoBehaviour
{
    // アイテムの種類を選択
    public ItemTypeEnum itemtype;
}
