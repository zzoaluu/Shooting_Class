using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10;

    void Start()
    {
        
    }
    
    void Update()
    {
        // 나의 (미래) 위치 =   나의 (현재) 위치  + [위치 변화값 : 방향 * 스피드 * Time.deltatime(성능보정)]
        transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
    }
}
