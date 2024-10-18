using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Verse;

namespace BlackOut
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
    public interface IPlayer
    {

    }

    public interface IFactory<TObject> where TObject : class
    {
        TObject CreateObject();
    }
}
