using UnityEngine;
using MovementsSpace;

public class UIController : MonoBehaviour
{
    public SwipeMovement Swipe;
    public DragMovement Drag;
    public ADMovement AD;
    public InputController Controller;
    public static int ChoseMove;

    private void Start()
    {
        if(ChoseMove == 0)
        {
            Controller.ChangeMovingManager(AD);
        }
        if (ChoseMove == 1)
        {
            Controller.ChangeMovingManager(Swipe);
        }
        if (ChoseMove == 2)
        {
            Controller.ChangeMovingManager(Drag);
        }
    }
    public void MovementAD()
    {
        ChoseMove = 0;
        Controller.ChangeMovingManager(AD);
    }
    public void MovementSwipe()
    {
        ChoseMove = 1;
        Controller.ChangeMovingManager(Swipe);
    }
    public void MovementDrag()
    {
        ChoseMove = 2;
        Controller.ChangeMovingManager(Drag);
    }
}