using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections;

public class DialogueManager_TMpro : MonoBehaviour
{
    public TextMeshProUGUI TextBox;
    public Image Button_image;
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
    public GameObject TitleButton;

    void Start()
    {
        nextButton.interactable = false;
        UpdateDialogue();
        
        TitleButton.gameObject.SetActive(false);

    }

    public void UpdateDialogue()
    { 
        nextButton.interactable = false;
        var sequence = DOTween.Sequence();
        sequence.Append(TextBox.DOFade(0f,1.5f));//フィードアウト
        sequence.Join(Button_image.DOFade(0f,1.5f));//フィードアウト
        sequence.AppendInterval(0.2f).OnComplete(UPText);
        currentDialogueIndex++;
        
        // リスト内のセリフを表示

    }
    public void UPText()
    {
        if (currentDialogueIndex < conversation.Count)
        {
            var sequence = DOTween.Sequence();
            TextBox.text = conversation[currentDialogueIndex];
            
            StartCoroutine(Button_false());
            Debug.Log(TextBox.text);
            sequence.Append(TextBox.DOFade(1f,1f));
            sequence.Join(Button_image.DOFade(1f,1f));
        }
        else
        {
            // 会話が終了したらボタンを無効化
            var sequence = DOTween.Sequence();
            TextBox.text = ENDName;
            nextButton.interactable = false;
            sequence.Append(TextBox.DOFade(1f,1f));
            sequence.Join(Button_image.DOFade(0f,1f));
            Debug.Log(TextBox.text);
            TitleButton.gameObject.SetActive(true);

        }
    }
        IEnumerator Button_false()
    {
        yield return new WaitForSeconds(1);
        nextButton.interactable = true;
    }
}
