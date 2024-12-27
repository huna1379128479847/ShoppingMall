using System.Collections.Generic;
using UnityEngine;


public class CanvasLoadManager : MonoBehaviour
{
[System.Serializable]
public class CanvasData
{
    public GameObject OJ_Canvas;
    public bool IsActive;
}

public List<CanvasData> CanvasList;
public GameObject StartCanvas;

void Start()
{
    foreach (CanvasData data in CanvasList)
    {
        data.IsActive = false;
    }
    StartCanvas.SetActive(true);
}



}
