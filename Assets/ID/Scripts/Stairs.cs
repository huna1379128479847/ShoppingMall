using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Stairs : MonoBehaviour
{
    public Transform player;

    // 階段移動メソッド
    public void MoveToFloor()
    {
        
        if (ItemCheck.GetItemCount()>= 1)  // 二階への階段に触れたとき 1-2 3-2
        {
        {
            player.transform.position = new Vector3(1,1,1);
        }
        }

        if (ItemCheck.GetItemCount() >= 2)  // 一階への階段に触れたとき かつアイテムを持っていたとき 2-1
        {
            SceneManager.LoadScene("Stage1");
            
        }

        if (CompareTag("ToThirdFloor") && ItemCheck.GetItemCount() >= 2)  // 三階への階段に触れたとき かつアイテムを持っていたとき 2-3
        {
            SceneManager.LoadScene("Stage3", LoadSceneMode.Additive);
        }

    }
    
}
