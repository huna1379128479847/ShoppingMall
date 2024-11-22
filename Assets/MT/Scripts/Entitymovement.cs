using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class EntityMovement : MonoBehaviour
{
    [SerializeField] private Collider eastCollider;
    [SerializeField] private Collider westCollider;
    [SerializeField] private Collider southCollider;
    [SerializeField] private Collider northCollider;
    public Transform EntityObject;
    private int randomNumber;

    void Start()
    {
        MoveRandom();
    }

    void MoveRandom()
    {
        randomNumber = Random.Range(1, 5); // 1～4の範囲でランダム値を生成
        Move();
    }

    void Move()
    {
        Vector3 newPosition = EntityObject.transform.position;

        switch (randomNumber)
        {
            case 1: // 東（x+1）
                if (!IsTouchingWall(eastCollider))
                {
                    newPosition += new Vector3(1f, 0f, 0f);
                }
                break;

            case 2: // 西（x-1）
                if (!IsTouchingWall(westCollider))
                {
                    newPosition += new Vector3(-1f, 0f, 0f);
                }
                break;

            case 3: // 南（y-1）
                if (!IsTouchingWall(southCollider))
                {
                    newPosition += new Vector3(0f, -1f, 0f);
                }
                break;

            case 4: // 北（y+1）
                if (!IsTouchingWall(northCollider))
                {
                    newPosition += new Vector3(0f, 1f, 0f);
                }
                break;
        }

        // DOTweenを使用して移動アニメーションを実行
        EntityObject.DOMove(newPosition, 1f).OnComplete(() =>
        {
            MoveRandom(); // 移動完了後に再びランダム移動
        });
    }

    bool IsTouchingWall(Collider directionCollider)
    {
        // コライダーが壁に触れているかどうかを判定する
        RaycastHit hit;
        if (Physics.Raycast(directionCollider.transform.position, directionCollider.transform.forward, out hit, 1f))
        {
            if (hit.collider.CompareTag("Wall"))
            {
                Debug.Log($"{directionCollider.name} が壁に触れています！");
                return true;
            }
        }
        return false;
    }
}
