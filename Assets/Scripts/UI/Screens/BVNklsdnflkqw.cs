using Managers;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Screens
{
    public class BVNklsdnflkqw : SAOsjklvntlrke
    {
        [SerializeField] private Button[] levelButtons;
        
        private BMkldnmlkOIWnoiqwe _bMkldnmlkOiWnoiqwe;

        private void Start()
        {
            for (int i = 0; i < levelButtons.Length; ++i)
            {
                var t = i;
                levelButtons[i].onClick.AddListener(() => StartLevel(t));
            }
        }

        public void BMklwqemklq(
            BMkldnmlkOIWnoiqwe bMkldnmlkOiWnoiqwe
        )
        {
            _bMkldnmlkOiWnoiqwe = bMkldnmlkOiWnoiqwe;
            UpdateLevelButtons();
        }
        
        public void StartLevel(int levelIndex)
        {
            OPakolnsadq.POjcerwiop34();
            Wklnverlk.VBSNkdnwlkeryt4r<Bklnegrejklhbnlsd, GamePayload>(new GamePayload { SelectedLevel = levelIndex });
        }
        
        public override void WOpjvporet()
        {
            UpdateLevelButtons();
            
            base.WOpjvporet();
        }
        
        private void UpdateLevelButtons()
        {
            for (int i = 0; i < levelButtons.Length; ++i)
            {
                levelButtons[i].interactable = _bMkldnmlkOiWnoiqwe.Wopjvporte || i <= _bMkldnmlkOiWnoiqwe.POJQWPoif;
            }
        }
    }
}