using UnityEngine;
using System.Collections;

public class TideController : MonoBehaviour
{
    public float minHeight = -5.0f; // Lowest position of the wooden stake
    public float maxHeight = 5.0f;  // Highest position of the wooden stake
    public float moveDuration = 7.0f; // Time to move from minHeight to maxHeight and vice versa
    public float initialDelay = 5.0f; // Time to wait at minHeight before starting the movement

    private void Start()
    {
        // Start the coroutine to control the wooden stake movement
        StartCoroutine(MoveWoodenStake());
    }

    private IEnumerator MoveWoodenStake()
    {
        // Set the initial position at minHeight
        Vector3 startPosition = transform.position;
        startPosition.y = minHeight;
        transform.position = startPosition;

        // Wait at minHeight for the initial delay time
        yield return new WaitForSeconds(initialDelay);

        while (true)
        {
            // Move up to maxHeight
            yield return StartCoroutine(MoveToPosition(minHeight, maxHeight, moveDuration));

            // Move down to minHeight
            yield return StartCoroutine(MoveToPosition(maxHeight, minHeight, moveDuration));
        }
    }

    private IEnumerator MoveToPosition(float startHeight, float endHeight, float duration)
    {
        float elapsedTime = 0.0f;
        Vector3 startPosition = transform.position;
        startPosition.y = startHeight;
        Vector3 endPosition = transform.position;
        endPosition.y = endHeight;

        while (elapsedTime < duration)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the final position is set to endPosition
        transform.position = endPosition;
    }
}
