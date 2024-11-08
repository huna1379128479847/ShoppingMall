using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private float gridSize = 1.0f; // マス目のサイズ
    [SerializeField] private string obstacleTag = "Obstacle"; // 移動を妨げるオブジェクトのタグ

    private Vector3 targetPos;

    private void Start()
    {
        // 初期位置をターゲット位置に設定
        targetPos = transform.position;
    }

    void Update()
    {
        // 左クリックが押された場合の処理
        if (Input.GetMouseButtonDown(0))
        {
            // マウス位置を取得し、ワールド座標に変換
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.WorldToScreenPoint(transform.position).z;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

            // マス目の位置にスナップさせる
            Vector3 snappedPos = GetSnappedPosition(worldPos);

            // クリック位置に障害物がないか確認
            if ((Mathf.Approximately(transform.position.x, snappedPos.x) ||
                 Mathf.Approximately(transform.position.y, snappedPos.y)) &&
                !IsObstacleAtClickedPosition(snappedPos))
            {
                targetPos = snappedPos;
            }
        }

        // プレイヤーがターゲット位置に向かって移動
        Move(targetPos);
    }

    private Vector3 GetSnappedPosition(Vector3 position)
    {
        // マス目の位置にスナップ
        float x = Mathf.Round(position.x / gridSize) * gridSize;
        float y = Mathf.Round(position.y / gridSize) * gridSize;
        return new Vector3(x, y, position.z);
    }

    private bool IsObstacleAtClickedPosition(Vector3 position)
    {
        // クリック位置に指定タグのオブジェクトがあるかチェック
        Collider2D collider = Physics2D.OverlapPoint(position);
        return collider != null && collider.CompareTag(obstacleTag);
    }

    private void Move(Vector3 targetPosition)
    {
        // 現在位置からターゲット位置へ移動
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, _speed * Time.deltaTime);
    }
}
