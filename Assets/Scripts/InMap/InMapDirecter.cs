using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Verse
{
    public class InMapDirecter : MonoBehaviour
    {
        [SerializeField] GameObject _uiPanel;

        public void OpenPanel() => _uiPanel.SetActive(true);
        public void ClosePanel() => _uiPanel.SetActive(false);
    }
}
