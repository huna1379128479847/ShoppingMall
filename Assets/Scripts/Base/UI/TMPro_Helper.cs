using ShoppingMall;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Verse
{
    public class TMPro_Helper : IFollowObjectHolder
    {
        private GameObject user;
        private TextMeshProUGUI _UGUI;

        public GameObject User => user;

        public TextMeshProUGUI TextMeshProUGUI => _UGUI;

        public FollowObject Follow { get; private set; }

        public TMPro_Helper(GameObject user, TextMeshProUGUI textMeshProUGUI, FollowObject follow)
        {
            this.user = user;
            _UGUI = textMeshProUGUI;
            Follow = follow;
        }

        public void SetText(string text)
        {
            if (_UGUI != null)
            {
                _UGUI.SetText(text);
            }
            else
            {
                Debug.LogError("TextMeshProUGUI is not assigned!");
            }
        }

        public void SetFontSize(int fontSize)
        {
            if (_UGUI != null)
            {
                _UGUI.fontSize = fontSize;
            }
        }
        public void Show()
        {
            _UGUI.gameObject.SetActive(true);
        }

        public void Hide()
        {
            _UGUI.gameObject.SetActive(false);
        }

    }
}