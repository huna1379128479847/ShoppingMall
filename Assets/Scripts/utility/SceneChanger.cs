using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

namespace BlackOut.Utility
{
    public class SceneChanger : ISceneChanger, IDisposable
    {
        // �t�B�[���h
        private Scene fromScene;
        private Scene currentScene;
        private string[] args = new string[0];
        // �C�x���g �f���Q�[�g
        public UnityEvent OnSceneChanged { get; private set; }

        // �v���p�e�B
        public Scene FromScene => fromScene;
        public Scene CurrentScene => currentScene;

        // �R���X�g���N�^
        public SceneChanger(Scene scene)
        {
            currentScene = scene;
            OnSceneChanged = new UnityEvent();

            // �V�[�������[�h���ꂽ����currentScene���X�V
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        public void Dispose()
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }

        // �V�[�����[�h������ɌĂ΂��
        private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            currentScene = scene;
            GameObject[] gameObjects = currentScene.GetRootGameObjects();
            if (gameObjects.Length > 0)
            {
                foreach(var obj in gameObjects)
                {
                    if (obj.TryGetComponent(out ISceneManagement manager))
                    {
                        manager.Execute(args);
                    }
                }
            }
            OnSceneChanged.Invoke();  // �V�[���ύX�C�x���g����
        }

        // �V�[���ύX���\�b�h
        public bool SceneChange(string toSceneName, string[] args, LoadSceneMode sceneMode = LoadSceneMode.Single)
        {
            fromScene = currentScene;
            this.args = args;
            try
            {
                SceneManager.LoadScene(toSceneName, sceneMode);
                // currentScene�̍X�V��OnSceneLoaded�ōs��
                return true;
            }
            catch (Exception ex)
            {
                Debug.LogError($"�V�[����������܂���ł���: {toSceneName}. �G���[: {ex.Message}");
                return false;
            }
        }

        public bool SceneChange(int toSceneIdx, string[] args, LoadSceneMode sceneMode = LoadSceneMode.Single)
        {
            fromScene = currentScene;
            this.args = args;
            try
            {
                SceneManager.LoadScene(toSceneIdx, sceneMode);
                return true;
            }
            catch (Exception ex)
            {
                Debug.LogError($"�V�[����������܂���ł���: {toSceneIdx}. �G���[: {ex.Message}");
                return false;
            }
        }
    }
}