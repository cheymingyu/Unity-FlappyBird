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
        // 점수판 비활성화
        scoreBoard.SetActive(false);
        // 재시작 버튼 비활성화
        restartButton.SetActive(false);
        // 최종 점수 비활성화
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
