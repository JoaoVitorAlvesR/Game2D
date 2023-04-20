using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public int totalScore;
    public Text scoreText;

    public GameObject gameOver;

    public static GameController instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this; 
        if(SalvaScore.ScoreTotal != 0){
            totalScore = SalvaScore.ScoreTotal;
            scoreText.text = totalScore.ToString();
        }
        
        
    }

    void Update(){
      SalvaScore.ScoreTotal = totalScore;
    }

    public void UpdateScoreText(){
        scoreText.text = totalScore.ToString();
        SalvaScore.ScoreTotal = totalScore;
    }
    
    public void ShowGameOver(){
        gameOver.SetActive(true);
    }

    public void RestartGame(string lvlName){
        SceneManager.LoadScene(lvlName);    }
    
}
