using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine.UI;
using static UnityEngine.UI.Button;
using UnityEngine.Events;
using UnityEngine;

namespace BlackOut.UI
{
    [RequireComponent(typeof(ButtonV))]
    [RequireComponent (typeof(Button))]
    public class ButtonVM : TextViewModel, IButtonUI, ICustomizableButton
    {
        public Button Button { get; protected set; }

        public Image Image { get; set; }

        protected virtual void Awake()
        {
            Button = GetComponent<Button>();
        }
        protected override void Start()
        {
            base.Start();
            Debug.Log("Initialized ButtonViewModel! ObjectName:" + name);
        }
        public void SetOnClick(UnityAction action)
        {
            if (action == null || Button == null) { Debug.LogError("エラー"); }
            Button.onClick.AddListener(action);
        }

        public void OnClick()
        {
            Button.onClick?.Invoke();
        }

        public void SetImage(Image image)
        {
            Image = image;
            NotifyDataChanged();
        }
    }
}