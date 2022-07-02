using UnityEngine;

namespace MovementsSpace
{
    public class ADMovement : MovingBase 
    {
        private Vector2 _leftPoint = new Vector3(-6, -1);
        private Vector2 _rightPoint = new Vector3(6, -1);
        private Vector2 _midletPoint = new Vector3(0, -1);
        public  Vector2 TargetPoint;
        private void Awake()
        {
            TargetPoint = _midletPoint;
        }
        public void Update()
        {
            TargetChanger();
        }
        void TargetChanger()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (TargetPoint == _rightPoint)
                {
                    TargetPoint = _midletPoint;
                }
                else if (TargetPoint == _midletPoint)
                {
                    TargetPoint = _leftPoint;
                }
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (TargetPoint == _leftPoint)
                {
                    TargetPoint = _midletPoint;
                }
                else if (TargetPoint == _midletPoint)
                {
                    TargetPoint = _rightPoint;
                }
            }
            PutTarget(TargetPoint);
        }
        public override Vector2 PutTarget(Vector2 aim)
        {
            OnMove?.Invoke(aim);
            return aim;
        }
    }
}