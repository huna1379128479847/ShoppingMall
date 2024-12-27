using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : MonoBehaviour
{
    [Header("シーンのアンロードの対象シーン")]
    public string DestroySceneName;
    [Header("呼び出すシーン")]
    public string SceneLoadName;
    [Header("ロード中に呼ぶ出すシーン")]
    public string EffectSceneName;
    [Header("何秒後にロードするか？(s) ロードシーンと合わせる")]
    public float StockTime = 2f;
    [Header("シーンのロードの対象シーン(エフェクトなし)")]
    public string SceneLoadName_Simple;

    [Header("シーンのアンロードの対象シーン(エフェクトなし)")]
    public string UnloadSceneName_Simple;

    public void SceneLoad()
    {
        
        SceneManager.LoadScene(EffectSceneName,LoadSceneMode.Additive);
        
        StartCoroutine(IE());
    }

IEnumerator IE()
{
    Debug.Log("IE");
    yield return new WaitForSeconds(StockTime);
    SceneManager.LoadScene(SceneLoadName,LoadSceneMode.Additive);
    SceneManager.UnloadSceneAsync(DestroySceneName);
    
    Debug.Log("complete!!");
}
    public void SceneLoad_Simple()
{
    SceneManager.LoadScene(SceneLoadName_Simple, LoadSceneMode.Additive);

}
    public void SceneUnload_Simple()
    {
        SceneManager.UnloadSceneAsync(UnloadSceneName_Simple);
    }
}
