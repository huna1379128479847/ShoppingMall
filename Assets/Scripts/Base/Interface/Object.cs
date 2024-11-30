using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
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

    public interface ISceneChanger
    {
        UnityEvent OnSceneChanged { get; }
        Scene FromScene { get; }
        Scene CurrentScene { get; }
        bool SceneChange(string toSceneName, string[] args, LoadSceneMode sceneMode = LoadSceneMode.Single);

        bool SceneChange(int toSceneIdx, string[] args, LoadSceneMode sceneMode = LoadSceneMode.Single);
    }

    public interface ISceneManagement
    {
        ISceneManagement Execute(string[] args);
    }

    public interface IMakePath
    {
        List<Vector3> GetPath(Vector3 from, Vector3 to);
    }
}
