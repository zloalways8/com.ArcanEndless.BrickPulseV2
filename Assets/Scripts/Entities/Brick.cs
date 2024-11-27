using System;
using UnityEngine;
using UnityEngine.UI;

namespace Entities
{
    public class Brick : MonoBehaviour
    {
        [SerializeField] private int health = 1;
        [SerializeField] private Image image;

        private int _startHealth;
        private Color _brickColor;

        public event Action OnDamage;
        public event Action<Brick> OnBreak;

        private void Start()
        {
            _startHealth = health;
            _brickColor = image.color;
        }
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            health -= 1;
            _brickColor.a = (float)health / _startHealth;
            image.color = _brickColor;
            OnDamage?.Invoke();

            if (health <= 0)
            {
                OnBreak.Invoke(this);
            }
        }
    }
}