using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BlackOut;
using BlackOut.GameManage.InputKeys;
using Helpers;

namespace Verse
{
    public class Player_Test : UnitBase, IPlayer
    {
        [SerializeField]private int fontsize = 17;
        [SerializeField] private Vector2 offSet;
        private bool isInit;
        protected override void Start()
        {
        }

        private void Init()
        {
            nameFollower.Show();
            nameFollower.SetFontSize(fontsize);
            nameFollower.SetOffset(offSet);
            nameFollower.SetText(unitName);
            isInit = true;
        }
        // Update is called once per frame
        protected override void Update()
        {
            if (isInit)
            {
                Vector2 vec = transform.position;
                List<KeyType> keys = KeyMappingHolder.CheckPressAllowKeys(PressType.Keep);
                if (keys.Contains(KeyType.Up))
                {
                    vec.y += 2;
                }
                if (keys.Contains(KeyType.Down))
                {
                    vec.y -= 2;
                }
                if (keys.Contains(KeyType.Left))
                {
                    vec.x -= 2;
                }
                if (keys.Contains(KeyType.Right))
                {
                    vec.x += 2;
                }
                transform.position = vec;
                foreach (KeyType key in keys)
                {
                    FLGHelper.PrintBinary((uint)key);
                }
            }
            else if (nameFollower != null && nameFollower.IsInit)
            {
                Init();
            }
            if (nameFollower == null) { Debug.LogError("‹ó"); }
        }
    }
}