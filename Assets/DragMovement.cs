using UnityEngine;
using UnityEngine.EventSystems;

namespace MovementsSpace
{
    public class DragMovement : MovingBase, IDragHandler
    {
        private float _xCoordiate;
        private  Vector2 _dragPosition;
        public void OnDrag(PointerEventData eventData)
        {
            transform.position = eventData.position;
            _dragPosition = new Vector2(_xCoordiate, -1f);
            _xCoordiate = ((transform.position.x - (Screen.width / 2)) * 0.01f);
            if (_xCoordiate > 6f)
            {
                _xCoordiate = 6f;
            }
            if (_xCoordiate < -6f)
            {
                _xCoordiate = -6f;
            }
            PutTarget(_dragPosition);
        }
        public override Vector2 PutTarget(Vector2 aim)
        {
            OnMove?.Invoke(aim);
            return aim;
        }
        public void FixedUpdate()
        {
            PutTarget(_dragPosition);
        }
    }
}