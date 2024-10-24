using UnityEngine;

public class Hole : MonoBehaviour
{
    public int points = 1;
    public string ballTag = "Ball";
    public Transform holeCenter;
    public float fallSpeed = 5f;
    public float sinkDepth = -0.5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(ballTag))
        {
            Rigidbody ballRigidbody = other.GetComponent<Rigidbody>();
            if (ballRigidbody != null)
            {
                ballRigidbody.useGravity = false;
                ballRigidbody.isKinematic = true;
                StartCoroutine(FallIntoHole(other.gameObject));
            }
        }
    }

    private System.Collections.IEnumerator FallIntoHole(GameObject ball)
    {
        Vector3 finalPosition = new Vector3(holeCenter.position.x, holeCenter.position.y + sinkDepth, holeCenter.position.z);

        while (Vector3.Distance(ball.transform.position, finalPosition) > 0.01f)
        {
            ball.transform.position = Vector3.MoveTowards(ball.transform.position, finalPosition, fallSpeed * Time.deltaTime);
            yield return null;
        }

        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
        if (scoreManager != null)
        {
            scoreManager.IncrementScore(points); // Am schimbat UpdateScore cu IncrementScore și am transmis punctele
        }
    }
}
