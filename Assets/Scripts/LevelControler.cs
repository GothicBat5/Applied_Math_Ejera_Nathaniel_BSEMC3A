using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControler : MonoBehaviour
{
    public int giveScore;
    public int requireScoreToWin;

    public void LoadMainMenu(int index)
    {
        SceneManager.LoadScene(index);
    }
}