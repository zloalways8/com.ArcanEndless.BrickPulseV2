using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Entities
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private RectTransform rectTransform;
        [SerializeField] private RectTransform borders;
        [SerializeField] private float speed = 5;

        public bool IsStopped { get; set; } = true;

        public event Action OnMove;

        public void Move(int direction)
        {
            if (IsStopped)
                return;
         
            float delta = speed * direction * Time.fixedDeltaTime;

            rectTransform.anchoredPosition = new Vector2(
                Math.Min(Math.Max(rectTransform.anchoredPosition.x + delta, borders.rect.xMin + rectTransform.sizeDelta.x / 2f + 10f),
                    borders.rect.xMax - rectTransform.sizeDelta.x / 2f - 10f),
                rectTransform.anchoredPosition.y
            );
            OnMove?.Invoke();
        }
    }
}