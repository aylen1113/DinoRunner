using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public float score = 0;         
    private int highScore = 0;
    public float scoreMultiplier = 1f;  

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "HS:" + highScore.ToString();
    }

    private void Update()
    {
        // Increase score based on time and multiplier
        score += scoreMultiplier * Time.deltaTime;

        // Update score display (casting float to int for display purposes)
        scoreText.text = "SCORE:" + Mathf.FloorToInt(score).ToString();

        // Check if current score beats the high score
        if (score > highScore)
        {
            highScore = Mathf.FloorToInt(score);
            PlayerPrefs.SetInt("HighScore", highScore);
            highScoreText.text = "HS: " + highScore.ToString();
        }
    }
}
