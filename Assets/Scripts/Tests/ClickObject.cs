using ShoppingMall;
using ShoppingMall.InputKey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Verse
{
    public class ClickObject : UnitBase, IClickable, IUniqueThing, INameAndDesc
    {
        private bool canClick;
        private float time = 0;

        public bool CanClick => canClick;

        public override void Awake()
        {
            base.Awake();
            _popUp.Hide();
        }

        public virtual void ClickAction()
        {
            _popUp.Show();
            _popUp.SetText("Get Item.");
        }
        public override void Update()
        {
            base.Update();
            if (KeyMappingHolder.IsPressConfirmKey() || CanClick)
            {
                ClickAction();
                time = 3;
            }
            if (time > 0)
            {
                time -= Time.deltaTime;
            }
            if (time < 0)
            {
                time = 0;
                _popUp.Hide();
            }
        }
        public virtual void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player" && !canClick)
            {
                canClick = true;
            }
        }

        public void OnTriggerExit2D(Collider2D collision)
        {
            if (canClick)
            {
                canClick = false;
            }
        }
    }
}
