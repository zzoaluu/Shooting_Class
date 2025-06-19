using UnityEngine;

// 탄생하는 에너미들 중에서 30% 정도는 플레이어 방향으로 마치 유도탄처럼 살짝 방향을 틀어서 가도록 한다.
public class Enemy : MonoBehaviour
{
    public float speed = 5;
    private Vector3 dir;

    // 폭발효과 프리펩 가져오기 
    public GameObject explosionFactory;


    void Start()  // 태어날때 내 운명이 정해진다. 사주! 
    {
        int ranValue = Random.Range(0, 10);
        if(ranValue < 3) // 0, 1, 2
        {
            // 그릇(player) ← player를 찾아서
            GameObject player = GameObject.Find("Player");
            
            //    그릇(player) 의 위치값     -  내 자신의 위치값
            dir = player.transform.position - transform.position;
            
            // 1의 크기로 만들어준다.
            dir.Normalize();

            //  나의 (미래) 위치값 = 나의 (현재) 위치값 + 변화하는 값
            // transform.position = transform.position + dir * speed * Time.deltaTime;
            transform.position += dir * speed * Time.deltaTime;

        }
        else // 3 ~ 10
        {
            dir = Vector3.down;
        }
    }

    void Update() // 니 팔자대로 살어
    {
        // Vector3 dir = Vector3.down;
        transform.position = transform.position + dir * speed * Time.deltaTime; 
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 폭발효과 그릇   <-  폭발효과 생산 
        GameObject explosion = Instantiate(explosionFactory);
        // 위치
        explosion.transform.position = transform.position;

        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
