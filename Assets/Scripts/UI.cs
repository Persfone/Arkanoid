using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public GameObject loseScreen;
    public GameObject winScreen;
    public GameObject nextLevelButton;
    public bolita bolita;

    private void Start()
    {
        winScreen?.SetActive(false);  
        loseScreen?.SetActive(false);
    }
    public void LoseScreen()
    {
        if (loseScreen != null)
        {
            loseScreen.SetActive(true);
            nextLevelButton.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Lose screen no asignado en el Inspector.");
        }
    }

    public void WinScreen()
    {
        if (winScreen != null)
        {
            winScreen.SetActive(true);
            nextLevelButton.SetActive(true);
            bolita.Stop();
        }
        else
        {
            Debug.LogWarning("Win screen no asignado en el Inspector.");
        }
    }

    public void OnNextLevelPressed()
    {
        GameManager.Instance.LoadNextLevel();
        winScreen.SetActive(false);
    }

    public void OnRestartPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}