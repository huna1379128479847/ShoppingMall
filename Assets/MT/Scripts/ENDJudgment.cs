using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ENDJudgment : MonoBehaviour
{
    [SerializeField] private SceneLoadManager END_1;
    [SerializeField] private SceneLoadManager END_2;
    [SerializeField] private SceneLoadManager END_3;
    [SerializeField] private SceneLoadManager END_4;

    private bool END1_Route = false;
    private bool END2_Route = false;
    private bool END3_Route = false;
    private bool END4_Route = false;
    //private bool ENDSecret_Route = false;

    [SerializeField] private GameObject PopUp;
    [SerializeField] private GameObject NO_ENDING;
    [SerializeField] private Button EnterButton;


    public bool Item_Key;
    public bool Item_Salt;
    public bool Item_Setting_materials_collection;

    void Start()
    {
        PopUp.SetActive(false);
        NO_ENDING.SetActive(false);
    }
    public void PopUp_Active()
    {
        PopUp.SetActive(true);
    }
    void Update()
    {
        // if(ItemCheck.Item_Key && ItemCheck.Item_Salt && ItemCheck.Item_Setting_materials_collection == true)  // エンディング1の条件
        // {
        //     END1_Route = true;
        //     END2_Route = false;
        //     END3_Route = false;
        //     END4_Route = false;
        //     Debug.Log("END1ルート");
        // }
        // else if(ItemCheck.Item_Loudspeaker && ItemCheck.Item_Alarm_clock && ItemCheck.watch == true)// エンディング2の条件
        // {
        //     END1_Route = false;
        //     END2_Route = true;
        //     END3_Route = false;
        //     END4_Route = false;
        //     Debug.Log("END2ルート");
        // }
        // else if(ItemCheck.Item_Camera && ItemCheck.Item_Metal_bat && ItemCheck.ball == true)// エンディング3の条件
        // {
        //     END1_Route = false;
        //     END2_Route = false;
        //     END3_Route = true;
        //     END4_Route = false;
        //     Debug.Log("END3ルート");
        // }
        // else if(ItemCheck.Item_Robot_Parts && ItemCheck.Item_A_Cushion_that_ruins_people && ItemCheck.sweets == true)// エンディング4の条件
        // {
        //     END1_Route = false;
        //     END2_Route = false;
        //     END3_Route = false;
        //     END4_Route = true;
        //     Debug.Log("END4ルート");
        // }
        // else if(SecretCount == 20)
        // {
            
        //     END1_Route = true;
        //     END2_Route = false;
        //     END3_Route = false;
        //     END4_Route = false;
        //     ENDSecret_Route = true;
        //     Debug.Log("ENDSecretルート");
        // }

        if(Item_Key && Item_Salt && Item_Setting_materials_collection == true)  // エンディング1の条件
        {
            END1_Route = true;
            END2_Route = false;
            END3_Route = false;
            END4_Route = false;
            Debug.Log("END1ルート");
        }
        else
        {
            Debug.Log("現在該当ENDがありません");
        }
    }
    IEnumerator Hidden_Message()
    {
        yield return new WaitForSeconds(3);
        NO_ENDING.SetActive(false);
        EnterButton.interactable = true;
    }
    public void Judgment()//ON Clickで設定
    {
        if(END1_Route == true)
        {
            END_1.SceneLoad();
        }  
        else if(END2_Route == true)
        {
            END_2.SceneLoad();
        }
        else if(END3_Route == true)
        {
            END_3.SceneLoad();
        }
        else if(END4_Route == true)
        {
            END_4.SceneLoad();
        }
        // else if(ENDSecret_Route == true)
        // {
        //     END_Secret.SceneLoad();
        // }
        else
        {
            NO_ENDING.SetActive(true);
            EnterButton.interactable = false;
            StartCoroutine(Hidden_Message());
        }
    }

    public void NOButton()
    {
        PopUp.gameObject.SetActive(false);
    }

    void KeyJudge()
    {   
        if(PopUp == true)
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                Judgment();
            }
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                PopUp.gameObject.SetActive(false);
            }
        }
    }

}