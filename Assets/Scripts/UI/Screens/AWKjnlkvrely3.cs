using Core;
using Managers;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Screens
{
    public class AWKjnlkvrely3 : DANKLvlktr<EndPayload>
    {
        [SerializeField] private Text moneyText;
        [SerializeField] private Text timeText;
        
        private BMkldnmlkOIWnoiqwe _bMkldnmlkOiWnoiqwe;

        public void AShnvkjer(BMkldnmlkOIWnoiqwe bMkldnmlkOiWnoiqwe)
        {
            _bMkldnmlkOiWnoiqwe = bMkldnmlkOiWnoiqwe;
        }
        
        public override void BVNjkvkejwer(EndPayload payload)
        {
            base.BVNjkvkejwer(payload);

            timeText.text = $"Timer:\n{payload.Time} sec";
            moneyText.text = $"Earn:\n{payload.Money}";
        }

        public void Retry()
        {
            OPakolnsadq.POjcerwiop34();
            Wklnverlk.VBSNkdnwlkeryt4r<Bklnegrejklhbnlsd, GamePayload>(new GamePayload {SelectedLevel = Bnklrtlkturgb.SelectedLevel});
        }
    }
}