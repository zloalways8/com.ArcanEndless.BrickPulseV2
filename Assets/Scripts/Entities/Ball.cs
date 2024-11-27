using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Entities
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private RectTransform rectTransform;
        [SerializeField] private Player player;
        [SerializeField] private Rigidbody2D rigidbody2D;
        
        private bool _isStarted = false;
        private Vector2 _velocity;

        public event Action OnMoveOut;

        public bool IsStopped
        {
            get => rigidbody2D.simulated;
            set
            {
                if (value)
                {
                    _velocity = rigidbody2D.velocity;
                }
                else
                {
                    rigidbody2D.velocity = _velocity;
                }
                rigidbody2D.simulated = !value;
            }
        }

        public bool IsStarted => _isStarted;

        private void Start()
        {
            player.OnMove += OnPlayerStart;
            rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            OnMoveOut?.Invoke();
        }

        private void OnPlayerStart()
        {
            if (_isStarted)
            {
                player.OnMove -= OnPlayerStart;
                return;
            }
            
            rigidbody2D.AddForce(new Vector2(Random.Range(-.6f, .6f), 1f).normalized * speed, ForceMode2D.Impulse);
            _isStarted = true;
        }
    }
}