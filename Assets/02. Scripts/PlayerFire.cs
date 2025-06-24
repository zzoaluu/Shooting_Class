using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory;
    public GameObject gun;

    // 오브젝트 풀 : 총알의 탄창 만들기
    public int poolSize = 10;
    private GameObject[] bulletObjectPool;

    void Start()
    {
        bulletObjectPool = new GameObject[poolSize];

        // 게임을 시작할때 필요한 총알갯수를 한꺼번에 만든다. 
        for(int i = 0; i < poolSize; i++)
        {
            // 공장에서 총알을 만들어 배열(탄창)에 넣는다.
            GameObject bullet = Instantiate(bulletFactory);
            bulletObjectPool[i] = bullet;

            //탄창에 총알을 넣고 비활성화 시킨다.
            bulletObjectPool[i].SetActive(false);
        }
    }
    
    void Update() // 1초에 60번 작동
    {
        // 이 안의 내용을 1초에 60번 체크
        // 만약에 OOO 하면 
        if(Input.GetButtonDown("Fire1")) // ctrl 또는 마우스 좌측키
        {
            /*
            // 이렇게 해줘. 부탁해~
            GameObject bullet = Instantiate(bulletFactory);
            
            //  또 하나의 눈에 안보이는 속성(변수) ← (담고있어야될 그릇) ← 공장에서 총알 생산
            bullet.transform.position = gun.transform.position;
            */
            Fire();
        }
    }

    public void Fire()
    {
        for(int i = 0; i < poolSize; i++)
        {
            GameObject bullet = bulletObjectPool[i];

            // 탄창에서 비활성화된 총알을 발견하면
            if(bullet.activeSelf == false)
            {
                // 총알을 활성화하고 발사위치에 놓는다
                bullet.SetActive(true);
                bullet.transform.position = gun.transform.position;

                // for문 중지
                break; 
            }
        }
    }
}