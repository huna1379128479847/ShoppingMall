using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShoppingMall;
using ShoppingMall.InputKey;
using Helpers;

namespace Verse
{
    public class Player_Test : UnitBase, IPlayer
    {
        [SerializeField]private int fontsize = 17;
        [SerializeField] private Vector2 offSet;
        public override void Awake()
        {
            base.Awake();
            _popUp.SetFontSize(fontsize);
            _popUp.Follow.offset = offSet;
            _popUp.SetText(unitName);
        }
        // Update is called once per frame
        public override void Update()
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
    }
}