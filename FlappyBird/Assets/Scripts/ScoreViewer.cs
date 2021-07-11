using UnityEngine;
using TMPro;

public class ScoreViewer : MonoBehaviour
{
    [SerializeField]
    private Bird bird;
    private TextMeshProUGUI textScore;

    private void Awake()
    {
        textScore = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        // Text UI�� ���� ���� ������ ������Ʈ
        textScore.text = " " + bird.Score;
    }
}
