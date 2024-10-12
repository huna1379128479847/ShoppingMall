using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Verse
{
    public class PopUpFactory : SingletonBehavior<PopUpFactory>
    {
        [SerializeField] FollowObject TextObj;
        [SerializeField ] GameObject Canvas;
        public FollowObject CreateObject(Transform target)
        {
            if (TextObj == null)
            {
                Debug.LogError("TextObjがアタッチされていません");
                return null;
            }
            FollowObject follow = Instantiate(TextObj.gameObject, Canvas.transform).GetComponent<FollowObject>();
            follow.target = target;
            return follow;
        }

        public void DestroyPopUp(FollowObject followObject)
        {
            if (followObject != null)
            {
                Destroy(followObject.gameObject);
            }
        }

    }
}