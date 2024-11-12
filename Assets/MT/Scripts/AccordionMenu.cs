using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AccordionMenu : MonoBehaviour
{
    public List<GameObject> Folding_object;  // 折りたたむオブジェクトリスト
    private bool OnButton = false; // 展開状態のフラグ
    public TextMeshProUGUI Change_Text;
    private string Display = "↓";
    private string NotDisplay = "→";

    void Start()
    {
        SetFoldingObjectActive(OnButton);  // 初期状態に合わせて表示・非表示設定
        ChangeText();  // 初期状態に合わせてテキストを設定
    }

    // ボタンをクリックした際に呼ばれる関数
    public void Menu()
    {
        OnButton = !OnButton;  // 展開状態を切り替え
        SetFoldingObjectActive(OnButton);  // OnButtonの状態次第で表示・非表示を設定
        ChangeText();  // テキストを更新
    }

    // リスト内のオブジェクトを表示・非表示にするメソッド
    private void SetFoldingObjectActive(bool isActive)
    {
        foreach (GameObject obj in Folding_object)
        {
            obj.SetActive(isActive);
        }
    }

    // テキストを更新するメソッド
    public void ChangeText()
    {
        if (OnButton)
        {
            Change_Text.text = Display;
        }
        else
        {
            Change_Text.text = NotDisplay;
        }
    }
}
