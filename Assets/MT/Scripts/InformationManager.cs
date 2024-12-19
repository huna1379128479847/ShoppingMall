using TMPro;
using UnityEngine;

public class InformationManager : MonoBehaviour
{
    #region "宣言"
    [Header("説明画面")]
        public GameObject No_Data;
        public GameObject Item_Key;
        public GameObject Item_Camera;
        public GameObject Item_Alarm_clock;
        public GameObject Item_Watch;
        public GameObject Item_Ball;
        public GameObject Item_Loudspeaker;
        public GameObject Item_Salt;
        public GameObject Item_Cushion_that_ruins_people;
        public GameObject Item_Metal_bat;
        public GameObject Item_Robot_Parts;
        public GameObject Item_Setting_materials_collection;
        public GameObject Item_Sweets;

        public GameObject END_0;
        public GameObject END_1;
        public GameObject END_2;
        public GameObject END_3;
        public GameObject END_4;
        public GameObject GAMEOVER;


    [Header("判定関連")]
        public static bool HaveKey = false;
        public static bool HaveCamera = false;
        public static bool HaveAlarm_clock = false;
        public static bool HaveWatch = false;
        public static bool HaveBall= false;
        public static bool HaveLoudspeaker = false;
        public static bool HaveSalt = false;
        public static bool HaveCushion_that_ruins_people = false;
        public static bool HaveMetal_bat = false;
        public static bool HaveRobot_Parts = false;
        public static bool HaveSetting_materials_collection = false;
        public static bool HaveSweets = false;

        public bool Lock_END_0;
        public bool Lock_END_1;
        public bool Lock_END_2;
        public bool Lock_END_3;
        public bool Lock_END_4;
        public bool Lock_GAMEOVER;

    [Header("テキスト関連")]
        public TextMeshProUGUI Name_key;
        public TextMeshProUGUI Name_Camera;
        public TextMeshProUGUI Name_Alarm_clock;
        public TextMeshProUGUI Name_watch;
        public TextMeshProUGUI Name_Ball;
        public TextMeshProUGUI Name_Loudspeaker;
        public TextMeshProUGUI Name_Salt;
        public TextMeshProUGUI Name_Cushion_that_ruins_people;
        public TextMeshProUGUI Name_Metal_bat;
        public TextMeshProUGUI Name_Robot_Parts;
        public TextMeshProUGUI Name_Setting_materials_collection;
        public TextMeshProUGUI Nsme_Sweets;
    #endregion

    void Start()
    {
        NameChange();
        Display();
    }
    void Update()
    {
        NameChange();
    }
    public void OnButtonClicked_key()
    {
        Display();
        if(HaveKey == true)
        {
            Item_Key.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_Camera()
    {
        Display();
        if(HaveCamera == true)
        {
            Item_Camera.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_Alarm_clock()
    {
        Display();
        if(HaveAlarm_clock == true)
        {
            Item_Alarm_clock.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_watch()
    {
        Display();
        if(HaveWatch == true)
        {
            Item_Watch.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_Ball()
    {
        Display();
        if(HaveBall == true)
        {
            Item_Ball.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_Loudspeaker()
    {
        Display();
        if(HaveLoudspeaker == true)
        {
            Item_Loudspeaker .SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_Salt()
    {
        Display();
        if(HaveSalt == true)
        {
            Item_Salt .SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_Cushion_that_ruins_people()
    {
        Display();
        if(HaveCushion_that_ruins_people == true)
        {
            Item_Cushion_that_ruins_people .SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_Metal_bat()
    {
        Display();
        if(HaveMetal_bat == true)
        {
            Item_Metal_bat.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_Robot_Parts()
    {
        Display();
        if(HaveRobot_Parts == true)
        {
            Item_Robot_Parts.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_Setting_materials_collection()
    {
        Display();
        if(HaveSetting_materials_collection == true)
        {
            Item_Setting_materials_collection.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_Sweets()
    {
        Display();
        if(HaveSweets == true)
        {
            Item_Sweets.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_END__0()
    {
        Display();
        if(Lock_END_0 == true)
        {
            END_0.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_END__1()
    {
        Display();
        if(Lock_END_1 == true)
        {
            END_1.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_END__2()
    {
        Display();
        if(Lock_END_2 == true)
        {
            END_2.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_END__3()
    {
        Display();
        if(Lock_END_3 == true)
        {
            END_3.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_END__4()
    {
        Display();
        if(Lock_END_4 == true)
        {
            END_4.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_GAMEOVER()
    {
        Display();
        if(Lock_GAMEOVER == true)
        {
            GAMEOVER.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    void NameChange()
    {
        if(HaveKey == true)
        {
            Name_key.text = "【シャッターの鍵】";
        }
        else
        {
            Name_key.text = "???";
        }

        if(HaveCamera == true)
        {
            Name_Camera.text = "【カメラ】";
        }
        else
        {
            Name_Camera.text = "???";
        }

        if(HaveAlarm_clock == true)
        {
            Name_Alarm_clock.text = "【遅延時計】";
        }
        else
        {
            Name_Alarm_clock.text = "???";
        }

        if(HaveWatch == true)
        {
            Name_watch.text = "【加速時計】";
        }
        else
        {
            Name_watch.text = "???";
        }

        if(HaveBall == true)
        {
            Name_Ball.text = "【ボール】";
        }
        else
        {
            Name_Ball.text = "???";
        }

        if(HaveLoudspeaker == true)
        {
            Name_Loudspeaker.text = "【拡声器】";
        }
        else
        {
            Name_Loudspeaker.text = "???";
        }

        if(HaveSalt == true)
        {
            Name_Salt.text = "【盛り塩の塊】";
        }
        else
        {
            Name_Salt.text = "???";
        }

        if(HaveCushion_that_ruins_people == true)
        {
            Name_Cushion_that_ruins_people.text = "【人をダメにするクッション】";
        }
        else
        {
            Name_Cushion_that_ruins_people.text = "???";
        }

        if(HaveMetal_bat == true)
        {
            Name_Metal_bat.text = "【金属バット】";
        }
        else
        {
            Name_Metal_bat.text = "???";
        }

        if(HaveRobot_Parts == true)
        {
            Name_Robot_Parts.text = "【ロボのパーツ】";
        }
        else
        {
            Name_Robot_Parts.text = "???";
        }

        if(HaveSetting_materials_collection == true)
        {
            Name_Setting_materials_collection.text = "【設定資料集】";
        }
        else
        {
            Name_Setting_materials_collection.text = "???";
        }

        if(HaveSweets == true)
        {
            Nsme_Sweets.text = "【お菓子】";
        }
        else
        {
            Nsme_Sweets.text = "???";
        }
    }
    public void Display()
    {
        Debug.Log("ディスプレイは動いた");
        No_Data.SetActive(false);
        Item_Key.SetActive(false);
        Item_Camera.SetActive(false);
        Item_Alarm_clock.SetActive(false);
        Item_Watch.SetActive(false);
        Item_Ball.SetActive(false);
        Item_Loudspeaker.SetActive(false);
        Item_Salt.SetActive(false);
        Item_Cushion_that_ruins_people.SetActive(false);
        Item_Metal_bat.SetActive(false);
        Item_Robot_Parts.SetActive(false);
        Item_Setting_materials_collection.SetActive(false);
        Item_Sweets.SetActive(false);
        END_0.SetActive(false);
        END_1.SetActive(false);
        END_2.SetActive(false);
        END_3.SetActive(false);
        END_4.SetActive(false);
        GAMEOVER.SetActive(false);
    }
}
