using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Verse;

namespace ShoppingMall
{
    public interface IUniqueThing
    {
        Guid ID { get; }
    }

    public interface INameAndDesc
    {
        string Name { get; }
        string Description { get; }
        bool ShowName { get; }
        bool ShowDescription { get; }
    }

    public interface IClickable
    {
        bool CanClick { get; }
        void ClickAction();
    }

    public interface IUserInterface
    {
        GameObject User { get; }
        TextMeshProUGUI TextMeshProUGUI { get; }
        void SetText(string text);

        void SetFontSize(int fontSize);

        void Show();
        void Hide();
    }

    public interface IFollowObjectHolder : IUserInterface
    {
        FollowObject Follow { get; }
    }
    public interface IPlayer
    {

    }

    public interface IHolder
    {

    }
}
