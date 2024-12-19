using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private ENDJudgment endjudgment;
    [SerializeField] private Stairs stairs;
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private float gridSize = 1.0f; // マス目のサイズ
    [SerializeField] private string obstacleTag = "Wall"; // 移動を妨げるオブジェクトのタグ
    [SerializeField] private string exitTag = "EXIT"; // EXITオブジェクトのタグ
    [SerializeField] private string stage1Tag = "ToFirstFloor"; // 1階に移動するタグ
    [SerializeField] private string stage2Tag = "ToSecondFloor"; // 2階に移動するタグ
    [SerializeField] private string stage3Tag = "ToThirdFloor"; // 3階に移動するタグ

    private Vector3 targetPos;
    private Inventory inventoryManager;

    private void Start()
    {
        // 初期位置をターゲット位置に設定
        targetPos = transform.position;

        // InventoryManagerを取得
        inventoryManager = FindObjectOfType<Inventory>();
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

            // EXITタグのチェック
            if (IsExitAtClickedPosition(snappedPos))
            {
                ExecuteExitAction();
            }
            // アイテムタグのチェック
            else if (IsItemAtClickedPosition(snappedPos, out Collider2D itemCollider))
            {
                AddItemToInventory(itemCollider);
            }
            else if (IsStageAtClickedPosition(snappedPos))
            {
                stageAction();
            }
            // 障害物（Wall）タグのチェック
            else if ((Mathf.Approximately(transform.position.x, snappedPos.x) || Mathf.Approximately(transform.position.y, snappedPos.y))
                    && !IsObstacleAtClickedPosition(snappedPos))
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
        // クリック位置に障害物タグ（Wall）のオブジェクトがあるかチェック
        Collider2D collider = Physics2D.OverlapPoint(position);
        return collider != null && collider.CompareTag(obstacleTag);
    }

    private bool IsExitAtClickedPosition(Vector3 position)
    {
        // クリック位置にEXITタグのオブジェクトがあるかチェック
        Collider2D collider = Physics2D.OverlapPoint(position);
        return collider != null && collider.CompareTag(exitTag);
    }

private bool IsStageAtClickedPosition(Vector3 position)
{
    // クリック位置のコライダーを取得
    Collider2D collider = Physics2D.OverlapPoint(position);
    
    // colliderがnullの場合はfalseを返す
    if (collider == null)
    {
        return false;
    }

    // colliderのタグをチェック
    return collider.CompareTag(stage1Tag) || 
            collider.CompareTag(stage2Tag) || 
            collider.CompareTag(stage3Tag);
}


    private bool IsItemAtClickedPosition(Vector3 position, out Collider2D itemCollider)
    {
        // クリック位置にアイテムタグのオブジェクトがあるかチェック
        itemCollider = Physics2D.OverlapPoint(position);
        return itemCollider != null && itemCollider.tag.StartsWith("Item");
    }

    private void AddItemToInventory(Collider2D itemCollider)
    {
        // アイテムをインベントリに追加
        string itemName = itemCollider.tag; // アイテム名はタグを利用
        inventoryManager.AddItem(itemName);

        // アイテムをシーンから削除または非表示にする
        itemCollider.gameObject.SetActive(false);
    }

    private void ExecuteExitAction()
    {
        // EXITがクリックされたときに実行する処理
        Debug.Log("EXITがクリックされました！処理を実行します。");
        endjudgment.popUp_Active();
    }

    private void Move(Vector3 targetPosition)
    {
        // 現在位置からターゲット位置へ移動
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, _speed * Time.deltaTime);
    }
    private void stageAction()
    {
        Debug.Log("階段がクリックされました。 処理を実行します。");
        stairs.MoveToFloor();
    }
}
