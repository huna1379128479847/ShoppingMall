using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stairs : MonoBehaviour
{
    public Transform playerTransform;  // プレイヤーのTransform

    // 階段移動メソッド
    public void MoveToFloor()
    {
        if (CompareTag("ToSecondFloor"))  // 二階への階段に触れたとき
        {
            SceneManager.LoadScene("Stade2");
            playerTransform.position = new Vector3(0.5f, 22.5f, 0f);
        }

        if(CompareTag("ToFirstFloor"))  // 一階への階段に触れたとき
        {
            SceneManager.LoadScene("Stade1");
            playerTransform.position = new Vector3(6.5f, 28.5f, 0f);
        }

        if(CompareTag("ToThirdFloor"))  // 三階への階段に触れたとき
        {
            SceneManager.LoadScene("Stade3");
            playerTransform.position = new Vector3(14.5f, 5.5f, 0f);
        }
    }
}
