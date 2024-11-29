using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;

public class DialogueManager : MonoBehaviour
{
    // TextMeshProとボタン
    public TextMeshProUGUI dialogueText;
    public Text TextBox;
    public Button nextButton;

    // 会話リスト
    private List<string> conversation = new List<string>
    {
        "01",
        "02",
        "03"
    };

    private int currentDialogueIndex = 0;

    void Start()
    {
        // 最初のセリフを表示
        UpdateDialogue();

        // ボタンにクリックイベントを設定
        nextButton.onClick.AddListener(NextDialogue);
    }

    void UpdateDialogue()
    { 
        
        // リスト内のセリフを表示
        if (currentDialogueIndex < conversation.Count)
        {
            TextBox.text = conversation[currentDialogueIndex];
        }
        else
        {
            // 会話が終了したらボタンを無効化
            TextBox.text = "会話が終了しました。";
            nextButton.interactable = false;
        }
    }

    void NextDialogue()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(TextBox.DOFade(1f,1f));
        sequence.AppendInterval(0.3f);//待機
        currentDialogueIndex++;
        UpdateDialogue();
        sequence.Append(TextBox.DOFade(0f,1.5f));//フィードアウト
        
        
    }
}
