using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory;
    public GameObject gun;
    
    void Start()
    {
    }
    
    void Update() // 1초에 60번 작동
    {
        // 이 안의 내용을 1초에 60번 체크
        // 만약에 OOO 하면 
        if(Input.GetButtonDown("Fire1")) // ctrl 또는 마우스 좌측키
        {
            // 이렇게 해줘. 부탁해~
            GameObject bullet = Instantiate(bulletFactory);
            
            //  또 하나의 눈에 안보이는 속성(변수) ← (담고있어야될 그릇) ← 공장에서 총알 생산
            bullet.transform.position = gun.transform.position;
        }
    }
}