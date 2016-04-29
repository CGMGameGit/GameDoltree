using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

    public void Retry()
    {
        Application.LoadLevel("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
