using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections;

public class DialogueManager_Text : MonoBehaviour
{
    public Text TextBox; // テキストを表示するUIコンポーネント
    public Button nextButton; // 次へ進むボタン

    // 会話リスト
    public List<string> conversation = new List<string>
    {
        "01",
        "02",
        "03"
    };

    private int currentDialogueIndex = -1; // 現在のセリフのインデックス
    public string ENDName = "The End"; // 会話終了後のテキスト
    public float animationTime = 3.0f; // テキストアニメーションの時間
    public float StartTime = 2f;
    [SerializeField] private SceneLoadManager GAME;


    void Start()
    {
        nextButton.interactable = false;
        StartCoroutine(STARTTIME());
    }
    IEnumerator STARTTIME()
    {
        yield return new WaitForSeconds(StartTime);
        UpdateDialogue(); // 会話を初期化
    }
    public void UpdateDialogue()
    {
        currentDialogueIndex++; // 次のセリフに進む

        if (currentDialogueIndex < conversation.Count)
        {
            // 現在のセリフをアニメーション表示
            string currentText = conversation[currentDialogueIndex];
            TextBox.text = ""; // テキストをリセット
            nextButton.interactable = false;
            StartCoroutine(Button_false());
            TextBox.DOText(currentText, animationTime, true, ScrambleMode.None, null); // テキストアニメーション
        }
        else
        {
            // 会話終了処理
            TextBox.text = ENDName;
            Debug.Log(TextBox.text);
            nextButton.interactable = false;
            StartCoroutine(StageLoad());

        }
    }
    IEnumerator StageLoad()
    {
        TextBox.DOFade(0f,1.5f);
        yield return new WaitForSeconds(2);
        
        GAME.SceneLoad();
    }

        IEnumerator Button_false()
    {
        yield return new WaitForSeconds(1);
        nextButton.interactable = true;
    }
}

