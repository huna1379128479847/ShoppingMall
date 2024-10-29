using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

namespace BlackOut.UI
{
    // 基本的なViewModelクラス
    public abstract class ViewModelBase : MonoBehaviour
    {
        public event System.Action OnDataChanged;

        protected void NotifyDataChanged()
        {
            OnDataChanged?.Invoke();
        }

        public abstract void UpdateView();
    }

    // 基本的なUIを管理するViewBaseクラス
    public abstract class ViewBase<TViewModel> : MonoBehaviour where TViewModel : ViewModelBase
    {
        protected TViewModel viewModel;

        protected virtual void Start()
        {
            viewModel = GetComponent<TViewModel>();

            if (viewModel != null)
            {
                viewModel.OnDataChanged += UpdateView;
                viewModel.UpdateView();
            }
        }

        protected abstract void UpdateView();

        protected virtual void OnDestroy()
        {
            if (viewModel != null)
            {
                viewModel.OnDataChanged -= UpdateView;
            }
        }
    }

    // テキストを扱う基本的なViewModel
    public abstract class TextViewModel : ViewModelBase, ICustomizableText
    {
        public string TextData { get; private set; }
        public int FontSize { get; private set; }
        public Color TextColor { get; private set; } = Color.black;
        public bool IsHide { get; private set; } = false;

        public bool IsInit { get; private set; } = false;

        public virtual void SetText(string text)
        {
            if (TextData != text)
            {
                TextData = text;
                NotifyDataChanged();
            }
        }

        public virtual void SetFontSize(int fontSize)
        {
            if (FontSize != fontSize)
            {
                FontSize = fontSize;
                NotifyDataChanged();
            }
        }

        public virtual void SetColor(Color color)
        {
            if (TextColor != color)
            {
                TextColor = color;
                NotifyDataChanged();
            }
        }

        public virtual void Show()
        {
            IsHide = false;
            NotifyDataChanged();
        }

        public virtual void Hide()
        {
            IsHide = true;
            NotifyDataChanged();
        }

        public override void UpdateView()
        {
            // 派生クラスでUIを更新する実装を記述
        }

        protected virtual void Start()
        {
            IsInit = true;
        }
    }

    // テキストUIのビューを扱う抽象クラス
    public abstract class TextView : ViewBase<TextViewModel>
    {
        [SerializeField] private TextMeshProUGUI uiText;
        protected override void UpdateView()
        {
            if (uiText != null && viewModel != null)
            {
                uiText.text = viewModel.TextData;
                uiText.fontSize = viewModel.FontSize > 0 ? viewModel.FontSize : uiText.fontSize;
                uiText.color = viewModel.TextColor;
                uiText.gameObject.SetActive(!viewModel.IsHide);
            }
        }
    }

    // 画像を扱う基本的なViewModel
    public abstract class ImageViewModel : ViewModelBase, ICustomizableImage
    {
        public Sprite ImageData { get; private set; }
        public Color ImageColor { get; private set; }
        public bool IsHide { get; private set; }
        public bool IsInit {  get; private set; }

        public virtual void SetSprite(Sprite sprite)
        {
            if (ImageData != sprite)
            {
                ImageData = sprite;
                NotifyDataChanged();
            }
        }

        public virtual void SetImage(Image image)
        {
            // Imageを直接扱うならここで実装
        }

        public virtual void SetColor(Color color)
        {
            if (ImageColor != color)
            {
                ImageColor = color;
                NotifyDataChanged();
            }
        }

        public virtual void Show()
        {
            IsHide = false;
            NotifyDataChanged();
        }

        public virtual void Hide()
        {
            IsHide = true;
            NotifyDataChanged();
        }

        public override void UpdateView()
        {
            // 派生クラスでUIを更新する実装を記述
        }

        protected virtual void Start()
        {
            IsInit = true;
        }
    }

    // 画像UIのビューを扱う抽象クラス
    public abstract class ImageView : ViewBase<ImageViewModel>
    {
        [SerializeField] private Image uiImage;

        protected override void UpdateView()
        {
            if (uiImage != null && viewModel != null)
            {
                uiImage.sprite = viewModel.ImageData;
                uiImage.color = viewModel.ImageColor;
                uiImage.gameObject.SetActive(!viewModel.IsHide);
            }
        }
    }

    // 追従するUIのViewModelクラス
    public abstract class FollowTextViewModel : TextViewModel, IFollowUI
    {
        public Vector2 Offset { get; private set; }
        public Transform Target { get; private set; }

        public Camera FollowCamera { get; private set; }

        public virtual void SetOffset(Vector2 offset)
        {
            Offset = offset;
            NotifyDataChanged();
        }

        public virtual void SetTarget(Transform target)
        {
            Target = target;
            NotifyDataChanged();
        }

        public virtual void SetCamera(Camera camera)
        {
            FollowCamera = camera;
        }
        public override void UpdateView()
        {
            // UIの追従位置やテキストの表示を更新
        }
    }

    // 追従するテキストUIのビューを扱う抽象クラス
    public abstract class FollowTextView : TextView
    {
        protected void Update()
        {
            if (viewModel is FollowTextViewModel followTextViewModel)
            {
                if (followTextViewModel.Target != null)
                {
                    Vector3 screenPosition = followTextViewModel.FollowCamera.WorldToScreenPoint(followTextViewModel.Target.position + (Vector3)followTextViewModel.Offset);
                    transform.position = screenPosition;
                }
            }
        }
    }
}
