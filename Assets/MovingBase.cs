using UnityEngine;
using UnityEngine.Events;

public abstract class MovingBase : MonoBehaviour
{
    public delegate Vector2 InputData(Vector2 target);
    public UnityAction<Vector2> OnMove;
    public abstract Vector2 PutTarget(Vector2 aim);
}
