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
                Debug.LogError("TextObjがアタッチされていません");
                return null;
            }
            GameObject gameObj = Instantiate(TextObj.gameObject, Canvas.transform);
            FollowTextVM follow = gameObj.GetComponent<FollowTextVM>();
            if (hide)
            {
                follow.Hide();
            }
            follow.SetTarget(target);
            Debug.Log("生成完了");
            return follow as IFollowTextUI;
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