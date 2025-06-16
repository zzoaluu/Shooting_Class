using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private float createTime;
    private float currentTime;
    public GameObject enemyFactory;

    public float minTime = 1;
    public float maxTime = 5;

    void Start() // ��� 
    {        
        createTime = Random.Range(minTime, maxTime); 
    }

    void Update() // 1�ʿ� 60�� ȣ��
    {
        // 100���� �ʽð�
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
