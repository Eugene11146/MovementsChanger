using UnityEngine;
using UnityEngine.EventSystems;

namespace MovementsSpace
{
    public class SwipeMovement : MovingBase, IDragHandler, IBeginDragHandler, IEndDragHandler
    {
        private float _beginSwipePosition;
        private float _endSwipePosition;
        private float _swipeSide;
        private Vector2 _leftPoint = new Vector3(-6, -1);
        private Vector2 _rightPoint = new Vector3(6, -1);
        private Vector2 _midletPoint = new Vector3(0, -1);
        private  Vector2 _swipePoint;
        private void Start()
        {
            _swipePoint = _midletPoint;
        }
        public void OnBeginDrag(PointerEventData eventData)
        {
            _beginSwipePosition = transform.position.x;
        }
        public void OnDrag(PointerEventData eventData)
        {
            transform.position = eventData.position;
        }
        public void OnEndDrag(PointerEventData eventData)
        {
            _endSwipePosition = transform.position.x;
            _swipeSide = _beginSwipePosition - _endSwipePosition;
            if (_swipeSide > 0)
            {
                if (_swipePoint == _rightPoint)
                {
                    _swipePoint = _midletPoint;
                }
                else if (_swipePoint == _midletPoint)
                {
                    _swipePoint = _leftPoint;
                }
            }

            if (_swipeSide < 0)
            {
                if (_swipePoint == _leftPoint)
                {
                    _swipePoint = _midletPoint;
                }
                else if (_swipePoint == _midletPoint)
                {
                    _swipePoint = _rightPoint;
                }
            }

            PutTarget(_swipePoint);
        }
        public override Vector2 PutTarget(Vector2 aim)
        {
            OnMove?.Invoke(aim);
            return aim;
        }
        private void FixedUpdate()
        {
            PutTarget(_swipePoint);
        }
    }
}