using System.Collections;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject pipeDown;             // �����ؼ� ������ ������ ������
    [SerializeField]
    private GameObject pipeUp;              // �����ؼ� ������ ������ ������
    [SerializeField]
    private float spawnTime;                // ���� �ֱ�

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
            // �������� ������ ������ y�� ����
            float positionY = Random.Range(-5.68f, -1.0f);
            // �Ʒ� ������ ���� ��ġ
            Vector3 downPosition = new Vector3(4.7f, positionY, 0.0f);
            // �Ʒ� ������ ����
            GameObject pipeDownClone = Instantiate(pipeDown, downPosition, Quaternion.identity);
            // �Ʒ� ������ ���� ��ġ
            Vector3 upPosition = new Vector3(4.7f, positionY + 10.0f, 0.0f);
            // �� ������ ����
            GameObject pipeUpClone = Instantiate(pipeUp, upPosition, Quaternion.identity);
            
            // spawnTime��ŭ ���
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
