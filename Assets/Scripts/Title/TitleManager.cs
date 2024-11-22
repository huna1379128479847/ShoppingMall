using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using BlackOut.Utility;
using BlackOut;
using BlackOut.UI;
using System;
using UnityEngine.Events;

namespace Verse
{
    public class TitleDirecter : MonoBehaviour
    {
        // シングルトン用のインスタンス保持
        private static TitleDirecter _instance;

        [Header("ボタン")]
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
            _changer = _changer ?? new SceneChanger(SceneManager.GetActiveScene());
        }

        public void Start()
        {
            if (start != null)
            {
                ConfigureButton(start, "スタート", GotoTutorial);
            }
            if (cont != null)
            {
                ConfigureButton(cont, "続ける", GoToSaveList);
            }
            if (end != null)
            {;
                ConfigureButton(end, "終わる", End);
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

        private void ConfigureButton(ButtonVM button, string text, UnityAction onClick)
        {
            if (button != null)
            {
                button.SetOnClick(onClick);
                button.SetText(text);
            }
        }
    }
}
