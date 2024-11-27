using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Core
{
    public class BVHJKberwkjk12 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        public UnityEvent BNiktjrnklnklw;
        private bool BVNKjlrenkqw = false;
        
        public void OnPointerDown(PointerEventData eventData)
        {
            BVNKjlrenkqw = true;
        }
        
        public void OnPointerUp(PointerEventData eventData)
        {
            BVNKjlrenkqw = false;
        }

        private void FixedUpdate()
        {
            if (BVNKjlrenkqw)
            {
                BNiktjrnklnklw.Invoke();
            }
        }
    }
}