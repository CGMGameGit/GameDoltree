using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    
    public void LoadScene()
    {
        Application.LoadLevel("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
