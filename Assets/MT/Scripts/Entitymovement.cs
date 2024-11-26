using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class EntityMovement : MonoBehaviour
{
    [SerializeField] private Collider2D eastCollider;  // 2D コライダーに変更
    [SerializeField] private Collider2D westCollider;  // 2D コライダーに変更
    [SerializeField] private Collider2D southCollider; // 2D コライダーに変更
    [SerializeField] private Collider2D northCollider; // 2D コライダーに変更
    public Transform EntityObject;
    private int randomNumber;

    void Start()
    {
        MoveRandom();
    }

    void MoveRandom()
    {
        randomNumber = Random.Range(1, 5); // 1～4の範囲
        Move();
    }

    void Move()
    {
        Vector3 newPosition = EntityObject.transform.position;

        if (randomNumber == 1) // 東（x+1）
        {
            if (!eastCollider.IsTouching(GetWallCollider())) // コライダーが重なっていない場合
            {
                newPosition += new Vector3(1f, 0f, 0f); // 東に移動
            }
            else
            {
                Debug.Log("EastCollider が壁に重なっています！");
                MoveRandom(); // 重なっていれば再度ランダム移動
            }
        }
        else if (randomNumber == 2) // 西（x-1）
        {
            if (!westCollider.IsTouching(GetWallCollider())) // コライダーが重なっていない場合
            {
                newPosition += new Vector3(-1f, 0f, 0f); // 西に移動
            }
            else
            {
                Debug.Log("WestCollider が壁に重なっています！");
                MoveRandom(); // 重なっていれば再度ランダム移動
            }
        }
        else if (randomNumber == 3) // 南（y-1）
        {
            if (!southCollider.IsTouching(GetWallCollider())) // コライダーが重なっていない場合
            {
                newPosition += new Vector3(0f, -1f, 0f); // 南に移動
            }
            else
            {
                Debug.Log("SouthCollider が壁に重なっています！");
                MoveRandom(); // 重なっていれば再度ランダム移動
            }
        }
        else if (randomNumber == 4) // 北（y+1）
        {
            if (!northCollider.IsTouching(GetWallCollider())) // コライダーが重なっていない場合
            {
                newPosition += new Vector3(0f, 1f, 0f); // 北に移動
            }
            else
            {
                Debug.Log("NorthCollider が壁に重なっています！");
                MoveRandom(); // 重なっていれば再度ランダム移動
            }
        }

        // DOTweenで移動処理
        EntityObject.DOMove(newPosition, 1f).OnComplete(() =>
        {
            MoveRandom(); // 移動が終わったら再度ランダムに移動
        });
    }

    private Collider2D GetWallCollider()
    {
        // 壁のコライダーを判定するロジック（仮）
        // ここで2Dコライダーに基づいた壁のコライダーを返してください
        return null; // 仮の返却、実際には壁のコライダーを返す
    }
}
