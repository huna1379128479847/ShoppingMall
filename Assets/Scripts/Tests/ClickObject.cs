using BlackOut;
using BlackOut.GameManage.DataCenter;
using BlackOut.GameManage.InputKeys;
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
        [SerializeField]private bool canClick;
        private float time = 0;

        public bool CanClick => canClick;

        protected override void Awake()
        {
            id = new Guid();
            nameFollower = FollowTextFactory.instance.CreateObject(transform, true);
        }

        public virtual void ClickAction()
        {
            nameFollower.Show();
            nameFollower.SetText("Get Item.");
            nameFollower.SetFontSize(20);
        }
        protected override void Update()
        {
            base.Update();
            if (DataCenter.keyMappingHolder.IsPressConfirmKey() || CanClick)
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
                nameFollower.Hide();
            }
        }
        public virtual void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player" && !canClick)
            {
                canClick = true;
                Debug.Log("Player検出");
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
