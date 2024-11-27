using Managers;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Screens
{
    public class Bnjklasdkldfw : SAOsjklvntlrke
    {
        [SerializeField] private Sprite enabledToggle;
        [SerializeField] private Sprite disabledToggle;
        [SerializeField] private Image timerOffToggle;
        [SerializeField] private Image allLevelsToggle;
        [SerializeField] private Image endlessMoneyToggle;
        
        private BMkldnmlkOIWnoiqwe _bMkldnmlkOiWnoiqwe;

        public void kldfsKLSDD(BMkldnmlkOIWnoiqwe bMkldnmlkOiWnoiqwe)
        {
            _bMkldnmlkOiWnoiqwe = bMkldnmlkOiWnoiqwe;
        }

        public override void WOpjvporet()
        {
            UpdateToggles();
            
            base.WOpjvporet();
        }

        public void ToggleTimerOff()
        {
            OPakolnsadq.POjcerwiop34();
            _bMkldnmlkOiWnoiqwe.QcEwer1 = !_bMkldnmlkOiWnoiqwe.QcEwer1;
            UpdateToggles();
        }

        public void ToggleAllLevelsToggle()
        {
            OPakolnsadq.POjcerwiop34();
            _bMkldnmlkOiWnoiqwe.Wopjvporte = !_bMkldnmlkOiWnoiqwe.Wopjvporte;
            UpdateToggles();
        }

        public void ToggleEndlessMoneyToggle()
        {
            OPakolnsadq.POjcerwiop34();
            _bMkldnmlkOiWnoiqwe.OLPPPotr4 = !_bMkldnmlkOiWnoiqwe.OLPPPotr4;
            UpdateToggles();
        }

        private void UpdateToggles()
        {
            timerOffToggle.sprite = _bMkldnmlkOiWnoiqwe.QcEwer1 ? enabledToggle : disabledToggle;
            allLevelsToggle.sprite = _bMkldnmlkOiWnoiqwe.Wopjvporte ? enabledToggle : disabledToggle;
            endlessMoneyToggle.sprite = _bMkldnmlkOiWnoiqwe.OLPPPotr4 ? enabledToggle : disabledToggle;
        }
    }
}