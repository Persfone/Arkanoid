using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private List<Bricks> allBricks = new List<Bricks>();
    [SerializeField] private UI uiManager;
    [SerializeField] private int currentLevel = 1;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        FindAllBricks();
    }

    private void FindAllBricks()
    {
        allBricks.Clear();
        allBricks.AddRange(FindObjectsOfType<Bricks>());
    }

    public void BrickDestroyed()
    {
        if (AreAllBricksDestroyed())
        {
            uiManager.WinScreen();
        }
    }

    private bool AreAllBricksDestroyed()
    {
        foreach (var brick in allBricks)
        {
            if (brick.gameObject.activeSelf)
                return false;
        }
        return true;
    }

    public void LoadNextLevel()
    {
        currentLevel++;
        
        foreach (var brick in allBricks)
        {
            brick.gameObject.SetActive(true);
        }
        FindObjectOfType<bolita>().ResetBall();
    }
}