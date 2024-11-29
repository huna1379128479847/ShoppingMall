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
        [SerializeField] UIPanelManager _uiPanel;

        public void OpenPanel() => _uiPanel.OpenPanel(UIPanel.MapSelect);
        public void ClosePanel() => _uiPanel.ClosePanel();
    }
}
