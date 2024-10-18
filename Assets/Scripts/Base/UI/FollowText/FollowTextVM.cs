using BlackOut.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace Verse
{
    public class FollowTextVM : FollowTextViewModel, IFollowTextUI
    {
        protected override void Start()
        {
            // メインカメラの参照を取得
            SetCamera(Camera.main);
            base.Start();
        }
    }
}
