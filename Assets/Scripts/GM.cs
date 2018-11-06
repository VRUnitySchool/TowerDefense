using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour
{
    private bool gameEnded = false;

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
        Debug.Log("Game Over");
    }
}
