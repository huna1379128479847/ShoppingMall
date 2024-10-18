using System;
using UnityEngine;
using UnityEngine.UI;

namespace BlackOut.UI
{
    // 基本的なUIInterface
    public interface IUserInterface
    {
        bool IsHide { get; }
        bool IsInit { get; }
        void Show();
        void Hide();
    }

    public interface IFollowUI
    {
        public Vector2 Offset { get; }
        public Transform Target { get; }
        public Camera FollowCamera { get; }
        void SetOffset(Vector2 offset);
        void SetTarget(Transform target);
        void SetCamera(Camera camera);
    }

    public interface IColorable
    {
        void SetColor(Color color);
    }

    // 派生したUIInterface
    public interface ICustomizableText : IUserInterface, IColorable
    {
        void SetText(string text);

        void SetFontSize(int fontSize);
    }

    public interface ICustomizableImage : IUserInterface, IColorable
    {
        void SetImage(Image image);
    }

    public interface IButtonUI : IUserInterface
    {
        Button Button { get; }
        void OnClick();
        void SetOnClick(Action action);
    }
    // 統合用Interface
    public interface IFollowTextUI : IFollowUI, ICustomizableText
    {
    }

    public interface ICustomizableButton : ICustomizableText, ICustomizableImage
    {
    }
}
