using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BlackOut;
using System;
using TMPro;
using BlackOut.UI;

namespace Verse
{
    public abstract class UnitBase : MonoBehaviour, IUniqueThing, INameAndDesc
    {
        // �t�B�[���h
        protected Guid id;
        [SerializeField] protected string unitName;
        [SerializeField] protected string unitDescription;

        protected bool showName = true;
        protected bool showDescription = true;

        protected IFollowTextUI nameFollower;

        // �v���p�e�B
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

        // ����������
        protected virtual void Awake()
        {
            id = Guid.NewGuid();
            nameFollower = FollowTextFactory.instance.CreateObject(transform);
            if (nameFollower == null )
            {
                Debug.Log("NameFollower����ł�");
            }
        }

        protected virtual void Start()
        {

        }
        protected virtual void Update()
        {
        }
    }
}
