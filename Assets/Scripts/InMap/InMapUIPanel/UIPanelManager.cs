using BlackOut.UI;
using BlackOut.Utility;
using System;
using UnityEngine;

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
        [SerializeField] ButtonVM _openZoomMap;

        public void Start()
        {
            _openItemBox?.SetOnClick(OpenItemBox);
            _openItemBox?.SetText("アイテムボックス");

            _openZoomMap?.SetOnClick(OpenZoomMap);
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
            GameSpeedHelper.Play();
        }
        public void OpenItemBox()
        {
            Open(UIPanel.ItemBox);
        }

        public void OpenZoomMap()
        {
            Open(UIPanel.MapZoom);
            GameSpeedHelper.Pause();
        }

        public void OpenMapSelecter()
        {
            Open(UIPanel.MapSelect);
            GameSpeedHelper.Pause();
        }

        private void Open(UIPanel uI)
        {
            if (_currentUI == uI)
            {
                ClosePanel();
            }
            else
            {
                OpenPanel(uI);
            }
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape) && _currentUI != UIPanel.None)
            {
                ClosePanel();
            }
        }
    }
}
