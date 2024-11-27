using UnityEngine;
using UnityEngine.UI;

namespace UI.Screens
{
    public class ASDvnklrteklw : SAOsjklvntlrke
    {
        [SerializeField] private Image soundToggle;
        [SerializeField] private Image musicToggle;
        [SerializeField] private Sprite enabledSprite;
        [SerializeField] private Sprite disabledSprite;
        
        public void Vnkmsdenkflwe()
        {
            AWNvtjkr();
        }

        public void EAKLnjklfrte()
        {
            OPakolnsadq.CNMKLrlk45 = !OPakolnsadq.CNMKLrlk45;
            OPakolnsadq.POjcerwiop34();
            AWNvtjkr();
        }

        public void WBhvtjkr()
        {
            OPakolnsadq.WNkvnanlkslk = !OPakolnsadq.WNkvnanlkslk;
            OPakolnsadq.POjcerwiop34();
            AWNvtjkr();
        }

        private void AWNvtjkr()
        {
            soundToggle.sprite = OPakolnsadq.WNkvnanlkslk ? disabledSprite : enabledSprite;
            musicToggle.sprite = OPakolnsadq.CNMKLrlk45 ? disabledSprite : enabledSprite;
        }
    }
}