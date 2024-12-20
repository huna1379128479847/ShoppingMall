// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class SceneTransitionManager : MonoBehaviour
// {
//     private Player currentPlayer; // 現在の操作対象プレイヤー

//     public void SwitchToScene(string sceneName)
//     {
//         // 次のシーンをロード（Additiveで追加）
//         SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive).completed += operation =>
//         {
//             // 次のシーンでプレイヤーを検索
//             Scene nextScene = SceneManager.GetSceneByName(sceneName);
//             GameObject[] rootObjects = nextScene.GetRootGameObjects();
//             foreach (GameObject obj in rootObjects)
//             {
//                 Player player = obj.GetComponent<Player>();
//                 if (player != null)
//                 {
//                     // 現在のプレイヤーを非アクティブ化
//                     if (currentPlayer != null)
//                     {
//                         currentPlayer.SetActivePlayer(false);
//                     }

//                     // 新しいプレイヤーをアクティブ化
//                     currentPlayer = player;
//                     currentPlayer.SetActivePlayer(true);
//                     break;
//                 }
//             }
//         };
//     }

//     public void ReturnToPreviousScene(string sceneName)
//     {
//         // 元のシーンを取得
//         Scene previousScene = SceneManager.GetSceneByName(sceneName);

//         // 元のシーンのプレイヤーを検索
//         GameObject[] rootObjects = previousScene.GetRootGameObjects();
//         foreach (GameObject obj in rootObjects)
//         {
//             Player player = obj.GetComponent<Player>();
//             if (player != null)
//             {
//                 // 現在のプレイヤーを非アクティブ化
//                 if (currentPlayer != null)
//                 {
//                     currentPlayer.SetActivePlayer(false);
//                 }

//                 // 元のシーンのプレイヤーをアクティブ化
//                 currentPlayer = player;
//                 currentPlayer.SetActivePlayer(true);
//                 break;
//             }
//         }

//         // 移行先のシーンをアンロード
//         SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
//     }
// }
