using System.Collections.Generic;
using UnityEngine;

namespace BlackOut.Utility.Logics
{
    public class MakePath : IMakePath
    {
        /// <summary>
        /// 指定された2点間のパスを計算し、中間地点のリストを返す。
        /// なお2Dゲームのため、z軸は無視される。
        /// </summary>
        public List<Vector3> GetPath(Vector3 from, Vector3 to)
        {
            // Z軸は無視
            from.z = 0;
            to.z = 0;

            // 同じ座標の場合はそのまま返す
            if (from == to)
                return new List<Vector3> { from };

            var path = new List<Vector3>();
            Vector3 intermediate = from;

            // X軸方向の移動を追加
            if (from.x != to.x)
            {
                intermediate = new Vector3(to.x, from.y, 0);
                path.Add(intermediate);
            }

            // Y軸方向の移動を追加
            if (from.y != to.y)
            {
                intermediate = new Vector3(intermediate.x, to.y, 0);
                path.Add(intermediate);
            }

            return path;
        }
    }

    public class MakePathWithWall : IMakePath
    {
        /// <summary>
        /// 指定された2点間のパスを計算し、中間地点のリストを返す。
        /// 壁などの障害物の存在を考慮する
        /// Note:まだ未実装
        /// </summary>
        public List<Vector3> GetPath(Vector3 from, Vector3 to)
        {
            // Z軸は無視
            from.z = 0;
            to.z = 0;

            // 同じ座標の場合はそのまま返す
            if (from == to)
                return new List<Vector3> { from };

            var path = new List<Vector3>();
            Vector3 intermediate = from;

            // X軸方向の移動を追加
            if (from.x != to.x)
            {
                intermediate = new Vector3(to.x, from.y, 0);
                path.Add(intermediate);
            }

            // Y軸方向の移動を追加
            if (from.y != to.y)
            {
                intermediate = new Vector3(intermediate.x, to.y, 0);
                path.Add(intermediate);
            }

            return path;
        }
    }
}
