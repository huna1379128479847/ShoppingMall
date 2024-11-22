using BlackOut;
using BlackOut.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Verse
{
    public class FollowTextFactory : SingletonBehavior<FollowTextFactory>
    {
        [SerializeField] FollowTextVM TextObj;
        [SerializeField] GameObject Canvas;
        public IFollowTextUI CreateObject(Transform target, bool hide = false)
        {
            if (TextObj == null)
            {
                Debug.LogError("TextObj���A�^�b�`����Ă��܂���");
                return null;
            }
            FollowTextVM follow = Instantiate(TextObj, Canvas.transform);
            if (hide)
            {
                follow.Hide();
            }
            follow.SetTarget(target);
            Debug.Log("��������");
            return follow;
        }

        public void DestroyPopUp(FollowTextVM followObject)
        {
            if (followObject != null)
            {
                Destroy(followObject.gameObject);
            }
        }

    }
}