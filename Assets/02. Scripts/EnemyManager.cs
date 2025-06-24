using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private float createTime;
    private float currentTime;
    public GameObject enemyFactory;

    public float minTime = 1;
    public float maxTime = 5;

    // 에너미 오브젝트풀 속성 
    public int poolSize = 10;
    private GameObject[] enemyObjectPool;

    // 스폰 포인트 관리 - 배열 
    public Transform[] spawnPoints;

    void Start() // 출생 
    {        
        createTime = Random.Range(minTime, maxTime); 

        // 에너미 오브젝트풀 생성
        enemyObjectPool = new GameObject[poolSize];

        for(int i = 0; i < poolSize; i++)
        {
            // 에너미 공장에서 에너미를 한꺼번에 만들어서 배열에 넣는다
            GameObject enemy = Instantiate(enemyFactory);
            // 에너미 만든 다음에 격납고에 넣기 
            enemyObjectPool[i] = enemy;

            // 비활성화 시키기
            enemyObjectPool[i].SetActive(false);
        }
    }

    void Update() // 1초에 60번 호출
    {
        currentTime = currentTime + Time.deltaTime;
        if (currentTime > createTime)
        {
            for(int i = 0; i < poolSize; i++)
            {
                GameObject enemy = enemyObjectPool[i];

                // 비활성화된 에너미를 찾았다면
                if(enemy.activeSelf == false)
                {
                    // 랜덤 스폰포인트(적 생성위치)
                    int randomIndex = Random.Range(0, spawnPoints.Length);
                    enemy.transform.position = spawnPoints[randomIndex].position;

                    enemy.SetActive(true);

                    // for문 나가기
                    break;
                }
            }
            currentTime = 0;
            createTime = Random.Range(minTime, maxTime);
        }
    }
}
