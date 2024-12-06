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


    void Start()
    {
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
            TextBox.DOText(currentText, animationTime, true, ScrambleMode.None, null); // テキストアニメーション
        }
        else
        {
            // 会話終了処理
            Debug.Log("END");
        }
    }
}
