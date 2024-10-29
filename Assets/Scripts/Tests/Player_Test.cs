using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BlackOut;
using BlackOut.GameManage.InputKeys;
using BlackOut.Utility;
using BlackOut.GameManage.DataCenter;

namespace Verse
{
    public class Player_Test : UnitBase, IPlayer
    {
        [SerializeField]private int fontsize = 17;
        [SerializeField] private Vector2 offSet;
        private bool isInit;
        [SerializeField]private Vector2 targetPosition;

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
            if (isInit && Input.GetMouseButton(0))
            {
                Vector2 vec = transform.position;
                targetPosition = Input.mousePosition;
                
            }
            else if (nameFollower != null && nameFollower.IsInit)
            {
                Init();
            }
        }

        public virtual void Move(Vector2 target)
        {

        }
    }
}