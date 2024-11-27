using Core;
using Managers;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Screens
{
    public class ShopScreen : SAOsjklvntlrke
    {
        [SerializeField] private Text moneyText;
        [SerializeField] private Button[] multiplierButtons;
        [SerializeField] private int[] costs;
        
        public static readonly float[] TimerMultipliers = { 1f, 1.1f, 1.2f, 1.4f, 1.5f };
        
        private BMkldnmlkOIWnoiqwe _bMkldnmlkOiWnoiqwe;

        public void Bootstrap(BMkldnmlkOIWnoiqwe bMkldnmlkOiWnoiqwe)
        {
            _bMkldnmlkOiWnoiqwe = bMkldnmlkOiWnoiqwe;
        }

        private void Start()
        {
            for (int i = 0; i < multiplierButtons.Length; ++i)
            {
                var t = i;
                multiplierButtons[i].onClick.AddListener(() => { BuyMultiplier(t); });
            }
        }

        public override void WOpjvporet()
        {
            UpdateValues();
            
            base.WOpjvporet();
        }

        public void BuyMultiplier(int index)
        {
            OPakolnsadq.POjcerwiop34();
            
            var cost = costs[index];
            
            if (_bMkldnmlkOiWnoiqwe.ASKnmlvlrt != index || cost > _bMkldnmlkOiWnoiqwe.WNvnjreklqw)
                return;
            
            if (!_bMkldnmlkOiWnoiqwe.OLPPPotr4)
                _bMkldnmlkOiWnoiqwe.WNvnjreklqw -= cost;
            _bMkldnmlkOiWnoiqwe.ASKnmlvlrt = index + 1;
            UpdateValues();
        }

        private void UpdateValues()
        {
            moneyText.text = $"Balance: {BNkjrlenlkqwjl4.POUJWPjvopre(_bMkldnmlkOiWnoiqwe.WNvnjreklqw)}";

            for (int i = 0; i < multiplierButtons.Length; ++i)
            {
                multiplierButtons[i].interactable = _bMkldnmlkOiWnoiqwe.ASKnmlvlrt == i;
                multiplierButtons[i].GetComponentInChildren<Text>().text = _bMkldnmlkOiWnoiqwe.ASKnmlvlrt > i ? "Bought" : "Buy";
            }
        }
    }
}