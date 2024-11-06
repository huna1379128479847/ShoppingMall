using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public Vector2 buttonPosition; // ボタンの座標を保持する変数

    void Start()
    {
        // ボタンのワールド座標を取得し、2Dの座標として格納
        buttonPosition = new Vector2(transform.position.x, transform.position.y);
    }
}
