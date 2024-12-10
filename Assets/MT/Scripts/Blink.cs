using UnityEngine;
using DG.Tweening;
public class Blink : MonoBehaviour
{
    public Vector3 targetPosition; // 移動先の位置
    public float duration = 1.0f;  // 移動にかかる時間
    public int loopCount = -1;     // ループ回数（-1で無限ループ）

    void Start()
    {
        transform.DOMove(targetPosition, duration).SetEase(Ease.InOutQuad).SetLoops(loopCount, LoopType.Yoyo);
    }
}
