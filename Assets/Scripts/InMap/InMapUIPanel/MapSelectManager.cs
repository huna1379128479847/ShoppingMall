using BlackOut.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Verse
{
    public class MapSelectManager : MonoBehaviour
    {
        [SerializeField] ButtonVM _buttonPrehub;

        Dictionary<string, ButtonVM> mapPair = new Dictionary<string, ButtonVM>();
    }
}
