// using UnityEngine;

// public class PlayerMovement : MonoBehaviour
// {
//     public GameObject player;
//     private int playerX = 0;
//     private int playerY = 0;

//     public void MovePlayer(ButtonController button)
//     {
//         int deltaX = Mathf.Abs(button.x - playerX);
//         int deltaY = Mathf.Abs(button.y - playerY);

//         if ((deltaX == 1 && deltaY == 0) || (deltaX == 0 && deltaY == 1))
//         {
//             player.transform.position = button.transform.position;
//             playerX = button.x;
//             playerY = button.y;
//         }
//         else
//         {
//             Debug.Log("隣接するボタンのみ移動可能です。");
//         }
//     }
// }
