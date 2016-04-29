using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class scriptGameController : MonoBehaviour {

    public static bool isGameOver;

    public static int score;
    public static int lives;
    
    public Canvas CanvasOver;

    public Text TxtScore;
    public Text TxtScoreOver;
    public Text TxtBestScoreOver;
     
	void Start () {

        isGameOver = false;

        scriptGameController.score = 0;
        scriptGameController.lives = 1;

        TxtScore.text = scriptGameController.score.ToString();        
    }
	
	void Update () {

        if (!scriptGameController.isGameOver)
        {
            int bestScore = PlayerPrefs.GetInt("BestScore", 0);

            if(scriptGameController.score > bestScore)
            {
                PlayerPrefs.SetInt("BestScore", scriptGameController.score);
            }

            TxtScore.text = scriptGameController.score.ToString();
            TxtScoreOver.text = "Score : " + scriptGameController.score;
            TxtBestScoreOver.text = "Best Score : " + PlayerPrefs.GetInt("BestScore", 0);           
        }
        
        if(scriptGameController.lives <= 0)
        {            
            CanvasOver.gameObject.SetActive(true);

            isGameOver = true;
        }

        /*if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }*/	
	}
}
