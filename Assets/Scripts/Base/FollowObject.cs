using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace Verse
{
    public class FollowObject : MonoBehaviour
    {
        [HideInInspector] public Transform target; // 追尾したいオブジェクト（例：プレイヤーやアイテム）
        public TextMeshProUGUI textMeshPro; // 追尾するTextMeshProのUI要素
        public Vector3 offset; // テキストの位置を調整するためのオフセット

        private Camera mainCamera;

        void Start()
        {
            // メインカメラの参照を取得
            mainCamera = Camera.main;
            textMeshPro = GetComponent<TextMeshProUGUI>();
        }

        void Update()
        {
            if (target != null && textMeshPro != null)
            {
                Vector3 screenPosition = mainCamera.WorldToScreenPoint(target.position + offset);


                textMeshPro.transform.position = screenPosition;
            }
        }

    }
}
