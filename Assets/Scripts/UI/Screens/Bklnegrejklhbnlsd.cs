using System;
using System.Collections;
using Core;
using Entities;
using Managers;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Screens
{
    public class Bklnegrejklhbnlsd : DANKLvlktr<GamePayload>
    {
        [SerializeField] private Text timeText;
        [SerializeField] private Transform gamePlace;
        [SerializeField] private BVHJKberwkjk12 leftButton;
        [SerializeField] private BVHJKberwkjk12 rightButton;

        private BNjksbnrgfjkw3eASF _bNjksbnrgfjkw3EAsf;
        private bool _isPaused;
        
        private BMkldnmlkOIWnoiqwe _bMkldnmlkOiWnoiqwe;

        public void BMKlqwer(BMkldnmlkOIWnoiqwe bMkldnmlkOiWnoiqwe)
        {
            _bMkldnmlkOiWnoiqwe = bMkldnmlkOiWnoiqwe;
        }

        public override void BVNjkvkejwer(GamePayload payload)
        {
            base.BVNjkvkejwer(payload);

            if (_bNjksbnrgfjkw3EAsf != null)
            {
                _bNjksbnrgfjkw3EAsf.OnWin -= OnWin;
                _bNjksbnrgfjkw3EAsf.OnLose -= OnLose;
                _bNjksbnrgfjkw3EAsf.OnTimeChange -= OnTimeChange;
                leftButton.BNiktjrnklnklw.RemoveAllListeners();
                rightButton.BNiktjrnklnklw.RemoveAllListeners();
                Destroy(_bNjksbnrgfjkw3EAsf.gameObject);
            }

            _bNjksbnrgfjkw3EAsf = Instantiate(
                _bMkldnmlkOiWnoiqwe.GetLevelData(payload.SelectedLevel), 
                gamePlace
            );
            _bNjksbnrgfjkw3EAsf.OnWin += OnWin;
            _bNjksbnrgfjkw3EAsf.OnLose += OnLose;
            _bNjksbnrgfjkw3EAsf.OnTimeChange += OnTimeChange;
            leftButton.BNiktjrnklnklw.AddListener(() => _bNjksbnrgfjkw3EAsf.MovePlayer(-1));
            rightButton.BNiktjrnklnklw.AddListener(() => _bNjksbnrgfjkw3EAsf.MovePlayer(1));

            _bNjksbnrgfjkw3EAsf.Bootstrap(OPakolnsadq, _bMkldnmlkOiWnoiqwe.QcEwer1, ShopScreen.TimerMultipliers[_bMkldnmlkOiWnoiqwe.ASKnmlvlrt]);
            
            timeText.text = $"Timer:\n{_bNjksbnrgfjkw3EAsf.LeftTime} sec";
            
            _bNjksbnrgfjkw3EAsf.StartGame();
        }

        public override void WOpjvporet()
        {
            base.WOpjvporet();
            
            if(_bNjksbnrgfjkw3EAsf != null)
                _bNjksbnrgfjkw3EAsf.StartGame();
        }

        public override void WSAKLNvkltr()
        {
            if(_bNjksbnrgfjkw3EAsf != null)
                _bNjksbnrgfjkw3EAsf.StopGame();
            
            base.WSAKLNvkltr();
        }

        private void OnWin()
        {
            _bMkldnmlkOiWnoiqwe.IncreasePassedLevels(Bnklrtlkturgb.SelectedLevel);
            _bMkldnmlkOiWnoiqwe.WNvnjreklqw += _bNjksbnrgfjkw3EAsf.EarnedMoney;
            
            OPakolnsadq.BNjasksldkl6();

            StartCoroutine(CallDelayed(() =>
            {
                Wklnverlk.VBSNkdnwlkeryt4r<WinScreen, EndPayload>(new EndPayload
                {
                    SelectedLevel = Bnklrtlkturgb.SelectedLevel,
                    Time = _bNjksbnrgfjkw3EAsf.LeftTime,
                    Money = _bNjksbnrgfjkw3EAsf.EarnedMoney
                });
            }));
            
        }

        private void OnLose()
        {
            _bMkldnmlkOiWnoiqwe.WNvnjreklqw += _bNjksbnrgfjkw3EAsf.EarnedMoney;
            
            OPakolnsadq.SAMvlsdf();
            
            StartCoroutine(CallDelayed(() =>
            {
                Wklnverlk.VBSNkdnwlkeryt4r<AWKjnlkvrely3, EndPayload>(new EndPayload
                {
                    SelectedLevel = Bnklrtlkturgb.SelectedLevel,
                    Time = _bNjksbnrgfjkw3EAsf.LeftTime,
                    Money = _bNjksbnrgfjkw3EAsf.EarnedMoney
                });
            }));
        }

        private void OnTimeChange(int time)
        {
            timeText.text = $"Timer:\n{time} sec";
        }

        private IEnumerator CallDelayed(Action callback)
        {
            yield return new WaitForSeconds(1f);
            
            callback.Invoke();
        }
    }

    public class GamePayload
    {
        public int SelectedLevel;
    }

    public class EndPayload
    {
        public int SelectedLevel;
        public int Time;
        public int Money;
    }
}