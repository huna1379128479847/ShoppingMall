// using System.Collections.Generic;
// using System.Linq;
// using BlackOut.Utility.Logics;
// using DG.Tweening;
// using UnityEngine;

// namespace BlackOut
// {
//     /// <summary>
//     /// エネミー操作制御用
//     /// 継承可能
//     /// </summary>
//     public class EnemyController : MonoBehaviour
//     {
//         [Header("エネミー移動設定")]
//         [Tooltip("アンカーのnameは必ず移動したい順に半角の数字を割り振ること")]
//         [SerializeField] string _checkTag = "MovementAnchor";
//         [SerializeField] float _moveTime = 10f;
//         [SerializeField] bool _isLoop = true;
//         [SerializeField] Ease _ease = Ease.Linear;
//         [SerializeField] LoopType _type;

//         [Header("デバッグ")]
//         [SerializeField] private List<Transform> _anchors = new List<Transform>();
//         [SerializeField] private List<Vector3> _movePoint = new List<Vector3>();
//         private IMakePath _makePath;

//         public virtual bool IsMove { get; set; } = true;

//         protected virtual void Start()
//         {
//             _makePath = new MakePath();
// #if UNITY_EDITOR
//             loopType = _type;
//             time = _moveTime;
//             ease = _ease;
// #endif
//             if (GetPath() && IsMove)
//                 MoveBehaviour();
//         }

//         protected bool GetPath()
//         {
//             var parent = transform.parent;

//             _anchors = parent.GetComponentsInChildren<Transform>()
//                 .Where(child => child.CompareTag(_checkTag))
//                 .Where(anchor =>
//                 {
//                     bool isValid = int.TryParse(anchor.name, out _);
//                     if (!isValid)
//                     {
//                         Debug.LogWarning($"Invalid anchor name: {anchor.name}");
//                     }
//                     return isValid;
//                 })
//                 .OrderBy(anchor => int.Parse(anchor.name))
//                 .ToList();

//             if (_anchors.Count <= 1)
//             {
//                 Debug.LogWarning("Insufficient anchors for movement. At least 2 are required.");
//                 return false;
//             }

//             Transform g1 = gameObject.transform;
//             foreach (Transform t in _anchors)
//             {
//                 _movePoint.AddRange(_makePath.GetPath(g1.position, t.position));
//                 g1 = t;
//             }
//             _movePoint.AddRange(_makePath.GetPath(g1.position, gameObject.transform.position));
//             return true;
//         }

//         public virtual void MoveBehaviour()
//         {
//             var pathTweener = transform.DOPath(_movePoint.ToArray(), _moveTime)
//                     .SetEase(_ease);

//             if (_isLoop)
//             {
//                 pathTweener.SetLoops(-1, _type);
//             }
//         }
//         private void OnDestroy()
//         {
//             transform.DOKill();
//         }

// #if UNITY_EDITOR
//         private LoopType loopType;
//         private Ease ease;
//         private float time;
//         private void Update()
//         {
//             if (ease != _ease || loopType != _type || time != _moveTime)
//             {
//                 transform.DOKill();
//                 transform.position = _movePoint[_movePoint.Count - 1];
//                 MoveBehaviour();
//                 loopType = _type;
//                 time = _moveTime;
//                 ease = _ease;
//             }
//         }
// #endif
//     }
// }