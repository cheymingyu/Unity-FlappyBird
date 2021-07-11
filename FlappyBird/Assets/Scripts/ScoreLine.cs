using UnityEngine;

public class ScoreLine : MonoBehaviour
{
    private Bird bird;

    private void Awake()
    {
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<Bird>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 새가 점수 라인을 지나면
        if (collision.CompareTag("Bird"))
        {
            // 새의 점수 1 증가
            bird.Score += 1;
        }
    }
}
