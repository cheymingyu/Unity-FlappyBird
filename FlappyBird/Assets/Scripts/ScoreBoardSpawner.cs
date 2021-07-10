using UnityEngine;

public class ScoreBoardSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject scoreBoard;
    [SerializeField]
    private GameObject restartButton;

    private void Awake()
    {
        // ������ ��Ȱ��ȭ
        scoreBoard.SetActive(false);
        // ����� ��ư ��Ȱ��ȭ
        restartButton.SetActive(false);

    }
}
