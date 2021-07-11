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
        // Text UI에 현재 점수 정보를 업데이트
        textScore.text = " " + bird.Score;
    }
}
