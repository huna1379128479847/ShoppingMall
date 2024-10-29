using UnityEngine;
using UnityEngine.UI;

namespace BlackOut.UI
{
    [RequireComponent(typeof(ButtonVM))]
    [RequireComponent(typeof(Button))]
    public class ButtonV : TextView
    {
        [SerializeField] private Image image;
        protected override void UpdateView()
        {
            base.UpdateView();
            if (viewModel is ButtonVM buttonViewModel && buttonViewModel.Image != null)
            {
                image = buttonViewModel.Image;
            }
        }
    }
}