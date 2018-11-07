using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour
{
    private bool gameEnded;

    private void Start()
    {
        gameEnded = false;
    }

    public GameObject gameOverUI;

    private void Update()
    {
        if (gameEnded)
            return;

        if (PlayerStats.Lives <=0)
        {
            EndGame();
        }
    }

    void EndGame ()
    {
        gameEnded = true;
        gameOverUI.SetActive(true);
    }
}
