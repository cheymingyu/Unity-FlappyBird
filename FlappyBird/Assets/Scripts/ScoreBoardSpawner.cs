using UnityEngine;

public class ScoreBoardSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject scoreBoard;
    [SerializeField]
    private GameObject restartButton;

    private void Awake()
    {
        // 점수판 비활성화
        scoreBoard.SetActive(false);
        // 재시작 버튼 비활성화
        restartButton.SetActive(false);

    }
}
