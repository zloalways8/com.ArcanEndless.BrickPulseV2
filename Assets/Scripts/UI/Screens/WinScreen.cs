using Core;
using Managers;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Screens
{
    public class WinScreen : DANKLvlktr<EndPayload>
    {
        [SerializeField] private Text timeText;
        [SerializeField] private Text moneyText;
        
        private BMkldnmlkOIWnoiqwe _bMkldnmlkOiWnoiqwe;

        public void Bootstrap(BMkldnmlkOIWnoiqwe bMkldnmlkOiWnoiqwe)
        {
            _bMkldnmlkOiWnoiqwe = bMkldnmlkOiWnoiqwe;
        }
        
        public override void BVNjkvkejwer(EndPayload payload)
        {
            base.BVNjkvkejwer(payload);
            
            timeText.text = $"Timer:\n{payload.Time} sec";
            moneyText.text = $"Earn:\n{payload.Money}";
        }

        public void NextLvl()
        {
            OPakolnsadq.POjcerwiop34();
            
            if (Bnklrtlkturgb.SelectedLevel >= _bMkldnmlkOiWnoiqwe.Gqwrgt4r)
            {
                Wklnverlk.VBSNkdnwlkeryt4r<BVNklsdnflkqw>();
                return;
            }
            
            Wklnverlk.VBSNkdnwlkeryt4r<Bklnegrejklhbnlsd, GamePayload>(new GamePayload {SelectedLevel = Bnklrtlkturgb.SelectedLevel + 1});
        }
    }
}