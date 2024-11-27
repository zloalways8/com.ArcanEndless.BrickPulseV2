using System;
using System.Collections;
using System.Collections.Generic;
using Managers;
using UnityEngine;

namespace Entities
{
    public class BNjksbnrgfjkw3eASF : MonoBehaviour
    {
        [SerializeField] private Player player;
        [SerializeField] private Ball ball;
        [SerializeField] private int levelMoney = 50;
        [SerializeField] private int baseTime = 60;
        
        private HashSet<Brick> _bricks = new HashSet<Brick>();
        private float _leftTime = 0f;
        private OPakolnsadq _oPakolnsadq;
        private Coroutine _timeCoroutine;
        private bool _timerOff = false;
        private int _startBrickCount;

        public event Action<int> OnTimeChange;
        public event Action OnWin;
        public event Action OnLose;

        public int LeftTime => (int)_leftTime;
        public int EarnedMoney => (int)(levelMoney * (1f - (float)_bricks.Count / _startBrickCount));

        public void Bootstrap(OPakolnsadq oPakolnsadq, bool timerOff, float timeMultiplier)
        {
            _leftTime = baseTime * timeMultiplier;
            _oPakolnsadq = oPakolnsadq;
            _timerOff = timerOff;
        }

        private void Start()
        {
            foreach (var brick in FindObjectsOfType<Brick>())
            {
                _bricks.Add(brick);
                brick.OnDamage += OnBrickDamage;
                brick.OnBreak += OnBrickBroken;
            }
            
            _startBrickCount = _bricks.Count;
            
            ball.OnMoveOut += OnBallMoveOut;
        }

        public void StartGame()
        {
            player.IsStopped = false;
            ball.IsStopped = false;
            
            _timeCoroutine = StartCoroutine(TickTime());
        }

        public void MovePlayer(int direction)
        {
            player.Move(direction);
        }

        public void StopGame()
        {
            if (_timeCoroutine != null)
                StopCoroutine(_timeCoroutine);

            player.IsStopped = true;
            ball.IsStopped = true;
        }

        private void OnBrickDamage()
        {
            _oPakolnsadq.Bnkjaskld2();
        }

        private void OnBrickBroken(Brick brick)
        {
            brick.OnBreak -= OnBrickBroken;
            brick.OnDamage -= OnBrickDamage;
            _bricks.Remove(brick);
            Destroy(brick.gameObject);

            if (_bricks.Count == 0)
            {
                StopGame();
                OnWin?.Invoke();
            }
        }

        private void OnBallMoveOut()
        {
            StopGame();
            OnLose?.Invoke();
        }

        private IEnumerator TickTime()
        {
            while (_leftTime > 0)
            {
                if (!_timerOff && ball.IsStarted)
                {
                    _leftTime -= Time.deltaTime;
                    OnTimeChange?.Invoke((int)_leftTime);
                }

                yield return null;
            }
            
            StopGame();
            OnLose?.Invoke();
        }
    }
}