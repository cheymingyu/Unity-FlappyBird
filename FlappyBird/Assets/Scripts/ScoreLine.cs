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
        // ���� ���� ������ ������
        if (collision.CompareTag("Bird"))
        {
            // ���� ���� 1 ����
            bird.Score += 1;
        }
    }
}
