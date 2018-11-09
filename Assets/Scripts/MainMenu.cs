using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string levelToLoad = "TowerDefense";

    public void Play ()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void Quit ()
    {
        Debug.Log("Quiting...");
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
