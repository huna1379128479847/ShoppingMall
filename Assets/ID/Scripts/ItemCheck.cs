using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ItemCheck
{
    private static bool item_Key = false;
    private static bool item_Camera = false;
    private static bool item_Alarm_clock = false;
    private static bool item_watch = false;
    private static bool item_Ball = false;
    private static bool item_Loudspeaker = false;
    private static bool item_Salt = false;
    private static bool item_Cushion_that_ruins_people = false;
    private static bool item_Metal_bat = false;
    private static bool item_Robot_Parts = false;
    private static bool item_Setting_materials_collection = false;
    private static bool item_Sweets = false;

    public static bool Item_Key
    {
        get
        {
            return item_Key;
        }
        set
        {
            item_Key = value;
        }
    }

    public static bool Item_Camera
    {
        get
        {
            return item_Camera;
        }
        set
        {
            item_Camera = value;
        }
    }

    public static bool Item_Alarm_clock
    {
        get
        {
            return item_Alarm_clock;
        }
        set
        {
            item_Alarm_clock = value;
        }
    }

    public static bool Item_watch
    {
        get
        {
            return item_watch;
        }
        set
        {
            item_watch = value;
        }
    }

    public static bool Item_Ball
    {
        get
        {
            return item_Ball;
        }
        set
        {
            item_Ball = value;
        }
    }

    public static bool Item_Loudspeaker
    {
        get
        {
            return item_Loudspeaker;
        }
        set
        {
            item_Loudspeaker = value;
        }
    }

    public static bool Item_Salt
    {
        get
        {
            return item_Salt;
        }
        set
        {
            item_Salt = value;
        }
    }

    public static bool Item_Cushion_that_ruins_people
    {
        get
        {
            return item_Cushion_that_ruins_people;
        }
        set
        {
            item_Cushion_that_ruins_people = value;
        }
    }

    public static bool Item_Metal_bat
    {
        get
        {
            return item_Metal_bat;
        }
        set
        {
            item_Metal_bat = value;
        }
    }

    public static bool Item_Robot_Parts
    {
        get
        {
            return item_Robot_Parts;
        }
        set
        {
            item_Robot_Parts = value;
        }
    }

    public static bool Item_Setting_materials_collection
    {
        get
        {
            return item_Setting_materials_collection;
        }
        set
        {
            item_Setting_materials_collection = value;
        }
    }

    public static bool Item_Sweets
    {
        get
        {
            return item_Sweets;
        }
        set
        {
            item_Sweets = value;
        }
    }

    public static int GetItemCount()
    {
        int count = 0;

        if (Item_Key) count++;
        if (Item_Camera) count++;
        if (item_Alarm_clock) count++;
        if (item_watch) count++;
        if (Item_Ball) count++;
        if (Item_Loudspeaker) count++;
        if (Item_Salt) count++;
        if (Item_Cushion_that_ruins_people) count++;
        if (Item_Metal_bat) count++;
        if (Item_Robot_Parts) count++;
        if (Item_Setting_materials_collection) count++;
        if (Item_Sweets) count++;

        return count;  // 所持アイテム数を返す
    }
}
