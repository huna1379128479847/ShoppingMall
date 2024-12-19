using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Stairs : MonoBehaviour
{
    public GameObject player;  // プレイヤー

    // 階段移動メソッド
    public void MoveToFloor()
    {
        
        if (ItemCheck.GetItemCount()>= 1)  // 二階への階段に触れたとき 1-2 3-2
        {
            if(SceneManager.GetSceneByName("Stage3").isLoaded)
            {
                SceneManager.UnloadSceneAsync("Stage3");
            }
            else if(SceneManager.GetSceneByName("Stage2").isLoaded)
            {
                SceneManager.UnloadSceneAsync("Stage2");
            }
            else 
            {
                SceneManager.LoadScene("Stage2", LoadSceneMode.Additive);
                player.SetActive(false);
                player.SetActive(true);
        }
        }

        if (ItemCheck.GetItemCount() >= 1)  // 一階への階段に触れたとき かつアイテムを持っていたとき 2-1
        {
            SceneManager.UnloadSceneAsync("Stage2");
            
        }

        if (CompareTag("ToThirdFloor") && ItemCheck.GetItemCount() >= 2)  // 三階への階段に触れたとき かつアイテムを持っていたとき 2-3
        {
            SceneManager.LoadScene("Stage3", LoadSceneMode.Additive);
        }

    }
    
}
