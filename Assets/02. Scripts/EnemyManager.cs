using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private float createTime;
    private float currentTime;
    public GameObject enemyFactory;

    public float minTime = 1;
    public float maxTime = 5;

    void Start() // 출생 
    {        
        createTime = Random.Range(minTime, maxTime); 
    }

    void Update() // 1초에 60번 호출
    {
        // 100미터 초시계
        currentTime = currentTime + Time.deltaTime;

        if (currentTime > createTime)
        {
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position;
            currentTime = 0;

            createTime = Random.Range(minTime, maxTime);
        }
    }
}
