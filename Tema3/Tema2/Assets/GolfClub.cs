using UnityEngine;

public class GolfClub : MonoBehaviour
{
    public ScoreManager scoreManager;  
    public int pointsPerHit = 1;  

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Ball"))
        {
           
            if (scoreManager != null)
            {
                scoreManager.IncrementScore(pointsPerHit);  
            }
        }
    }
}
