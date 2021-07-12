using System.Collections;
using UnityEngine;

public class ScoreBoardSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject scoreBoard;
    [SerializeField]
    private GameObject restartButton;
    [SerializeField]
    private GameObject finalScore;

    private void Awake()
    {
        // ������ ��Ȱ��ȭ
        scoreBoard.SetActive(false);
        // ����� ��ư ��Ȱ��ȭ
        restartButton.SetActive(false);
        // ���� ���� ��Ȱ��ȭ
        finalScore.SetActive(false);

    }
    public void GameOver()
    {
        scoreBoard.SetActive(true);

        restartButton.SetActive(true);

        finalScore.SetActive(true);

        //StartCoroutine("ShowScoreBoard");
    }

    //private IEnumerator ShowScoreBoard()
    //{
    //    scoreBoard.SetActive(true);

    //    //yield return new WaitForSeconds(1.0f);

    //    restartButton.SetActive(true);
    //}

}
