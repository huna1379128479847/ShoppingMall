using BlackOut.UI;
using System.Collections.Generic;
using UnityEngine;

namespace Verse
{
    public class MapSelectManager : MonoBehaviour
    {
        [SerializeField] ButtonVM _buttonPrehub;

        Dictionary<string, ButtonVM> mapPair = new Dictionary<string, ButtonVM>();

        public void Start()
        {
            
        }
    }
}
