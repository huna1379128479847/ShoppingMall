using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EntityMove : MonoBehaviour
{
    private int randomNumber;
    public Transform EntityObject;
    public Transform East;
    public Transform West;
    public Transform South;
    public Transform North;

    void Start()
    {
        MoveRandom(); // 最初にランダムな移動を決定
    }

    void MoveRandom()
    {
        randomNumber = Random.Range(1, 5); // 1～4の範囲
        Move(); // ランダムに決めた方向に移動
    }

    void Move()
    {
        Vector3 newPosition = EntityObject.transform.position; // 現在の位置を取得

        if (randomNumber == 1) // 東（x+1）
        {
            // Eastがwallタグに触れているか確認
            if (East.GetComponent<Collider2D>().IsTouchingLayers(LayerMask.GetMask("wall")))
            {
                randomNumber = Random.Range(1, 5); // wallに触れていれば再度ランダムに方向を選び直す
                Move(); // 再帰ではなく、Moveを呼び直して方向を決め直す
            }
            else
            {
                newPosition += new Vector3(1f, 0f, 0f); // 東に移動
                EntityObject.transform.DOMove(newPosition, 1f); // 現在地から移動
            }
        }
        else if (randomNumber == 2) // 西（x-1）
        {
            if (West.GetComponent<Collider2D>().IsTouchingLayers(LayerMask.GetMask("wall")))
            {
                randomNumber = Random.Range(1, 5); // wallに触れていれば再度ランダムに方向を選び直す
                Move(); // 再帰ではなく、Moveを呼び直して方向を決め直す
            }
            else
            {
                newPosition += new Vector3(-1f, 0f, 0f); // 西に移動
                EntityObject.transform.DOMove(newPosition, 3f); // 現在地から移動
            }
        }
        else if (randomNumber == 3) // 南（y-1）
        {
            if (South.GetComponent<Collider2D>().IsTouchingLayers(LayerMask.GetMask("wall")))
            {
                randomNumber = Random.Range(1, 5); // wallに触れていれば再度ランダムに方向を選び直す
                Move(); // 再帰ではなく、Moveを呼び直して方向を決め直す
            }
            else
            {
                newPosition += new Vector3(0f, -1f, 0f); // 南に移動
                EntityObject.transform.DOMove(newPosition, 3f); // 現在地から移動
            }
        }
        else if (randomNumber == 4) // 北（y+1）
        {
            if (North.GetComponent<Collider2D>().IsTouchingLayers(LayerMask.GetMask("wall")))
            {
                randomNumber = Random.Range(1, 5); // wallに触れていれば再度ランダムに方向を選び直す
                Move(); // 再帰ではなく、Moveを呼び直して方向を決め直す
            }
            else
            {
                newPosition += new Vector3(0f, 1f, 0f); // 北に移動
                EntityObject.transform.DOMove(newPosition, 1f); // 現在地から移動
            }
        }
    }
}
