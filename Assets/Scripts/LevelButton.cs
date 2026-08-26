using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    public int requiredPoints;
    public int LevelIndex;
    public Button LevelBtn;

    private void Start()
    {
        var currentScore = PlayerPrefs.GetInt("HighScore");
        if (currentScore >= requiredPoints)
        {
            LevelBtn.interactable = true;
        }

        else 
        {
             LevelBtn.interactable = false;
        }
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(LevelIndex);
    }

}