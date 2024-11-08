using BlackOut.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Verse
{
    [Flags]
    public enum UIPanel
    {
        None = 0,
        MapSelect = 1 << 0,
        MapZoom = 1 << 1,
        ItemBox = 1 << 2,
    }
    public class UIPanelManager : MonoBehaviour
    {
        private UIPanel _currentUI;
        [SerializeField] GameObject _mapSelecter;
        [SerializeField] GameObject _mapZoom;
        [SerializeField] GameObject _itemBox;

        [SerializeField] ButtonVM _openItemBox;

        public void Start()
        {
            _openItemBox?.SetOnClick(OpenItemBox);
            _openItemBox?.SetText("アイテムボックス");
        }
        public void OpenPanel(UIPanel ui)
        {

            _mapSelecter?.SetActive(false);
            _mapZoom?.SetActive(false);
            _itemBox?.SetActive(false);
            switch (ui)
            {
                case UIPanel.MapSelect:
                    _mapSelecter?.SetActive(true);
                    break;
                case UIPanel.MapZoom:
                    _mapZoom?.SetActive(true);
                    break;
                case UIPanel.ItemBox:
                    _itemBox?.SetActive(true);
                    break;
            }
            _currentUI = ui;
        }
        public void ClosePanel()
        {
            _mapSelecter?.SetActive(false);
            _mapZoom?.SetActive(false);
            _itemBox?.SetActive(false);
            _currentUI = UIPanel.None;
        }
        private void OpenItemBox()
        {
            if (_currentUI == UIPanel.ItemBox)
            {
                ClosePanel();
            }
            else
            {
                OpenPanel(UIPanel.ItemBox);
            }
        }
    }
}
