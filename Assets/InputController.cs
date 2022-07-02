using UnityEngine;
using MovementsSpace;

public class InputController : MonoBehaviour
{
    public MovableObject MovementScript;
    public MovableObject MovableObject;
    private MovingBase _currentMovingManager;
    public void ChangeMovingManager(MovingBase movingManager)
    {
        if (_currentMovingManager != null)
        {
            _currentMovingManager.OnMove -= HandleMoving;
        }
        _currentMovingManager = movingManager;
        _currentMovingManager.OnMove += HandleMoving;
    }
    private void HandleMoving(Vector2 value)
    {
        MovementScript.Move(value);
    }
}