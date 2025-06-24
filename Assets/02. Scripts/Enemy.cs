using UnityEngine;

// 탄생하는 에너미들 중에서 30% 정도는 플레이어 방향으로 마치 유도탄처럼 살짝 방향을 틀어서 가도록 한다.
public class Enemy : MonoBehaviour
{
    public float speed = 5;
    private Vector3 dir;

    // 폭발효과 프리펩 가져오기 
    public GameObject explosionFactory;


    // void Start()  // 태어날때 내 운명이 정해진다. 사주! 
    void OnEnable() // 내 자신이 활성화될때 - 실행해라 ↔ OnDisable() : 내가 비활성화될때 
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
        //ScoreManager.instance.Score = ScoreManager.instance.Score + 1;
        // (쓰기)현재점수 업데이트    =   (읽기)현재점수를 읽어와서   + 1    
        //            6             =                5            + 1  
        //ScoreManager.instance.Score += 1;
        ScoreManager.instance.Score++;

        // ──────────────────────────────────────────────────────
        // 폭발효과 그릇   <-  폭발효과 생산 
        GameObject explosion = Instantiate(explosionFactory);
        // 폭발효과 위치
        explosion.transform.position = transform.position;
        // ──────────────────────────────────────────────────────


        // 총알이면 비활성화
        //   충돌한   게임오브젝트.이름. 포함하고 있니? "Bullet"
        if (collision.gameObject.name.Contains("Bullet"))
        {
            // 지금의 상황 : 에너미 자신 - 총알
            // 총알 - 비활성화
            // SetActive(false) : 비활성화
            // SetActive(true): 활성화 
            collision.gameObject.SetActive(false);
        }
        // 플레이어일 경우 
        else
        {
            // 플레이어 - 너는 파괴할께
            Destroy(collision.gameObject);
        }
            
        // 에너미 나 자신 → 파괴가 아니라 비활성화! 
        // Destroy(gameObject);
        gameObject.SetActive(false);
    }
}
