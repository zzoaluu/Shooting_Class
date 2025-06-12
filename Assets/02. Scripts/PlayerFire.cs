using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory;
    public GameObject gun;
    
    void Start()
    {
    }

    // ex) 1초에 60번 작동한다면
    void Update()
    {
        // 이 안의 내용을 1초에 60번 체크
        // [ if문 ] 만약에 OOO 하면 xxx 하겠다
        if (Input.GetButtonDown("Fire1")) // 만약에 ctrl 또는 마우스 좌키를 누른다면
        {
            // ~ 이렇게 하겠다.
            GameObject bullet = Instantiate(bulletFactory);
            // 눈에 안보이는 또 하나의 속성(변수) bullet ← (담고 있어야될 그릇) ← 공장에서 총알 생산
            bullet.transform.position = gun.transform.position;
            // bullet의 위치 = 총의 위치 (에서 발사되야 하니까)
        }
    }
}
