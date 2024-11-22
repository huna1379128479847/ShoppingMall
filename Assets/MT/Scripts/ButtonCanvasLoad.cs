using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCanvasLoad : MonoBehaviour
{
    public GameObject LoadCanvas;
    public bool IsActive;
public void CanvasLoad()
{
    IsActive =! IsActive;
    LoadCanvas.SetActive(IsActive);
}


}
