using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;

public class DialogueManager_TMpro : MonoBehaviour
{
    public TextMeshProUGUI TextBox;
    public Button nextButton;

    // 会話リスト
    public List<string> conversation = new List<string>
    {
        "01",
        "02",
        "03"
    };

    private int currentDialogueIndex = -1;
    public string ENDName;

    void Start()
    {
        UpdateDialogue();
    }

    public void UpdateDialogue()
    { 
        var sequence = DOTween.Sequence();
        sequence.Append(TextBox.DOFade(0f,1.5f));//フィードアウト
        sequence.AppendInterval(0.2f).OnComplete(UPText);
        currentDialogueIndex++;
        
        // リスト内のセリフを表示

    }
    public void UPText()
    {
        if (currentDialogueIndex < conversation.Count)
        {
            TextBox.text = conversation[currentDialogueIndex];
            Debug.Log(TextBox.text);
            TextBox.DOFade(1f,1f);
        }
        else
        {
            // 会話が終了したらボタンを無効化
            TextBox.text = ENDName;
            TextBox.DOFade(1f,1f);
            Debug.Log(TextBox.text);
            nextButton.interactable = false;
        }
    }

}