using System.Collections;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject pipeDown;             // 복제해서 생성할 파이프 프리팹
    [SerializeField]
    private GameObject pipeUp;              // 복제해서 생성할 파이프 프리팹
    [SerializeField]
    private float spawnTime;                // 생성 주기

    public float SpawnTime
    {
        set => spawnTime = value;
        get => spawnTime;
    }

    private void Awake()
    {
        StartCoroutine("SpawnPipes");
    }

    private IEnumerator SpawnPipes()
    {
        while (true)
        {
            // 파이프를 생성할 임의의 y값 선택
            float positionY = Random.Range(-5.68f, -1.0f);
            // 아래 파이프 생성 위치
            Vector3 downPosition = new Vector3(4.7f, positionY, 0.0f);
            // 아래 파이프 생성
            GameObject pipeDownClone = Instantiate(pipeDown, downPosition, Quaternion.identity);
            // 아래 파이프 생성 위치
            Vector3 upPosition = new Vector3(4.7f, positionY + 10.0f, 0.0f);
            // 위 파이프 생성
            GameObject pipeUpClone = Instantiate(pipeUp, upPosition, Quaternion.identity);
            
            // spawnTime만큼 대기
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
