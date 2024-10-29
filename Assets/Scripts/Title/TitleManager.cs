using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using BlackOut.Utility;
using BlackOut;
using BlackOut.UI;

namespace Verse
{
    public class TitleDirecter : MonoBehaviour
    {
        // シングルトン用のインスタンス保持
        private static TitleDirecter _instance;

        // フィールド
        [SerializeField] ButtonVM start;
        [SerializeField] ButtonVM end;
        [SerializeField] ButtonVM cont;
        private ISceneChanger _changer;
        private readonly string[] tutorial = { "tutorial" };

        // シングルトン用プロパティ
        public static TitleDirecter Instance => _instance;

        // メソッド
        public void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
            }
            else
            {
                Destroy(gameObject);
                return;
            }
            _changer = new SceneChanger(SceneManager.GetActiveScene());
        }

        public void Start()
        {
            if (start != null)
            {
                start.SetOnClick(GotoTutorial);
                start.SetText("スタート");
            }
            if (cont != null)
            {
                cont.SetOnClick(GoToSaveList);
                cont.SetText("続ける");
            }
            if (end != null)
            {
                end.SetOnClick(End);
                end.SetText("終わる");
            }
        }
        public void SetSceneChanger(ISceneChanger changer)
        {
            _changer = changer;
        }

        private void OnDestroy()
        {
            if (Instance == this) { _instance = null; }
        }

        private void GotoTutorial()
        {
            if (_changer != null && !_changer.SceneChange("InMap", tutorial))
            {
                Debug.LogError("チュートリアルシーンの変更に失敗しました。");
            }
        }


        private void End()
        {
            Debug.Log("ゲームを終了します");
            // ゲームを終了させる機能
#if UNITY_EDITOR
            EditorApplication.isPlaying = false; //ゲームプレイ終了
#else
                Application.Quit(); //ゲームプレイ終了
#endif
        }

        private void GoToSaveList()
        {
            
        }
    }
}
