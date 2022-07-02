using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public GameObject DragImage;
    public GameObject SwipeImage;
    public void SaveGame()
    {
        PlayerPrefs.SetInt("SavedMoving", UIController.ChoseMove);
        PlayerPrefs.Save();
        Debug.Log(UIController.ChoseMove);
    }

    void LoadGame()
    {
        if (PlayerPrefs.HasKey("SavedMoving"))
        {
            UIController.ChoseMove = PlayerPrefs.GetInt("SavedMoving");
            Debug.Log("Game data loaded!");
        }
        else
        {
            PlayerPrefs.DeleteAll();
            UIController.ChoseMove = -1;
            Debug.Log("Data reset complete");
        }

        if (UIController.ChoseMove == 1)
        {
            SwipeImage.SetActive(true);
        }
        if (UIController.ChoseMove == 2)
        {
            DragImage.SetActive(true);
        }
    }
    private void Awake()
    {
        LoadGame();
        Debug.Log(UIController.ChoseMove);
    }
}