using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    // Modifică IncrementScore pentru a accepta un număr de puncte
    public void IncrementScore(int points)
    {
        score += points;  // Adaugă punctele la scorul curent
        UpdateScoreText();
    }

    // Actualizează textul scorului în UI
    private void UpdateScoreText()
    {
        scoreText.text = "Lovituri: " + score.ToString();
    }

    // Resetează scorul
    public void ResetScore()
    {
        score = 0;
        UpdateScoreText();
    }
}
