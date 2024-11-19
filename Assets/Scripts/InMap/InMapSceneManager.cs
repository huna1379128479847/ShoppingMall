using BlackOut;
using System;
using System.Linq;

namespace Verse
{
    public class InMapSceneManager : SingletonBehavior<InMapSceneManager> , ISceneManagement
    {
        // クラス保持フィールド
        InMapDirecter _directer;

        // その他フィールド

        public ISceneManagement Execute(string[] args)
        {
            _directer = GetComponent<InMapDirecter>();
            if (!args.Contains("DontOpenUI"))
            {
                _directer.OpenPanel();
            }
            return this;
        }
    }
}
