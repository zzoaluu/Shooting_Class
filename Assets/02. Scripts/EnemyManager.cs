using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private float createTime;
    private float currentTime;
    public GameObject enemyFactory;

    public float minTime = 1;
    public float maxTime = 5;

    // ���ʹ� ������ƮǮ �Ӽ� 
    public int poolSize = 10;
    private GameObject[] enemyObjectPool;

    // ���� ����Ʈ ���� - �迭 
    public Transform[] spawnPoints;

    void Start() // ��� 
    {        
        createTime = Random.Range(minTime, maxTime); 

        // ���ʹ� ������ƮǮ ����
        enemyObjectPool = new GameObject[poolSize];

        for(int i = 0; i < poolSize; i++)
        {
            // ���ʹ� ���忡�� ���ʹ̸� �Ѳ����� ���� �迭�� �ִ´�
            GameObject enemy = Instantiate(enemyFactory);
            // ���ʹ� ���� ������ �ݳ��� �ֱ� 
            enemyObjectPool[i] = enemy;

            // ��Ȱ��ȭ ��Ű��
            enemyObjectPool[i].SetActive(false);
        }
    }

    void Update() // 1�ʿ� 60�� ȣ��
    {
        currentTime = currentTime + Time.deltaTime;
        if (currentTime > createTime)
        {
            for(int i = 0; i < poolSize; i++)
            {
                GameObject enemy = enemyObjectPool[i];

                // ��Ȱ��ȭ�� ���ʹ̸� ã�Ҵٸ�
                if(enemy.activeSelf == false)
                {
                    // ���� ��������Ʈ(�� ������ġ)
                    int randomIndex = Random.Range(0, spawnPoints.Length);
                    enemy.transform.position = spawnPoints[randomIndex].position;

                    enemy.SetActive(true);

                    // for�� ������
                    break;
                }
            }
            currentTime = 0;
            createTime = Random.Range(minTime, maxTime);
        }
    }
}
