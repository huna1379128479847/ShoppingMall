using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InformationManager : MonoBehaviour
{
    [Header("説明画面")]
        public GameObject No_Data;
        public GameObject Item_Key;
        public GameObject Item_Camera;
        public GameObject Item_Alarm_clock;
        public GameObject Item_Accelerometer;
        public GameObject Item_Throwing_Support;
        public GameObject Item_Loudspeaker;
        public GameObject Item_Salt;
        public GameObject Item_A_cushion_that_ruins_people;
        public GameObject Item_Metal_bat;
        public GameObject Item_Robot_Parts;
        public GameObject Item_Boss_info;


        public GameObject END_1;
        public GameObject END_2;
        public GameObject END_3;
        public GameObject END_4;


    [Header("判定関連")]
        public bool HaveKey = false;
        public bool HaveCamera = false;
        public bool HaveDelayClock = false;
        public bool HaveAccelerometer = false;
        public bool HaveThrowing_Support= false;
        public bool HaveLoudspeaker = false;
        public bool HaveSalt = false;
        public bool HaveA_Cushion_that_ruins_people = false;
        public bool HaveMetal_bat = false;
        public bool HaveRobot_Parts = false;
        public bool HaveBoss_info = false;

        public bool Lock_END_1;
        public bool Lock_END_2;
        public bool Lock_END_3;
        public bool Lock_END_4;

    [Header("テキスト関連")]
        public TextMeshProUGUI Name_key;
        public TextMeshProUGUI Name_Camera;
        public TextMeshProUGUI Name_DelayClock;
        public TextMeshProUGUI Name_Accelerometer;
        public TextMeshProUGUI Name_Throwing_Support;
        public TextMeshProUGUI Name_Loudspeaker;
        public TextMeshProUGUI Name_Salt;
        public TextMeshProUGUI Name_A_cushion_that_ruins_people;
        public TextMeshProUGUI Name_Metal_bat;
        public TextMeshProUGUI Name_Robot_Parts;
        public TextMeshProUGUI Name_Boss_info;

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
    public void OnButtonClicked_DelayClock()
    {
        Display();
        if(HaveDelayClock == true)
        {
            Item_Alarm_clock.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_Accelerometer()
    {
        Display();
        if(HaveAccelerometer == true)
        {
            Item_Accelerometer.SetActive(true);
        }
        else
        {
            No_Data.SetActive(true);
        }
    }
    public void OnButtonClicked_Throwing_Support()
    {
        Display();
        if(HaveThrowing_Support == true)
        {
            Item_Throwing_Support.SetActive(true);
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
    public void OnButtonClicked_A_cushion_that_ruins_people()
    {
        Display();
        if(HaveA_Cushion_that_ruins_people == true)
        {
            Item_A_cushion_that_ruins_people .SetActive(true);
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
    public void OnButtonClicked_Boss_info()
    {
        Display();
        if(HaveBoss_info == true)
        {
            Item_Boss_info.SetActive(true);
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

        if(HaveDelayClock == true)
        {
            Name_DelayClock.text = "【遅延時計】";
        }
        else
        {
            Name_DelayClock.text = "???";
        }

        if(HaveAccelerometer == true)
        {
            Name_Accelerometer.text = "【加速時計】";
        }
        else
        {
            Name_Accelerometer.text = "???";
        }

        if(HaveThrowing_Support == true)
        {
            Name_Throwing_Support.text = "【投擲サポート】";
        }
        else
        {
            Name_Throwing_Support.text = "???";
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

        if(HaveA_Cushion_that_ruins_people == true)
        {
            Name_A_cushion_that_ruins_people.text = "【人をダメにするクッション】";
        }
        else
        {
            Name_A_cushion_that_ruins_people.text = "???";
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

        if(HaveBoss_info == true)
        {
            Name_Boss_info.text = "【ボスの情報】";
        }
        else
        {
            Name_Boss_info.text = "???";
        }
    }
    public void Display()
    {
        Debug.Log("ディスプレイは動いた");
        No_Data.SetActive(false);
        Item_Key.SetActive(false);
        Item_Camera.SetActive(false);
        Item_Alarm_clock.SetActive(false);
        Item_Accelerometer.SetActive(false);
        Item_Throwing_Support.SetActive(false);
        Item_Loudspeaker.SetActive(false);
        Item_Salt.SetActive(false);
        Item_A_cushion_that_ruins_people.SetActive(false);
        Item_Metal_bat.SetActive(false);
        Item_Robot_Parts.SetActive(false);
        Item_Boss_info.SetActive(false);
        END_1.SetActive(false);
        END_2.SetActive(false);
        END_3.SetActive(false);
        END_4.SetActive(false);
    }
}
