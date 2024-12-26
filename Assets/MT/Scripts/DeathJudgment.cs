using UnityEngine;

public class DeathJudgment : MonoBehaviour
{
    // プレイヤータグを確認するための変数
    [SerializeField] private string playerTag = "Player";
    [SerializeField] private SceneLoadManager GAMEOVER;

    // トリガーに入った時
    private void OnTriggerEnter2D(Collider2D other)
    {
        // プレイヤーと衝突したか確認
        if (other.CompareTag(playerTag))
        {
            Debug.Log("プレイヤーが当たりました！");
            GAMEOVER.SceneLoad();
        }
    }
}
