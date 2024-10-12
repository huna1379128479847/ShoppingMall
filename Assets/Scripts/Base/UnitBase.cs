using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShoppingMall;
using System;
using TMPro;

namespace Verse
{
    public abstract class UnitBase : MonoBehaviour, IUniqueThing, INameAndDesc
    {
        // フィールド
        protected Guid id;
        [SerializeField] protected string unitName;
        [SerializeField] protected string unitDescription;

        protected bool showName = true;
        protected bool showDescription = true;

        protected IFollowObjectHolder _popUp;

        // プロパティ
        public Guid ID => id;
        public string Name => unitName;
        public string Description => unitDescription;
        public bool ShowName
        {
            get
            {
                return showName;
            }
            set
            {
                showName = value;
            }
        }
        public bool ShowDescription
        {
            get
            {
                return showDescription;
            }
            set
            {
                showDescription = value;
            }
        }

        // 初期化処理
        public virtual void Awake()
        {
            id = Guid.NewGuid();
            FollowObject text = PopUpFactory.instance.CreateObject(gameObject.transform);
            var textMeshProUGUI = text.textMeshPro;
            _popUp = new TMPro_Helper(gameObject, textMeshProUGUI, text);
            if (showName)
            {
                _popUp.Show();
            }
        }

        public virtual void Update()
        {

        }
    }
}
