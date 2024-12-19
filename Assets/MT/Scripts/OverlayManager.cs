using UnityEngine;
using UnityEngine.SceneManagement;

public class OverlayManager : MonoBehaviour
{
    public string overlaySceneName = "OverlayScene";

    void ShowOverlayScene()
    {
        SceneManager.LoadScene(overlaySceneName, LoadSceneMode.Additive);
    }

    void HideOverlayScene()
    {
        SceneManager.UnloadSceneAsync(overlaySceneName);
    }
}
