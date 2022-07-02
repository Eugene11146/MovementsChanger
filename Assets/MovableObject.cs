using UnityEngine;

namespace MovementsSpace
{
    public class MovableObject : MonoBehaviour
    {
        public float TimeMovement = 3f;
        private float _elapsedTime;
        private float _percentComplete;
        private bool _isMoving = true;
        public void Move(Vector2 direction)
        {
            _elapsedTime = Time.deltaTime;
            _percentComplete = _elapsedTime / TimeMovement;
            if (_isMoving == true)
            {
                transform.position = Vector2.Lerp(transform.position, direction, _percentComplete);
            }
        }
    }
}