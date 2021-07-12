using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField]
    private ScoreBoardSpawner scoreBoardSpawner;
    [SerializeField]
    private PositionScroller PositionScroller;
    [SerializeField]
    private PipeSpawner pipeSpawner;
    [SerializeField]
    private AudioSource audioSource;
    private Animator animator;

    private int score;
    public int Score
    {
        // score ���� ������ ���� �ʵ���
        set => score = Mathf.Max(0, value);
        get => score;
    }

    private void Awake()
    {
        Time.timeScale = 1.0f;
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ���� �ε��� ������Ʈ�� �±װ� "Pipe"Ȥ�� "Ground"�̸�
        if (collision.gameObject.tag == "Pipe" || collision.gameObject.tag == "Ground")
        {
            StartCoroutine("GameOver");
            audioSource.Play();
        }
    }

    private IEnumerator GameOver()
    {
        // ���� ����
        Time.timeScale = 0.0f;


        scoreBoardSpawner.GameOver();
        animator.speed = 0.0f;
        yield return new WaitForSeconds(1.0f);

    }

}

