using UnityEngine;

public class PositionAutoDestroyer : MonoBehaviour
{
    private void LateUpdate()
    {
        if (transform.position.x < -5.0f||
            transform.position.x > 5.0f)
        {
            Destroy(gameObject);
        }
    }
}
